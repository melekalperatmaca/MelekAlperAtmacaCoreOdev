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
    public class OgrenciDersRepository : Repository<OgrenciDers>, IOgrenciDersRepository
    {
        private ApplicationDbContext applicationDbContext { get => _dbContext as ApplicationDbContext; }
        public OgrenciDersRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<OgrenciDers> GetOgrenciDersWithOgrenciIDByIDAsync(int OgrenciDersID)
        {
            return await applicationDbContext.OgrenciDersler.Include(x => x.Ogrenci).SingleOrDefaultAsync(x => x.OgrenciDersID == OgrenciDersID);
        }
    }
}