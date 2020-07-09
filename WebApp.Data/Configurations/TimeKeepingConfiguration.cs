using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Data.Entities;

namespace WebApp.Data.Configurations
{
    class TimeKeepingConfiguration : IEntityTypeConfiguration<TimeKeeping>
    {
        public void Configure(EntityTypeBuilder<TimeKeeping> builder)
        {
            builder.ToTable("TimeKeeping");
            builder.HasKey(x => x.Time_ID);
            builder.Property(x => x.Timekeeping_Date).IsRequired();
            builder.Property(x => x.Employee_ID).IsRequired();
            throw new NotImplementedException();
        }
    }
}
