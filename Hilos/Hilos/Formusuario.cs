using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Hilos
{
    public partial class Formusuario : Form
    {
      //  Clases.ServicioTurnos turno = new Clases.ServicioTurnos();
        private Boolean useClass = false;
        private Clases.Turnos.tipoTurno tipoTurno;
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();


        #region AccionesPorDefecto

        public Formusuario()
        {
            InitializeComponent();
            button6.Click += new EventHandler(MyButtonClick);
            button7.Click += new EventHandler(MyButtonClick);
            button8.Click += new EventHandler(MyButtonClick);
            button9.Click += new EventHandler(MyButtonClick);
            button10.Click += new EventHandler(MyButtonClick);
            button11.Click += new EventHandler(MyButtonClick);
            button12.Click += new EventHandler(MyButtonClick);
            button13.Click += new EventHandler(MyButtonClick);
            button14.Click += new EventHandler(MyButtonClick);
            button17.Click += new EventHandler(MyButtonClick);
            Hilos.Program.hola();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            useClass = true;
            tabControl1.TabPages.Insert(1, tabPage2);
            tabControl1.SelectTab(1);
            tabControl1.TabPages.Remove(tabPage1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            tipoTurno = Clases.Turnos.tipoTurno.Comercial;
            tabControl1.TabPages.Insert(1, tabPage3);
            tabControl1.SelectTab(1);
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void MyButtonClick(object sender, EventArgs e)
        {
            addText((Button)sender);
        }

        private void addText(Button button)
        {
            cedula.AppendText(button.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string data = cedula.Text;
            if (data.Length > 0)
            {
                cedula.Text = data.Substring(0, (data.Length - 1));
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (vacio(cedula))
            {
                recibo r = new recibo();
                asignarTurno();
               // r.label2.Text = turno.id;
                cedula.Text = "";
                tabControl1.TabPages.Insert(1, tabPage1);
                tabControl1.SelectTab(1);
                tabControl1.TabPages.Remove(tabPage3);
                r.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            useClass = false;
            tabControl1.TabPages.Insert(1, tabPage2);
            tabControl1.SelectTab(1);
            tabControl1.TabPages.Remove(tabPage1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tipoTurno = Clases.Turnos.tipoTurno.Caja;
            tabControl1.SelectedIndex = 2;
            tabControl1.TabPages.Insert(1, tabPage3);
            tabControl1.SelectTab(1);
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipoTurno = Clases.Turnos.tipoTurno.Servicios;
            tabControl1.TabPages.Insert(1, tabPage3);
            tabControl1.SelectTab(1);
            tabControl1.TabPages.Remove(tabPage2);
        }

        #endregion

        #region Funciones de asignación
    
        void asignarTurno()
        {
            int position = 0;
            string idTurno = "";

            if(Clases.Turnos.tipoTurno.Caja == tipoTurno)
            {
                position = 2;
            }
            else if(Clases.Turnos.tipoTurno.Comercial == tipoTurno)
            {
                position = 1;
                idTurno = "SC";
            }
            else if (Clases.Turnos.tipoTurno.Servicios == tipoTurno)
            {
                position = 0;
            }
           // turno.contador[position]++;

            if (idTurno != "")
            {
            //    turno.id = idTurno + string.Format("{0:000}", turno.contador[position]);
            }
            else
            {
             //   turno.id = tipoTurno.ToString().Substring(0, 1) + string.Format("{0:000}", turno.contador[position]);
            }

            /*if (Clases.Turnos.tipoTurno.Servicios == tipoTurno || Clases.Turnos.tipoTurno.Comercial == tipoTurno)
               // st.agregarcola(turno.id, st.asesor, st.atrasa, st.frentea);
            else*/
               // st.agregarcola(turno.id, st.colacaja, st.atrasc, st.frentec);

            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10

            // Synchronous
          //  synthesizer.SpeakAsync("SU TURNO HA SIDO ASIGNADO: " + turno.id);
            
        }

        public void crearcola()
        {
           // st = new Clases.ServicioTurnos(100);
        }

        private void cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
        #endregion

        
      /*  public void siguiente () //cuando ya fue atendido para sacarlo de la cola
        {
            string x;
           // x=st.delcola(st.frentec, st.colacaja, st.atrasc);
            if (x=="-666")
                MessageBox.Show("");
            else
                MessageBox.Show(x+" Salió de la cola");
        }
        */
       /* public void siguiente1() //FUNCIONA AQUÍ PERO NO EN ASESOR :)
        {
            string x;
           // x = st.delcola(st.frentea, st.asesor, st.atrasa);
            if (x == "-666")
                MessageBox.Show("");
            else
                MessageBox.Show(x + " Salió de la cola");
        }*/

        #region Funciones de validación
        public Boolean vacio (TextBox text)
        {
            if(text.Text == "")
            {
                MessageBox.Show("Por favor ingrese un número");
                return false;
            }
            return true;
        }
        #endregion

        private void Formusuario_Load(object sender, EventArgs e)
        {
            crearcola();
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            this.Location = new Point(663, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Insert(1, tabPage1);
            tabControl1.SelectTab(1);
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Insert(1, tabPage2);
            tabControl1.SelectTab(1);
            tabControl1.TabPages.Remove(tabPage3);
        }

       
        private void button18_Click_1(object sender, EventArgs e)
        {
           //siguiente1();
        }
    }
}
