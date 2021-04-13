using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntitiesConfigurtion
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product", "Product");
            #region Properties
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);

            #endregion

            #region Relations

            #endregion
        }
    }
}
