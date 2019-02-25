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
    public partial class Asesor1 : Form
    {
        public int id;
        public Asesor1(int id )
        {
            InitializeComponent();
            id = this.id;

            MessageBox.Show(id + "");
            if(id != 0)
            {
                this.Location = new Point((412 * id), 400);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "INICIAR")
                siguienteasesor();
            else
            if(MessageBox.Show("¿Estás seguro?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                siguienteasesor();
            }
        }

        public void siguienteasesor() //cuando ya fue atendido para sacarlo de la cola
        {
            
            string x;
            x = Program.servicio.delcola(Program.servicio.frentea, Program.servicio.asesor, Program.servicio.atrasa);
            if (x == "-666")
            {
                label1.Text = "No hay turnos pendientes";
                label3.Text = "";
            }
            else
            {
                label1.Text = x;
   
                 Hilos.Program.set(x, id);

                
                if (x.Contains("SC"))
                {
                    label3.Text = "Asesoría de servicios";
                }

                else
                {
                    label3.Text = "Asesoría comercial";
                    if (button5.Text == "INICIAR")
                    {
                        button5.Text = "SIGUIENTE";
                    }
                }
            }
        }


        private void Asesor1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 400);
        }
    }
}
