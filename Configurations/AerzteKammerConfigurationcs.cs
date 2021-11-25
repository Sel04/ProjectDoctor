using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjectDoctor.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class AerzteKammerConfigurationcs : IEntityTypeConfiguration<AerzteKammer>
    {
        public void Configure(EntityTypeBuilder<AerzteKammer> builder)
        {
            builder.ToTable("AerzteKammer");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).IsRequired();
            builder.Property(s => s.Leiter).IsRequired();
        }
    }
}
