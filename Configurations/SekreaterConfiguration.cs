using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjectDoctor.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class SekreaterConfiguration : IEntityTypeConfiguration<Sekraeter>
    {
        public void Configure(EntityTypeBuilder<Sekraeter> builder)
        {
            builder.ToTable("Sekreater");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).IsRequired();
            builder.Property(s => s.NameRecord).IsRequired();
            builder.Property(s => s.PhoneNumber).IsRequired();
            builder.Property(s => s.Address).IsRequired();
            builder.Property(s => s.BirthDate).IsRequired();
        }
    }
}
