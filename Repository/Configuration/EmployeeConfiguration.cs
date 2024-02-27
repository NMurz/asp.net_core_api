using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
             (
             new Employee
             {
                 Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                 Name = "Sam Raiden",
                 Age = 26,
                 Position = "Software developer",
                 CompanyId = new Guid("C2641EC0-593C-4B3D-8F99-78277AD98AB0")
             },
             new Employee
             {
                 Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                 Name = "Jana McLeaf",
                 Age = 30,
                 Position = "Software developer",
                 CompanyId = new Guid("C2641EC0-593C-4B3D-8F99-78277AD98AB0")
             },
             new Employee
             {
                 Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                 Name = "Kane Miller",
                 Age = 35,
                 Position = "Administrator",
                 CompanyId = new Guid("FD1938ED-F0D4-49D3-9534-D2EE0FBA55AD")
             }
             );
        }
    }
}
