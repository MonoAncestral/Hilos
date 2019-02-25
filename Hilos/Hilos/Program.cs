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

   
            ThreadStart g2 = new ThreadStart(() => asesor(0));
            Thread hiloAsesor = new Thread(g2);
            hiloAsesor.Start();

            ThreadStart g4 = new ThreadStart(() => asesor(1));
            Thread hiloAsesor2 = new Thread(g4);
            hiloAsesor2.Start();

            ThreadStart g5 = new ThreadStart(() => asesor(2));
            Thread hiloAsesor3 = new Thread(g5);
            hiloAsesor3.Start();


            ThreadStart g3 = new ThreadStart(Caja1);
            Thread hiloCaja1 = new Thread(g3);
            hiloCaja1.Start();

            frmGeneral = new Form1();
            frmGeneral.Show();


        }
            
        public static void set(string t, int id)
        {
            MessageBox.Show(id.ToString());
            switch (id)
            {
                case 0: frmGeneral.exe(t, frmGeneral.label7); break;
                case 1: frmGeneral.exe(t, frmGeneral.label8); break;
                case 2: frmGeneral.exe(t, frmGeneral.label9); break;
                case 3: frmGeneral.exe(t, frmGeneral.label10); break;
            }
            

        }

        static void start()
        {
            Application.Run(new Formusuario());
        }

        static void asesor(int id)
        {

            Application.Run(new Asesor1(3));
        }

        static void Caja1()
        {
            Application.Run(new Caja1(3));
        }



    }
}
