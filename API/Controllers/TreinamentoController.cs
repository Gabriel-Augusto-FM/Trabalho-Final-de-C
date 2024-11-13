using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreinamentoController : ControllerBase
    {
        private readonly ITreinamentoService _service;

        public TreinamentoController( ITreinamentoService service)
        {
            _service = service;
        }

        /// <summary>
        /// Gerencie e agende seu treinamento na data que quiser
        /// </summary>
        /// <param name="treinamento"></param>
        [HttpPost("adicionar-treinamento")]
        public IActionResult AdicionarTreinamento(Treinamento treinamento)
        {
            try
            {
                _service.Adicionar(treinamento);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest($"Ocorreu um erro ao tentar marcar um treinamento, o erro ocorrido foi:  \n {e.Message}");
            }

        }

        /// <summary>
        /// Lista os treinamentos agendados
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar-treinamento")]
        public List<Treinamento> ListarAluno()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar os treinamentos");
            }
        }


        /// <summary>
        /// Edita o agendamento de um horario para treinamento
        /// </summary>
        /// <param name="t"></param>
        [HttpPut("editar-treinamento")]
        public IActionResult EditarTreinamento(Treinamento t)
        {
            try
            {
                _service.Editar(t);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao editar o horario e data do treinamento, o erro foi \n {e.Message}");
            }
        }

        /// <summary>
        /// Deleta uma venda
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("deletar-treinamento")]
        public IActionResult DeletarTreinamento(int id)
        {
            try
            {
                _service.Remover(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao excluir um agendamento, o erro foi \n {e.Message}");
            }
        }
    }
}
