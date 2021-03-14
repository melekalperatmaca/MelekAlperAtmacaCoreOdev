using MelekAlperAtmacaCoreOdev.Core.Models;
using MelekAlperAtmacaCoreOdev.Data.Configuration;
using MelekAlperAtmacaCoreOdev.Data.DefaultData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelekAlperAtmacaCoreOdev.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OgrenciConfiguration());
            modelBuilder.ApplyConfiguration(new OgrenciDersConfiguration());
            modelBuilder.ApplyConfiguration(new OgrenciDefaultData(new int[] { 1, 2, 3 }));
            modelBuilder.ApplyConfiguration(new OgrenciDersDefaultData(new int[] { 1, 2, 3 }));
        }
    }
}