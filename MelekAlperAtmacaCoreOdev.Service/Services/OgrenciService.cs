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
    public class OgrenciService : Service<Ogrenci>, IOgrenciService
    {
        public OgrenciService(IUnitOfWork unitOfWork, IRepository<Ogrenci> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Ogrenci> GetOgrenciWithOgrenciDersByIDAsync(int ogrenciID)
        {
            return await _unitOfWork.Ogrenciler.GetOgrenciWithOgrenciDersByIDAsync(ogrenciID);
        }
    }
}
