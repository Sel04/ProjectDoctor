using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjecctDoctor.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class GeschaeftsfuehrerConfiguration : IEntityTypeConfiguration<GeschaeftsFuerher>
    {
        public void Configure(EntityTypeBuilder<GeschaeftsFuerher> builder)
        {
            builder.ToTable("Geschaeftsfuehrer");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).IsRequired();
            builder.Property(s => s.NameRecord).IsRequired();
            builder.Property(s => s.Address).IsRequired();
            builder.Property(s => s.BirthDate).IsRequired();
        }
    }
}
