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

        public DbSet<CompareMotos.Models.AmountGear> AmountGear { get; set; }

        public DbSet<CompareMotos.Models.BackBrake> BackBrake { get; set; }

        public DbSet<CompareMotos.Models.Battery> Battery { get; set; }

        public DbSet<CompareMotos.Models.Brake> Brake { get; set; }

        public DbSet<CompareMotos.Models.Brand> Brand { get; set; }

        public DbSet<CompareMotos.Models.Cooling> Cooling { get; set; }

        public DbSet<CompareMotos.Models.Cylinder> Cylinder { get; set; }

        public DbSet<CompareMotos.Models.Dimensions> Dimensions { get; set; }

        public DbSet<CompareMotos.Models.Displacement> Displacement { get; set; }

        public DbSet<CompareMotos.Models.Electric> Electric { get; set; }

        public DbSet<CompareMotos.Models.Engine> Engine { get; set; }

        public DbSet<CompareMotos.Models.FrontBrake> FrontBrake { get; set; }

        public DbSet<CompareMotos.Models.Fuel> Fuel { get; set; }

        public DbSet<CompareMotos.Models.Ignition> Ignition { get; set; }

        public DbSet<CompareMotos.Models.TimeCycle> TimeCycle { get; set; }

        public DbSet<CompareMotos.Models.Transmission> Transmission { get; set; }

        public DbSet<CompareMotos.Models.TypeMotorcycle> TypeMotorcycle { get; set; }

        public DbSet<CompareMotos.Models.TypeTransmission> TypeTransmission { get; set; }

        public DbSet<CompareMotos.Models.ModelMotorcycle> ModelMotorcycle { get; set; }

        public DbSet<CompareMotos.Models.Start> Start { get; set; }

        public DbSet<CompareMotos.Models.TypeFuel> TypeFuel { get; set; }

        public DbSet<CompareMotos.Models.Feeding> Feeding { get; set; }
    }
}
