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
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = new Guid("C2641EC0-593C-4B3D-8F99-78277AD98AB0"),
                    Name = "IT_Solutions Ltd",
                    Address = "21 Panfilova st.",
                    Country = "Kyrgyzstan"
                },
                new Company 
                {
                    Id = new Guid("FD1938ED-F0D4-49D3-9534-D2EE0FBA55AD"),
                    Name = "Admin_Solutions Inc",
                    Address = "21 Chui ave.",
                    Country = "Kyrgyzstan"
                }
                );
        }
    }
}
