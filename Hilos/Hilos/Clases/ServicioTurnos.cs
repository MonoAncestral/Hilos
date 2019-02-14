using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilos.Clases
{
    class ServicioTurnos
    {
        public string id { get; set; }
        public int idAsesor { get; set; }
        public int[] contador;

        public ServicioTurnos(string id, int idAsesor)
        {
            this.id = id;
            this.idAsesor = idAsesor;
        }
    }
}
