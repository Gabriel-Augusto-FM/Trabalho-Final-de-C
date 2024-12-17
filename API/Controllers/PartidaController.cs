using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartidaController : ControllerBase
    {
        private readonly IPartidaService _service;

        public PartidaController(IPartidaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Registre uma nova partida
        /// </summary>
        /// <param name="partida"></param>
        [HttpPost("adicionar-treinador")]
        public IActionResult AdicionarTreinamento(Partida partida)
        {
            try
            {
                _service.Adicionar(partida);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest($"Ocorreu um erro ao tentar registrar uma nova partida, o erro ocorrido foi: \n {e.Message}");
            }

        }

        /// <summary>
        /// Lista as partidas registradas
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar-partidas")]
        public List<Partida> ListarPartidas()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar as partidas");
            }
        }


        /// <summary>
        /// Edita as informações de uma partida
        /// </summary>
        /// <param name="p"></param>
        [HttpPut("editar-partida")]
        public IActionResult EditarPartida(Partida p)
        {
            try
            {
                _service.Editar(p);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao editar as informações da partida, o erro foi: \n {e.Message}");
            }
        }

        /// <summary>
        /// Deletar um treinador registrado
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("deletar-partida")]
        public IActionResult DeletarPartida(int id)
        {
            try
            {
                _service.Remover(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao excluir a partida, o erro foi: \n {e.Message}");
            }
        }
    }
}
