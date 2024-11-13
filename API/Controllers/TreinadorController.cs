using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreinadorController : ControllerBase
    {
        private readonly ITreinadorService _service;
        private readonly IMapper _mapper;

        public TreinadorController(IMapper mapper, ITreinadorService service)
        {
            _service = service;
            _mapper = mapper;
        }



    }
}
