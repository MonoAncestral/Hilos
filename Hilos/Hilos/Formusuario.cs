using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos
{
    public partial class Formusuario : Form
    {

        private Boolean useClass = false;
        private Clases.Turnos.tipoTurno tipoTurno;

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
            asignarTurno();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            useClass = false;
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
            Clases.ServicioTurnos turno = new Clases.ServicioTurnos();

            int position = 0;

            if(Clases.Turnos.tipoTurno.Caja == tipoTurno)
            {
                position = 2;
            }
            else if(Clases.Turnos.tipoTurno.Comercial == tipoTurno)
            {
                position = 1;
            }
            else if (Clases.Turnos.tipoTurno.Servicios == tipoTurno)
            {
                position = 0;
            }

            turno.contador[position]++;
            turno.id = tipoTurno.ToString().Substring(0, 1) + string.Format("{0:000}", turno.contador[position]); 

            MessageBox.Show(turno.id);
        }

        #endregion
    }
}
