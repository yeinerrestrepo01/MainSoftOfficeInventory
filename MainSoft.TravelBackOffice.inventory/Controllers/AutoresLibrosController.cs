using MainSoft.TravelBackOffice.Application.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainSoft.TravelBackOffice.InventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresLibrosController : ControllerBase
    {
        private readonly IAutoresLibrosManager _autoresLibros;
        public AutoresLibrosController(IAutoresLibrosManager autoresLibrosManager)
        {
            _autoresLibros = autoresLibrosManager;
        }
        // GET: api/<AutoresLibrosController>
        [HttpGet]
        public IActionResult Get()
        {
            var listadoAutoresLibros = _autoresLibros.ObtenerListadoLibros();
            return Ok(listadoAutoresLibros);
        }

        // GET api/<AutoresLibrosController>/5
        [HttpGet("{isbnId}")]
        public IActionResult Get(int isbnId)
        {
            var AutoreLibros = _autoresLibros.ObtenerLibroIsbnId(isbnId);
            return Ok(AutoreLibros);
        }
    }
}
