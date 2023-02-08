using MainSoft.TravelBackOffice.Application.Core;
using MainSoft.TravelBackOffice.Application.Core.Implementation;
using MainSoft.TravelBackOffice.Infraestructure.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Leal.Core.CargaPuntos.Application.WepApi
{
    public class StartUp
    {
        /// <summary>
        /// Inicializador de clase <class>StartUp</class>
        /// </summary>
        protected StartUp()
        {

        }

        /// <summary>
        /// Metodo para realizar el registro de servicios y denpendencia usados en la aplicacion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void RegisterDI<T>(IServiceCollection services, IConfiguration configuration) where T : DbContext
        {
            #region REPOSITORY

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<DbContext, T>();
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            #endregion REPOSITORY

            services.AddTransient<IAutoresManager, AutoresManager>();
            services.AddTransient<IEditorialesManager, EditorialesManager>();
            services.AddTransient<ILibrosManager, LibrosManager>();
            services.AddTransient<IAutoresLibrosManager, AutoresLibrosManager>();

        }
    }
}
