using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MigrationExample.Models;

namespace MigrationExample.Data
{
    internal class HospitalDbContext : DbContext
    {
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=STEVENPC\SQLDEVELOPER;Initial Catalog=HospitalDb; Integrated Security=True");
        }
    }
}
