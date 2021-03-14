using MelekAlperAtmacaCoreOdev.Core.Models;
using MelekAlperAtmacaCoreOdev.Core.Repositories;
using MelekAlperAtmacaCoreOdev.Core.Services;
using MelekAlperAtmacaCoreOdev.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Service.Services
{
    public class OgrenciDersService : Service<OgrenciDers>, IOgrenciDersService
    {
        public OgrenciDersService(IUnitOfWork unitOfWork, IRepository<OgrenciDers> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<OgrenciDers> GetOgrenciDersWithOgrenciIDByIDAsync(int OgrenciDersID)
        {
            return await _unitOfWork.OgrenciDersler.GetOgrenciDersWithOgrenciIDByIDAsync(OgrenciDersID);
        }
    }
}