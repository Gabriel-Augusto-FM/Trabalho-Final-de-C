using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PresencaController : ControllerBase
    {
        private readonly IPresencaService _service;
        private readonly IMapper _mapper;

        public PresencaController(IConfiguration config, IMapper mapper, IPresencaService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }
    }
}
