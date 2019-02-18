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
        Clases.ServicioTurnos turno = new Clases.ServicioTurnos();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            useClass = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            tipoTurno = Clases.Turnos.tipoTurno.Comercial;
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
                asignarTurno();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            useClass = false;
            tabControl1.SelectedIndex = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tipoTurno = Clases.Turnos.tipoTurno.Caja;
            tabControl1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipoTurno = Clases.Turnos.tipoTurno.Servicios;
            tabControl1.SelectedIndex = 2;
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
            turno.contador[position]++;

            if (idTurno != "")
            {
                turno.id = idTurno + string.Format("{0:000}", turno.contador[position]);
            }
            else
            {
                turno.id = tipoTurno.ToString().Substring(0, 1) + string.Format("{0:000}", turno.contador[position]);
            }

            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10

            // Synchronous
            synthesizer.SpeakAsync("SU TURNO HA SIDO ASIGNADO: " + turno.id);
            MessageBox.Show(turno.id);
        }
        private void cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

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
        
    }
}
