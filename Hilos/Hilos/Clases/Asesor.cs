using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilos.Clases
{
    class Asesor
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

       public Asesor(int cedula, string nombre, string apellido)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
