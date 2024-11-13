using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipeController : ControllerBase
    {
        private readonly IEquipeService _service;
        private readonly IMapper _mapper;

        public EquipeController(IMapper mapper, IEquipeService service)
        {
            _service = service;
            _mapper = mapper;
        }



    }
}
