using MelekAlperAtmacaCoreOdev.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Data.DefaultData
{
    public class OgrenciDersDefaultData : IEntityTypeConfiguration<OgrenciDers>
    {
        private readonly int[] _OgrenciIDs;
        public OgrenciDersDefaultData(int[] OgrenciIDs)
        {
            _OgrenciIDs = OgrenciIDs;
        }
        public void Configure(EntityTypeBuilder<OgrenciDers> builder)
        {
            builder.HasData(
                new OgrenciDers
                {
                    OgrenciDersID = 1,
                    DersAdi = "Yazılım",
                    DersKodu = "YZLM-101",
                    OgrenciID = _OgrenciIDs[0]
                },
                   new OgrenciDers
                   {
                       OgrenciDersID = 2,
                       DersAdi = "Donanım",
                       DersKodu = "DNM-101",
                       OgrenciID = _OgrenciIDs[1]
                   },
                     new OgrenciDers
                     {
                         OgrenciDersID = 3,
                         DersAdi = "Görsel Prog.",
                         DersKodu = "GRSP-101",
                         OgrenciID = _OgrenciIDs[0]
                     },
                   new OgrenciDers
                   {
                       OgrenciDersID = 4,
                       DersAdi = "Mikroişlemciler",
                       DersKodu = "MKR-101",
                       OgrenciID = _OgrenciIDs[1]
                   },
                   new OgrenciDers
                   {
                       OgrenciDersID = 5,
                       DersAdi = "Havlama",
                       DersKodu = "HAV-101",
                       OgrenciID = _OgrenciIDs[2]
                   }
                );
        }
    }
}