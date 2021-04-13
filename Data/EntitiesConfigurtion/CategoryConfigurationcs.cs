
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntitiesConfigurtion
{
    public class CategoryConfigurationcs : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category","Product");
            #region Properties

            builder.HasKey(x => x.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);

            #endregion

            #region Relations
             
            #endregion
        }
    }
    }

