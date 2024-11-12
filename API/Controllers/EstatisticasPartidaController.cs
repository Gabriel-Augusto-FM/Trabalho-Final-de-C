using AutoMapper;
using GerenciamentoVolei._01_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstatisticasPartidaController : ControllerBase
    {
        private readonly IEstatisticasPartidaService _service;
        private readonly IMapper _mapper;

        public EstatisticasPartidaController(IConfiguration config, IMapper mapper, IEstatisticasPartidaService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }
    }
}
