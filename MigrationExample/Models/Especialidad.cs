using System.Collections.Generic;

namespace MigrationExample.Models
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string nombre_Especialidad { get; set; }
        public ICollection<Doctor> Doctor { get; set; }

    }
}