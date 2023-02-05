using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace MainSoft.TravelBackOffice.Infraestructure.Core
{
    public class TravelInventoryContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public TravelInventoryContext(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <param name="configuration"></param>
        public TravelInventoryContext(DbContextOptions options, IConfiguration configuration)
          : base(options)
        {
            Configuration = configuration;
        }

        //public DbSet<PuntosComercio> PuntosComercio { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
