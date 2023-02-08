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
            var listLibros = _librosManager.GetAll();
            return Ok(listLibros);
        }

        // GET api/<LibrosController>/5
        [HttpGet("{isbnId}")]
        public IActionResult Get(int isbnId)
        {
            var informacionLibro = _librosManager.GetById(isbnId);
            return Ok(informacionLibro);
        }

        // POST api/<LibrosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
