using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Data.Entities;

namespace WebApp.Data.Configurations
{
    class RegistrationDetailConfiguration : IEntityTypeConfiguration<RegistrationDetail>
    {
        public void Configure(EntityTypeBuilder<RegistrationDetail> builder)
        {
            builder.ToTable("RegistrationDetail");
            builder.HasKey(x => x.OT_ID);
            builder.Property(x => x.Registration_Date).IsRequired();
            builder.Property(x => x.Time_Start).IsRequired();
            builder.Property(x => x.Time_Finish).IsRequired();
            builder.Property(x => x.Reason).IsRequired();
            throw new NotImplementedException();
        }
    }
}
