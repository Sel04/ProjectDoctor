using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjectDoctor.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class ArztConfiguration : IEntityTypeConfiguration<Arzt>
    {
        public void Configure(EntityTypeBuilder<Arzt> builder)
        {
            builder.ToTable("Arzt");
            builder.HasKey(s => s.Kuerzel);

            builder.Property(s => s.Kuerzel).IsRequired();
            builder.Property(s => s.Titel).IsRequired();
            builder.Property(s => s.Telefonnummer).IsRequired();
            builder.Property(s => s.Gehalt).IsRequired();
            builder.Property(s => s.Fach).IsRequired();
        }
    }
}
