using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Data.Entities;

namespace WebApp.Data.Configurations
{
    class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(x => x.menu_id);
            builder.Property(x => x.menu_name).IsRequired();
            builder.Property(x => x.menu_screen).IsRequired();
            builder.Property(x => x.menu_url).IsRequired();

        }
    }
}
