using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MainSoft.TravelBackOffice.Infraestructure.Core.Configurations
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
        protected string schema;

        protected BaseConfiguration()
        {
            this.schema = "dbo";
        }

        protected BaseConfiguration(string schema)
        {
            this.schema = schema;
        }

        public abstract void Configure(EntityTypeBuilder<T> builder);
    }
}
