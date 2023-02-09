using Leal.Core.CargaPuntos.Application.WepApi;
using MainSoft.TravelBackOffice.Infraestructure.Base;
using MainSoft.TravelBackOffice.Infraestructure.Core;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mainsonft.TravelBackOffice.UnitTest.Base
{
    public abstract class BaseTest
    {
        protected IServiceProvider? serviceProvider;
        protected ServiceCollection? serviceCollection;
        [SetUp]
        public void Setup()
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            var configurationBuilder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = configurationBuilder.Build();
           
            #region Generate Generic Repositories
             serviceCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            #endregion Generate Generic Repositories

            serviceCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            serviceCollection.AddSingleton<IConfiguration>(configuration);
            StartUp.RegisterDI<TravelInventoryContext>(serviceCollection, configuration);
            serviceProvider = serviceCollection.BuildServiceProvider();

        }
    }
}
