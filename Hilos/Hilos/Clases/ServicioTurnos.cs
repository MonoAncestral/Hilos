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
        public int[] contador = { 0, 0, 0 };
        public Turnos.tipoTurno tipoTurno;

        public ServicioTurnos()
        {
      
        }
    }
}
