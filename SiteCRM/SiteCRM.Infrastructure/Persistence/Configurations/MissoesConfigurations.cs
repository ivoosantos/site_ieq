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
    public class MissoesConfigurations : IEntityTypeConfiguration<Missoes>
    {
        public void Configure(EntityTypeBuilder<Missoes> builder)
        {
            builder.HasKey(m => m.Id);
            builder
                .HasOne(m => m.Igreja)
                .WithMany()
                .HasForeignKey(m => m.IdIgreja);
        }
    }
}
