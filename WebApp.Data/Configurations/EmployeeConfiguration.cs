using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Data.Entities;

namespace WebApp.Data.Configurations
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            DateTime date = DateTime.Now;
            builder.HasKey(x => x.Employee_ID);
            builder.Property(x => x.Employee_Name).IsRequired();
            builder.Property(x => x.User_emp).IsRequired();
            builder.Property(x => x.Department).IsRequired();
            builder.Property(x => x.Date_Of_Birth).HasDefaultValue<DateTime>(date);

        }
    }
}
