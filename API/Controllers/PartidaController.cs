using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartidaController : ControllerBase
    {
        private readonly IPartidaService _service;
        private readonly IMapper _mapper;

        public PartidaController(IMapper mapper, IPartidaService service)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
