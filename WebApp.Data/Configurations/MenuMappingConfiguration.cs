using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Data.Entities;

namespace WebApp.Data.Configurations
{
    class MenuMappingConfiguration : IEntityTypeConfiguration<MenuMapping>
    {
        public void Configure(EntityTypeBuilder<MenuMapping> builder)
        {
            builder.HasKey(x => x.menu_id);
            builder.Property(x => x.menu_mapping_id).IsRequired();
            builder.Property(x => x.menu_id).IsRequired();
            throw new NotImplementedException();
        }
    }
}
