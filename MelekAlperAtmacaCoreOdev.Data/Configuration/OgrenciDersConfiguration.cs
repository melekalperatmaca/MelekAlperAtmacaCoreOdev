using MelekAlperAtmacaCoreOdev.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Data.Configuration
{
    public class OgrenciDersConfiguration : IEntityTypeConfiguration<OgrenciDers>
    {
        public void Configure(EntityTypeBuilder<OgrenciDers> builder)
        {
            builder.HasKey(x => x.OgrenciDersID);
            builder.Property(x => x.OgrenciDersID).UseIdentityColumn();
            builder.Property(x => x.DersKodu).IsRequired().HasMaxLength(15);
            builder.Property(x => x.DersAdi).IsRequired().HasMaxLength(100);
            builder.Property(x => x.OgrenciID).IsRequired();
            builder.ToTable("TblOgrenciDers");
        }
    }
}
