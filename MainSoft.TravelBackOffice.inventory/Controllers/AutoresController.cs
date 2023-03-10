using MainSoft.TravelBackOffice.Application.Core;
using MainSoft.TravelBackOffice.Entities.Request;
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
        public IActionResult Get(int id)
        {
            var autor = _autoresManager.Get(t=> t.Id == id).ToList();
            return Ok(autor);
        }

        // POST api/<AutoresController>
        [HttpPost]
        public IActionResult Post([FromBody] AutoresRequest value)
        {
            var resultadoTransaccion = _autoresManager.InsertarAutor(value);
            return Ok(resultadoTransaccion);
        }
    }
}
