using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipeController : ControllerBase
    {
        private readonly IEquipeService _service;

        public EquipeController(IEquipeService service)
        {
            _service = service;
        }

        /// <summary>
        /// Registre uma nova equipe
        /// </summary>
        /// <param name="equipe"></param>
        [HttpPost("adicionar-equipe")]
        public IActionResult AdicionarTreinamento(Equipe equipe)
        {
            try
            {
                _service.Adicionar(equipe);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest($"Ocorreu um erro ao tentar registrar uma nova equipe, o erro ocorrido foi: \n {e.Message}");
            }

        }

        /// <summary>
        /// Lista as equipes registradas
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar-equipes")]
        public List<Equipe> ListarEquipes()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar as equipes");
            }
        }


        /// <summary>
        /// Edita as informações de uma equipe
        /// </summary>
        /// <param name="e"></param>
        [HttpPut("editar-equipe")]
        public IActionResult EditarEquipe(Equipe e)
        {
            try
            {
                _service.Editar(e);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao editar as informações do jogador, o erro foi: \n {ex.Message}");
            }
        }

        /// <summary>
        /// Deletar uma equipe registrada
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("deletar-equipe")]
        public IActionResult DeletarEquipe(int id)
        {
            try
            {
                _service.Remover(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao excluir a equipe, o erro foi: \n {e.Message}");
            }
        }



    }
}
