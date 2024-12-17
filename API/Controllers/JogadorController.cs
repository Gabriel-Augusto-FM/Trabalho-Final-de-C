using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorService _service;

        public JogadorController(IJogadorService service)
        {
            _service = service;
        }

        /// <summary>
        /// Registre uma nova partida
        /// </summary>
        /// <param name="jogador"></param>
        [HttpPost("adicionar-jogador")]
        public IActionResult AdicionarTreinamento(Jogador jogador)
        {
            try
            {
                _service.Adicionar(jogador);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest($"Ocorreu um erro ao tentar registrar um novo jogador, o erro ocorrido foi: \n {e.Message}");
            }

        }

        /// <summary>
        /// Lista os jogadores registrados
        /// </summary>
        /// <returns></returns>
        [HttpGet("listar-jogador")]
        public List<Jogador> ListarJogadores()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar os jogadores");
            }
        }


        /// <summary>
        /// Edita as informações de um jogador
        /// </summary>
        /// <param name="j"></param>
        [HttpPut("editar-jogador")]
        public IActionResult EditarJogador(Jogador j)
        {
            try
            {
                _service.Editar(j);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao editar as informações do jogador, o erro foi: \n {e.Message}");
            }
        }

        /// <summary>
        /// Deletar um jogador registrado
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("deletar-jogador")]
        public IActionResult DeletarJogador(int id)
        {
            try
            {
                _service.Remover(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest($"Ocorreu um erro ao excluir o jogador, o erro foi: \n {e.Message}");
            }
        }
    }
}
