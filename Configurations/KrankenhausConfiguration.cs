using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjectDoctor.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class KrankenhausConfiguration : IEntityTypeConfiguration<Krankenhaus>
    {
        public void Configure(EntityTypeBuilder<Krankenhaus> builder)
        {
            builder.ToTable("Krankenhaus");
            builder.HasKey(s => s.Kuerzel);

            builder.Property(s => s.Kuerzel).IsRequired();
            builder.Property(s => s.Id).IsRequired();
            builder.Property(s => s.nameRecord).IsRequired();
            builder.Property(s => s.Adresse).IsRequired();
        }
    }
}
