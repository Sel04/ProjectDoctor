using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.ProjectDoctor.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spg.ProjectDoctor.Configurations
{
    public class DiagnoseConfiguration : IEntityTypeConfiguration<Diagnose>
    {
        public void Configure(EntityTypeBuilder<Diagnose> builder)
        {
            builder.ToTable("Diagnose");
            builder.HasKey(s => s.ArztId);
            builder.HasKey(s => s.PatientId);

            builder.Property(s => s.Date).IsRequired();
            builder.Property(s => s.DiagnoseName).IsRequired();
        }
    }
}
