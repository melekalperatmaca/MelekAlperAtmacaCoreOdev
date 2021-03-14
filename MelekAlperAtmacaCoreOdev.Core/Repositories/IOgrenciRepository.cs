using MelekAlperAtmacaCoreOdev.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Core.Repositories
{
    public interface IOgrenciRepository : IRepository<Ogrenci>
    {
        Task<Ogrenci> GetOgrenciWithOgrenciDersByIDAsync(int ogrenciID);
    }
}
