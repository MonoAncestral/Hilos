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

        public int frente=-1, atras=-1, maximo=100;
        public string[] cola=new string[100];

        public ServicioTurnos()
        {
        }

        public ServicioTurnos(int max)
        {
            maximo = max;
            cola = new string[max];
        }

        public Boolean colallena()
        {
            if (atras == maximo - 1)
                return true;
            else
                return false;
        }
        
        public Boolean colavacia()
        {
            if (frente ==  -1)
                return true;
            else
                return false;
        }

        public void agregarcola(string n)
        {
            if(colallena()==true)
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

        public string delcola()
        {
            string n = "-666";
            if (colavacia() == true)
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
