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
        public static Clases.ServicioTurnos servicio = new Clases.ServicioTurnos(100);
        public static Form1 frmGeneral;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// CheckForIllegalCrossThreadCalls = false;
        
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

            frmGeneral = new Form1();
            frmGeneral.Show();


        }
            
        public static void set(string t)
        {
            frmGeneral.exe(t, frmGeneral.label7);
        }


        static void start()
        {
            Application.Run(new Formusuario());

        }
        static void asesor()
        {
            Application.Run(new Asesor1());
        }


        
    }
}
