using FluentApis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Data.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {
            builder
                .HasKey(d => d.DeptId);
            builder.Property(d => d.DeptId).UseIdentityColumn(10, 10);
            builder.Property(d => d.Name).HasColumnName("DeptName").HasColumnType("varchar").IsRequired();
            builder.Property(d => d.CreationDate).HasDefaultValueSql("GETDATE()");
        }
    }
}
