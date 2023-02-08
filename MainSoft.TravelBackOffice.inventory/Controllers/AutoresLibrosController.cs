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
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AutoresLibrosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AutoresLibrosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AutoresLibrosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
