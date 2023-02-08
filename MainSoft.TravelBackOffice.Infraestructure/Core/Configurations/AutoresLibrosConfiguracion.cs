using MainSoft.TravelBackOffice.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MainSoft.TravelBackOffice.Infraestructure.Core.Configurations
{
    public class AutoresLibrosConfiguracion : BaseConfiguration<AutoresLibros>
    {
        public override void Configure(EntityTypeBuilder<AutoresLibros> builder)
        {
            builder.ToTable("AutoresLibros", schema);
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.IsbnLibro).HasColumnName("IsbnLibro");
            builder.Property(p => p.AutorId).HasColumnName("AutorId");

            builder.HasOne(p => p.Libros).WithMany(s=> s.AutoresLibros).HasForeignKey("IsbnLibro");
            builder.HasOne(p => p.Autores).WithMany(t=> t.AutoresLibros).HasForeignKey("AutorId");
        }
    }
}