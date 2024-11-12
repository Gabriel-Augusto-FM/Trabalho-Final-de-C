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

        [HttpPost("adicionar-treinamento")]
        public void AdicionarTreinamento(Treinamento treinamento)
        {
            _service.Adicionar(treinamento);
        }
        [HttpGet("listar-treinamento")]
        public List<Treinamento> ListarAluno()
        {
            return _service.Listar();
        }
        [HttpPut("editar-treinamento")]
        public void EditarTreinamento(Treinamento t)
        {
            _service.Editar(t);
        }
        [HttpDelete("deletar-treinamento")]
        public void DeletarTreinamento(int id)
        {
            _service.Remover(id);
        }
    }
}
