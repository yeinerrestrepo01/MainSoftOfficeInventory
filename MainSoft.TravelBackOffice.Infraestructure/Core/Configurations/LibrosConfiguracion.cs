using MainSoft.TravelBackOffice.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MainSoft.TravelBackOffice.Infraestructure.Core.Configurations
{
    public class LibrosConfiguracion : BaseConfiguration<Libros>
    {
        public override void Configure(EntityTypeBuilder<Libros> builder)
        {
            builder.ToTable("Libros", schema);
            builder.HasKey(p => new { p.Isbn });

            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.EditorialId).HasColumnName("EditorialId");
            builder.Property(p => p.Titulo).HasColumnName("Titulo");
            builder.Property(p => p.Sinopsis).HasColumnName("Sinopsis");
            builder.Property(p => p.NPaginas).HasColumnName("NPaginas");

            builder.HasOne(p => p.Editoriales).WithMany(x => x.Libros).HasForeignKey("EditorialId");
        }
    }
}