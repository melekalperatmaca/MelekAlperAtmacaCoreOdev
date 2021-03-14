using MelekAlperAtmacaCoreOdev.Core.Models;
using MelekAlperAtmacaCoreOdev.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Data.Repositories
{
    public class OgrenciRepository : Repository<Ogrenci>, IOgrenciRepository
    {
        private ApplicationDbContext applicationDbContext { get => _dbContext as ApplicationDbContext; }
        public OgrenciRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Ogrenci> GetOgrenciWithOgrenciDersByIDAsync(int ogrenciID)
        {
            return await applicationDbContext.Ogrenciler.Include(x => x.OgrenciDers).SingleOrDefaultAsync(x => x.OgrenciID == ogrenciID);
        }
    }
}