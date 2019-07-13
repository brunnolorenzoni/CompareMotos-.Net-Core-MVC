using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CompareMotos.Models;

namespace CompareMotos.Models
{
    public class CompareMotosContext : DbContext
    {
        public CompareMotosContext (DbContextOptions<CompareMotosContext> options)
            : base(options)
        {
        }

        public DbSet<CompareMotos.Models.Motorcycle> Motorcycle { get; set; }


        public DbSet<CompareMotos.Models.Brand> Brand { get; set; }

        public DbSet<CompareMotos.Models.Displacement> Displacement { get; set; }

  

        public DbSet<CompareMotos.Models.TypeMotorcycle> TypeMotorcycle { get; set; }

        public DbSet<CompareMotos.Models.ModelMotorcycle> ModelMotorcycle { get; set; }

    }
}
