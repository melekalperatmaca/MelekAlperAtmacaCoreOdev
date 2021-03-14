using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.DTO
{
    public class OgrenciAndOgrenciDersDto:OgrenciDto
    {
        public ICollection<OgrenciDersDto> ogrenciDersler { get; set; }
    }
}
