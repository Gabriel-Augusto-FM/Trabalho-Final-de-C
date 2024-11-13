using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorService _service;
        private readonly IMapper _mapper;

        public JogadorController(IMapper mapper, IJogadorService service)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
