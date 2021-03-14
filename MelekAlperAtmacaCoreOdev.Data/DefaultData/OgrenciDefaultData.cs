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
    public class OgrenciDefaultData : IEntityTypeConfiguration<Ogrenci>
    {
        private readonly int[] _OgrenciIDs;
        public OgrenciDefaultData(int[] OgrenciIDs)
        {
            _OgrenciIDs = OgrenciIDs;
        }
        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            builder.HasData(
                new Ogrenci
                {
                    OgrenciID = _OgrenciIDs[0],
                    Adi = "Melek",
                    Soyadi = "Alper Atmaca",
                    OgrenciNo = "1010101010"
                },
                   new Ogrenci
                   {
                       OgrenciID = _OgrenciIDs[1],
                       Adi = "Kenan Durmuş",
                       Soyadi = "Atmaca",
                       OgrenciNo = "2010101010"
                   },
                      new Ogrenci
                      {
                          OgrenciID = _OgrenciIDs[2],
                          Adi = "Fıstık",
                          Soyadi = "Alper Atmaca",
                          OgrenciNo = "3010101010"
                      }
                );
        }
    }
}