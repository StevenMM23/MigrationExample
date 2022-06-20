using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoReplicado
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Doctores = new HashSet<Doctore>();
        }

        public int Id { get; set; }
        public string NombreEspecialidad { get; set; }

        public virtual ICollection<Doctore> Doctores { get; set; }
    }
}
