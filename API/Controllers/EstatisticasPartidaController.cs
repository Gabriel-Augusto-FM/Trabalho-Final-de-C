using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstatisticasPartidaController : ControllerBase
    {
        private readonly IEstatisticasPartidaService _service;

        public EstatisticasPartidaController(IEstatisticasPartidaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Registre as estatisticas da partida
        /// </summary>
        /// <param name="estatisticas"></param>
        [HttpPost("adicionar-estatisticas")]
        public IActionResult AdicionarEstatisticasPartida(EstatisticasPartida estatisticas)
        {
            try
            {
                _service.Adicionar(estatisticas);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest($"Ocorreu um erro ao tentar registrar as estatisticas, o erro ocorrido foi: \n {e.Message}");
            }

        }

        /// <summary>
        /// Lista as estatisticas da partida
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar-estatisticas")]
        public List<EstatisticasPartida> ListarEstatisticas()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar as estatisticas");
            }
        }


        /// <summary>
        /// Edita as estatisticas de uma partida
        /// </summary>
        /// <param name="e"></param>
        [HttpPut("editar-estatisticas")]
        public IActionResult EditarEstatisticasPartida(EstatisticasPartida e)
        {
            try
            {
                _service.Editar(e);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao editar as informações da partida, o erro foi: \n {ex.Message}");
            }
        }

        /// <summary>
        /// Deleta as estatisticas da partida
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("deletar-estatisticas")]
        public IActionResult DeletarEstatisticasPartida(int id)
        {
            try
            {
                _service.Remover(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao excluir as estatisticas da partida, o erro foi: \n {e.Message}");
            }
        }
    }
}
