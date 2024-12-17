using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreinadorController : ControllerBase
    {
        private readonly ITreinadorService _service;

        public TreinadorController(ITreinadorService service)
        {
            _service = service;
        }

        /// <summary>
        /// Registre um novo treinador
        /// </summary>
        /// <param name="treinador"></param>
        [HttpPost("adicionar-treinador")]
        public IActionResult AdicionarTreinamento(Treinador treinador)
        {
            try
            {
                _service.Adicionar(treinador);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest($"Ocorreu um erro ao tentar registrar um novo treinador, o erro ocorrido foi: \n {e.Message}");
            }

        }

        /// <summary>
        /// Lista os treinadores registrados
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar-treinadores")]
        public List<Treinador> ListarTreinadores()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar os treinadores");
            }
        }


        /// <summary>
        /// Edita as informações de algum treinador
        /// </summary>
        /// <param name="t"></param>
        [HttpPut("editar-treinador")]
        public IActionResult EditarTreinador(Treinador t)
        {
            try
            {
                _service.Editar(t);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao editar as informações do treinador, o erro foi: \n {e.Message}");
            }
        }

        /// <summary>
        /// Deletar um treinador registrado
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("deletar-treinador")]
        public IActionResult DeletarTreinador(int id)
        {
            try
            {
                _service.Remover(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao excluir um treinador, o erro foi: \n {e.Message}");
            }
        }

    }
}
