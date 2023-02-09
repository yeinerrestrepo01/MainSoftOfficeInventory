using MainSoft.TravelBackOffice.Application.Core;
using MainSoft.TravelBackOffice.Entities.Request;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainSoft.TravelBackOffice.InventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialesController : ControllerBase
    {
        private readonly IEditorialesManager _editorialesManager;

        /// <summary>
        /// Inicializador de <controller>EditorialesController</controller>
        /// </summary>
        /// <param name="editorialesManager"></param>
        public EditorialesController(IEditorialesManager editorialesManager)
        {
            _editorialesManager = editorialesManager;
        }

        // GET: api/<EditorialesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_editorialesManager.GetAll().ToList());
        }

        // GET api/<EditorialesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_editorialesManager.Get(t=> t.Id == id).FirstOrDefault());
        }

        // POST api/<EditorialesController>
        [HttpPost]
        public IActionResult Post([FromBody] RequestEditoriales value)
        {
            return Ok(_editorialesManager.InsertarEditorial(value));
        }
    }
}
