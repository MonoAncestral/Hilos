using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hilos
{
    static class Program
    {
        static Clases.ServicioTurnos servicio = new Clases.ServicioTurnos(100);
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ThreadStart g = new ThreadStart(start);
            Thread hilo = new Thread(g);
            hilo.Start();
            ThreadStart g2 = new ThreadStart(asesor);
            Thread hiloAsesor = new Thread(g2);
            hiloAsesor.Start();
            Application.Run(new Formusuario());
            

        }

        static void start()
        {
            Application.Run(new Form1());
        }
        static void asesor()
        {
            Application.Run(new Asesor1());
        }

        public static void hola()
        {
            if (servicio.colavacia(0))
            {
                MessageBox.Show("no sé que signifique ");
            }
            else
            {
                MessageBox.Show("chao");
            }
        }
        
    }
}
