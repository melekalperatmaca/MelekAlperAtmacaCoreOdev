using AutoMapper;
using MelekAlperAtmacaCoreOdev.Core.Models;
using MelekAlperAtmacaCoreOdev.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Ogrenci, OgrenciDto>();
            CreateMap<OgrenciDto, Ogrenci>();
            CreateMap<Ogrenci, OgrenciAndOgrenciDersDto>();
            CreateMap<OgrenciAndOgrenciDersDto, Ogrenci>();
            CreateMap<OgrenciDers, OgrenciDersDto>();
            CreateMap<OgrenciDersDto, OgrenciDers>();
        }
    }
}