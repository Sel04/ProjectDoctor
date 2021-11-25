using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjectDoctor.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class BehandlungConfiguration : IEntityTypeConfiguration<Behandlung>
    {
        public void Configure(EntityTypeBuilder<Behandlung> builder)
        {
            builder.ToTable("Behandlung");
            builder.HasKey(s => s.ArztId);
            builder.HasKey(s => s.PatientId);

     
            builder.Property(s => s.Beginn).IsRequired();
            builder.Property(s => s.Ende).IsRequired();
        }
    }
}
