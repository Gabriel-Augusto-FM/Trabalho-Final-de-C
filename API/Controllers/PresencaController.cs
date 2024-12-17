using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PresencaController : ControllerBase
    {
        //private readonly IPresencaService _service;

        //public PresencaController(IPresencaService service)
        //{
        //    _service = service;
        //}

        ///// <summary>
        ///// Registre as presenças
        ///// </summary>
        ///// <param name="presenca"></param>
        //[HttpPost("adicionar-presenca")]
        //public IActionResult AdicionarPresenca(Presenca presenca)
        //{
        //    try
        //    {
        //        _service.Adicionar(presenca);
        //        return Ok();
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest($"Ocorreu um erro ao registrar a presença, o erro ocorrido foi: \n {e.Message}");
        //    }

        //}

        ///// <summary>
        ///// Lista os jogadores que estiveram presentes
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet("listar-presencas")]
        //public List<Presenca> ListarPresencas()
        //{
        //    try
        //    {
        //        return _service.Listar();
        //    }
        //    catch (Exception)
        //    {

        //        throw new Exception("Erro ao Listar os jogadores presentes");
        //    }
        //}


        ///// <summary>
        ///// Editar as informações sobre a presença
        ///// </summary>
        ///// <param name="t"></param>
        //[HttpPut("editar-presenca")]
        //public IActionResult EditarPresenca(Presenca t)
        //{
        //    try
        //    {
        //        _service.Editar(t);
        //        return NoContent();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest($"Ocorreu um erro ao editar as informações da presença, o erro foi: \n {e.Message}");
        //    }
        //}

        ///// <summary>
        ///// Buscar presenca por id
        ///// </summary>
        ///// <param name="id"></param>
        //[HttpDelete("deletar-presenca")]
        //public IActionResult BuscarPorId(int id)
        //{
        //    try
        //    {
        //        _service.Remover(id);
        //        return NoContent();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest($"Ocorreu um erro ao buscar a presença, o erro foi: \n {e.Message}");
        //    }
        //}

        ///// <summary>
        ///// Deletar presença
        ///// </summary>
        ///// <param name="id"></param>
        //[HttpDelete("deletar-presenca")]
        //public IActionResult DeletarPresenca(int id)
        //{
        //    try
        //    {
        //        _service.Remover(id);
        //        return NoContent();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest($"Ocorreu um erro ao excluir a presença, o erro foi: \n {e.Message}");
        //    }
        //}


    }
}
