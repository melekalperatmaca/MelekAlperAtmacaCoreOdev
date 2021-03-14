using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Core.Models
{
    public class Ogrenci
    {
        public Ogrenci()
        {
            OgrenciDers = new Collection<OgrenciDers>();
        }
        public int OgrenciID { get; set; }
        public string OgrenciNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public ICollection<OgrenciDers> OgrenciDers { get; set; }//Her öğrencinin birden fazla dersi olacak.
    }
}
