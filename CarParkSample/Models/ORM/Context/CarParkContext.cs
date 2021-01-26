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

       

        public DbSet<Record> Records { get; set; }

        public DbSet<RecordSelected> RecordSelects { get; set; }



    }
}
