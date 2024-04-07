using SiteCRM.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Infrastructure.Persistence.Configurations
{
    public class SobreConfigurations : IEntityTypeConfiguration<Sobre>
    {
        public void Configure(EntityTypeBuilder<Sobre> builder)
        {
            builder.HasKey(s => s.Id);
            builder
                .HasOne(s => s.Igreja)
                .WithMany()
                .HasForeignKey(s => s.IdIgreja);
        }
    }
}
