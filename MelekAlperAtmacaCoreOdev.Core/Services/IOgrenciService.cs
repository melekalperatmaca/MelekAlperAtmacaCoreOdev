using MelekAlperAtmacaCoreOdev.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Core.Services
{
    public interface IOgrenciService : IService<Ogrenci>
    {
        Task<Ogrenci> GetOgrenciWithOgrenciDersByIDAsync(int ogrenciID);
    }
}
