using MainSoft.TravelBackOffice.Application.Core;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Entities.Request;
using MainSoft.TravelBackOffice.InventoryApi.Controllers;
using Mainsonft.TravelBackOffice.UnitTest.Base;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.Net;

namespace Mainsonft.TravelBackOffice.UnitTest
{
    public class AutoresControllerUnitTest : BaseTest
    {

        LibrosController controller;
        private Mock<ILibrosManager> _fakeILibrosManager;

        [SetUp]
        public void Setup()
        {

            _fakeILibrosManager = new Mock<ILibrosManager>();
            _fakeILibrosManager.Setup(moq => moq.InsertarLibro(It.IsAny<LibrosRequest>())).Returns(new RespuestaGenerica<bool>());
            controller = ActivatorUtilities.CreateInstance<LibrosController>(serviceProvider,_fakeILibrosManager.Object);
        }

        [Test]
        public void Get_Test_Ok()
        {
            var ressultadoOperacion  = controller.Get();
            var resultado = (Microsoft.AspNetCore.Mvc.OkObjectResult)ressultadoOperacion;
            Assert.IsTrue(resultado.StatusCode == 200);
        } 
        
        [Test]
        public void GetById_Test_Ok()
        {
            var ressultadoOperacion = controller.Get(1);
            var resultado = (Microsoft.AspNetCore.Mvc.OkObjectResult)ressultadoOperacion;
            Assert.IsTrue(resultado.StatusCode == 200);
        }
        
        [Test]
        public void InsertarLibro_Test()
        {
            var entidadLibro = new LibrosRequest {EditorialId = 1, Isbn =1, NPaginas=10, Sinopsis ="Libro Prueba", Titulo="Libro" };
            var resultadoOperacion  =controller.Post(entidadLibro);
            var resultado = (Microsoft.AspNetCore.Mvc.OkObjectResult)resultadoOperacion;
            Assert.IsTrue(resultado.StatusCode == 200);
        }
    }
}