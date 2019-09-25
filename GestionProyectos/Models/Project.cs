using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Models
{
    public class Project
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string LenguajeProg { get; set; }
        public int Presupuesto { get; set; }
        public List<Developer> Developers { get; set; }

        public Project()
        {
            this.Developers = new List<Developer>();
        }
    }
}
