using MelekAlperAtmacaCoreOdev.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.DTO
{
    public class OgrenciDersDto
    {
        public int OgrenciDersID { get; set; }
        public string DersAdi { get; set; }
        public string DersKodu { get; set; }
        public int OgrenciID { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }//Öğrenciye bağlı.
    }
}
