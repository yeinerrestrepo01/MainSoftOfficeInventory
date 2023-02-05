using MainSoft.TravelBackOffice.Infraestructure.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Leal.Core.CargaPuntos.Application.WepApi
{
    public class StartUp
    {
        protected StartUp()
        {

        }
        public static void RegisterDI<T>(IServiceCollection services, IConfiguration configuration) where T : DbContext
        {
            #region REPOSITORY

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<DbContext, T>();
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            #endregion REPOSITORY

            //services.AddTransient<IAutenticacionBaseServicio, AutenticacionBaseServicio>();

        }
    }
}
