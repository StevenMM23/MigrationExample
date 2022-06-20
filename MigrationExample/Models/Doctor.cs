using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OverPosting Attacks Binding ! 
namespace MigrationExample.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        [Display(Name = "Especialidad ID")]
        public int EspecialidadId { get; set; }
        public int HospitalId { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public Especialidad Especialidad { get; set; }
        public Hospital Hospital { get; set; }
    }
}
