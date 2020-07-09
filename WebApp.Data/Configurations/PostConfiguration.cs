using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Data.Entities;

namespace WebApp.Data.Configurations
{
    class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Post_ID);
            builder.Property(x => x.theme).IsRequired();
            builder.Property(x => x.Urlfile).IsRequired();
            builder.Property(x => x.Employee_ID).IsRequired();
            builder.Property(x => x.content).IsRequired();
            throw new NotImplementedException();
        }
    }
}
