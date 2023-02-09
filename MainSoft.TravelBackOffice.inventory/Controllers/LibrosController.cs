using MainSoft.TravelBackOffice.Application.Core;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Request;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainSoft.TravelBackOffice.InventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        /// <summary>
        /// Propiedad de navegacion para interface ILibrosManager
        /// </summary>
        private readonly ILibrosManager _librosManager;

        /// <summary>
        /// Inicializador de <controller>LibrosController</controller>
        /// </summary>
        /// <param name="librosManager"></param>
        public LibrosController(ILibrosManager librosManager)
        {
            _librosManager = librosManager;
        }
        // GET: api/<LibrosController>
        [HttpGet]
        public IActionResult Get()
        {
            var listLibros = _librosManager.GetAll().ToList();
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
        public IActionResult Post([FromBody] LibrosRequest value)
        {
            var detalleTransaccion = _librosManager.InsertarLibro(value);
            return Ok(detalleTransaccion);
        }
    }
}
