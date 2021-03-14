using MelekAlperAtmacaCoreOdev.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IOgrenciRepository Ogrenciler { get; }
        IOgrenciDersRepository OgrenciDersler { get; }
        Task CommitAsync();
        void Commit();
    }
}
