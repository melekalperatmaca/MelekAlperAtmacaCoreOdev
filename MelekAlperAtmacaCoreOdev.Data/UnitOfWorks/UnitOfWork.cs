using MelekAlperAtmacaCoreOdev.Core.Repositories;
using MelekAlperAtmacaCoreOdev.Core.UnitOfWorks;
using MelekAlperAtmacaCoreOdev.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private OgrenciRepository _ogrenciRepository;
        private OgrenciDersRepository _ogrenciDersRepository;
        public IOgrenciRepository Ogrenciler => _ogrenciRepository = _ogrenciRepository ?? new OgrenciRepository(_applicationDbContext);
        public IOgrenciDersRepository OgrenciDersler => _ogrenciDersRepository = _ogrenciDersRepository ?? new OgrenciDersRepository(_applicationDbContext);
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void Commit()
        {
            _applicationDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}