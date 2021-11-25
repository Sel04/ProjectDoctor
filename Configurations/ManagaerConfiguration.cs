using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjectDoctor.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class ManagaerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Manager");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).IsRequired();
            builder.Property(s => s.NameRecord).IsRequired();
            builder.Property(s => s.BirthDate).IsRequired();
            builder.Property(s => s.Address).IsRequired();
        }
    }
}
