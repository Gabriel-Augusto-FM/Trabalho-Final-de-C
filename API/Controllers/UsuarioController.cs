using AutoMapper;
using Core._03_Entidades.DTO.Usuario;
using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;
        private readonly IMapper _mapper;
        public UsuarioController(IConfiguration config, IUsuarioService usuarioService, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = usuarioService;
            _mapper = mapper;
        }
        [HttpPost("adicionar-usuario")]
        public void AdicionarAluno(Usuario usuarioDTO)
        {
            _service.Adicionar(usuarioDTO);
        }
        [HttpPost("fazer-login")]
        public Usuario FazerLogin(UsuarioLoginDTO usuarioLogin)
        {
            Usuario usuario = _service.FazerLogin(usuarioLogin);
            return usuario;
        }
        [HttpGet("listar-usuario")]
        public List<Usuario> ListarAluno()
        {
            return _service.Listar();
        }
        [HttpPut("editar-usuario")]
        public void EditarUsuario(Usuario p)
        {
            _service.Editar(p);
        }
        [HttpDelete("deletar-usuario")]
        public void DeletarUsuario(int id)
        {
            _service.Remover(id);
        }
    }
}
