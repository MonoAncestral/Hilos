using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos.Clases
{
    class ServicioTurnos
    {
        public string id { get; set; }
        public int idAsesor { get; set; }
        public int[] contador = { 0, 0, 0 };
        public Turnos.tipoTurno tipoTurno;

        public int frente = -1, atras = -1, maximo = 100, frente1 = -1, atras1 = -1, frente2 = -1, atras2 = -1, frente3 = -1, atras3 = -1;
            
        public string[] colacaja;
        public string[] asesor1;
        public string[] asesor2;
        public string[] asesor3;

        public ServicioTurnos()
        {
        }

        public ServicioTurnos(int max)
        {
            maximo = max;
            colacaja = new string[max];
            asesor1 = new string[max];
            asesor2 = new string[max];
            asesor3 = new string[max];
        }

        public Boolean colallena(int atras)
        {
            if (atras == maximo - 1)
                return true;
            else
                return false;
        }
        
        public Boolean colavacia(int frente)
        {
            if (frente ==  -1)
                return true;
            else
                return false;
        }

        public void agregarcola(string n, string[] cola, int atras)
        {
            if(colallena(atras)==true)
            {
                MessageBox.Show("Cola llena");
            }
            else
            {
                atras++;
                cola[atras] = n;
                if (atras == 0)
                    frente = 0;
            }
        }

        public string delcola(int frente, string[]cola)
        {
            string n = "-666";
            if (colavacia(frente) == true)
                MessageBox.Show("Cola vacía");
            else
            {
                n = cola[frente];
                if(frente==atras)
                {
                    frente = -1;
                    atras = -1;
                }
                else
                    frente++;
            }
            return n;
        }

       
    }
}
