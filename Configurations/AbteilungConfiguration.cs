using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjectDoctor.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class AbteilungConfiguration : IEntityTypeConfiguration<Abteilung>
    {
        public void Configure(EntityTypeBuilder<Abteilung> builder)
        {
            builder.ToTable("Abteilung");
            builder.HasKey(s => s.Kuerzel);

            builder.Property(s => s.Kuerzel).IsRequired();
            builder.Property(s => s.NameRecord).IsRequired();
        }
    }
}
