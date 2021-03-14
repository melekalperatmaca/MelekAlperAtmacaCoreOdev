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
    public class OgrenciConfiguration : IEntityTypeConfiguration<Ogrenci>
    {
        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            builder.HasKey(x => x.OgrenciID);
            builder.Property(x => x.OgrenciID).UseIdentityColumn();
            builder.Property(x => x.Adi).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Soyadi).IsRequired().HasMaxLength(20);
            builder.Property(x => x.OgrenciNo).IsRequired().HasMaxLength(10);
            builder.ToTable("TblOgrenci");
        }
    }
}