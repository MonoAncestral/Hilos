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

        public int frentec = -1, atrasc = -1, maximo = 100, frentea=-1, atrasa=-1;
            
        public string[] colacaja;
        public string[] asesor;


        public ServicioTurnos(int max)
        {
            maximo = max;
            colacaja = new string[max];
            asesor = new string[max];
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

        public void agregarcola(string n, string[] cola, int atras, int frente)
        {
            if(colallena(atras)==true)
            {
                MessageBox.Show("Cola llena");
            }
            else
            {
                if (cola == colacaja)
                {
                    atrasc++;
                    cola[atrasc] = n;
                    if (atrasc == 0)
                        frentec = 0;
                }
                else
                {
                    atrasa++;
                    cola[atrasa] = n;
                    if (atrasa == 0)
                        frentea = 0;
                }
            }
        }

        public string delcola(int frente, string[]cola, int atras)
        {
            string n = "-666";
            if (colavacia(frente))
                MessageBox.Show("Cola vacía");
            else
            {
                n = cola[frente];
                if (frente == atras)
                {
                    if (cola == colacaja)
                    {
                        frentec = -1;
                        atrasc = -1;
                    } 
                    else
                    {
                        frentea = -1;
                        atrasa = -1;
                    }
                }
                else
                {
                    if (cola == colacaja)
                        frentec++;
                    else
                        frentea++;
                }
            }
            return n;
        }
    }
}
