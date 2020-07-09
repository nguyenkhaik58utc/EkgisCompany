using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Data.Entities;

namespace WebApp.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(x => x.Account_ID);
            builder.Property(x => x.User_emp).IsRequired(true);
            builder.Property(x => x.Password_emp).IsRequired();
            builder.Property(x => x.Role_ID).IsRequired();
        }
    }
}
