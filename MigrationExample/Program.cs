using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MigrationExample.Data;
using MigrationExample.Models;

namespace MigrationExample
{
    internal class Program
    {
        private HospitalDbContext hospitalDbContext = new();
        static void Main(string[] args)
        {
            var BaseDeDatos = new HospitalDbContext();
            var HospitalObject = new Hospital();
            DateTime time = DateTime.Now;
            var hospital = new Doctor()
            {
                Nombre = "Nikita",
                Apellido = "Kravchenko",
                Cedula = "001937284",
                Direccion = "Plaza la Bandera",
                Telefono = "8097786675",
                EspecialidadId = 1,
                HospitalId = 1,
                FechaDeNacimiento = time
            };

            //var Hospital = new Hospital()
            //{
            //    Nombre = "Nikita Hospital",
            //    Ciudad = "Santo Domingo",
            //    Direccion = "Calle las Frutas",
            //    Telefono = "80977896"
            //};

            IEnumerable<Doctor> doctores = new List<Doctor>();
            ICollection<Doctor> doctors = new List<Doctor>();
            List<Doctor> doctort = new List<Doctor>();
            var selectAll = BaseDeDatos.Doctores.Where(p => p.Nombre.Contains(""));
            foreach (var VARIABLE in selectAll)
            {
                
            }
            BaseDeDatos.Add(hospital);
            BaseDeDatos.SaveChanges();
        }
    }
}
