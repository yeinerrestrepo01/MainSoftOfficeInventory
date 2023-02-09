using MainSoft.TravelBackOffice.Application.Core;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Request;
using MainSoft.TravelBackOffice.InventoryApi.Controllers;
using Mainsonft.TravelBackOffice.UnitTest.Base;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace Mainsonft.TravelBackOffice.UnitTest
{
    public class ManagerUnitTest : BaseTest
    {

        AutoresController controller;
        private Mock<IAutoresManager> _fakeAutoresManager;

        [SetUp]
        public void Setup()
        {

            _fakeAutoresManager = new Mock<IAutoresManager>();
            _fakeAutoresManager.Setup(moq => moq.InsertarAutor(It.IsAny<AutoresRequest>())).Returns(new RespuestaGenerica<bool>());
            controller = ActivatorUtilities.CreateInstance<AutoresController>(serviceProvider, _fakeAutoresManager.Object);
        }

        [Test]
        public void Get_Test_Ok()
        {
            var ressultadoOperacion = controller.Get();
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
            var entidadAutoresRequest = new AutoresRequest { Nombres = "Jose", Apellidos = "Ponton" };
            var ressultadoOperacion = controller.Post(entidadAutoresRequest);
            var resultado = (Microsoft.AspNetCore.Mvc.OkObjectResult)ressultadoOperacion;
            Assert.IsTrue(resultado.StatusCode == 200);
        }
    }
}