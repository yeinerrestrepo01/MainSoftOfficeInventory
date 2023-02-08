using MainSoft.TravelBackOffice.Application.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainSoft.TravelBackOffice.InventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly ILibrosManager _librosManager;
        public LibrosController(ILibrosManager librosManager)
        {
            _librosManager = librosManager;
        }
        // GET: api/<LibrosController>
        [HttpGet]
        public IActionResult Get()
        {
            var listLibros = _librosManager.ObtenerListadoLibros();
            return Ok(listLibros);
        }

        // GET api/<LibrosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LibrosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
