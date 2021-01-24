using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkSample.Models.ORM.Context
{
    public class CarParkContext : DbContext
    {
        public CarParkContext(DbContextOptions<CarParkContext> options) : base(options)
        {

        }

        public DbSet<Park> Parks { get; set; }

        public DbSet<_Ilce> ilces { get; set; }

        public DbSet<_Bölge> Bölges { get; set; }
        public DbSet<_AltBolge> AltBolges { get; set; }

        public DbSet<ParkTipi>  ParkTipis { get; set; }

        public DbSet<Lokasyon> Lokasyons { get; set; }

        public DbSet<Record> Records { get; set; }

        

    }
}
