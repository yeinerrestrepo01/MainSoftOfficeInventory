using MainSoft.TravelBackOffice.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

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

        public DbSet<Libros> Libros { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        public DbSet<Autores> Autores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
