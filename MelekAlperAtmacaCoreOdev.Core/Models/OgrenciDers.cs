using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MelekAlperAtmacaCoreOdev.Core.Models
{
   public class OgrenciDers
    {
        public int OgrenciDersID { get; set; }
        public string DersAdi { get; set; }
        public string DersKodu { get; set; }
        public int OgrenciID { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }//Öğrenciye bağlı.
    }
}
