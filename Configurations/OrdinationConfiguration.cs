using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjectDoctor.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class OrdinationConfiguration : IEntityTypeConfiguration<Ordination>
    {
        public void Configure(EntityTypeBuilder<Ordination> builder)
        {
            builder.ToTable("Ordination");
            builder.HasKey(s => s.Kuerzel);

            builder.Property(s => s.Kuerzel).IsRequired();
            builder.Property(s => s.nameRecord).IsRequired();
            builder.Property(s => s.Telefonnummer).IsRequired();

        }
    }
}
