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

            ThreadStart g3 = new ThreadStart(asesor2);
            Thread hiloAsesor2 = new Thread(g3);
            hiloAsesor2.Start();

            ThreadStart g4 = new ThreadStart(asesor3);
            Thread hiloAsesor3 = new Thread(g4);
            hiloAsesor3.Start();

            ThreadStart g5 = new ThreadStart(Caja1);
            Thread hiloCaja1 = new Thread(g5);
            hiloCaja1.Start();
            frmGeneral = new Form1();
            frmGeneral.Show();


        }
            
        public static void set1(string t)
        {
            frmGeneral.exe(t, frmGeneral.label7);
        }


        public static void set2(string t)
        {
            frmGeneral.exe(t, frmGeneral.label8);
        }

        public static void set3(string t)
        {
            frmGeneral.exe(t, frmGeneral.label9);
        }

        public static void set4(string t)
        {
            frmGeneral.exe(t, frmGeneral.label10);
        }

        static void start()
        {
            Application.Run(new Formusuario());

        }
        static void asesor()
        {
            Application.Run(new Asesor1());
        }
        static void asesor2()
        {
            Application.Run(new Asesor2());
        }
        static void asesor3()
        {
            Application.Run(new Asesor3());
        }
        static void Caja1()
        {
            Application.Run(new Caja1());
        }



    }
}
