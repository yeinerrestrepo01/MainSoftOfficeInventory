using MainSoft.TravelBackOffice.Application.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainSoft.TravelBackOffice.InventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        /// <summary>
        /// Propiedad de navegacion de interface de definiciones de AutoresManager
        /// </summary>
        private readonly IAutoresManager _autoresManager;

        /// <summary>
        /// Inicializador de controlador <controller>AutoresController</controller>
        /// </summary>
        /// <param name="autoresManager"></param>
        public AutoresController(IAutoresManager autoresManager)
        {
            _autoresManager = autoresManager;
        }
        // GET: api/<AutoresController>
        [HttpGet]
        public IActionResult Get()
        {
            var listadoAutores = _autoresManager.GetAll().ToList();
            return Ok(listadoAutores);
        }

        // GET api/<AutoresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AutoresController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
