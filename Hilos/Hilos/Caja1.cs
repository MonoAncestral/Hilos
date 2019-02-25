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
    public partial class Caja1 : Form
    {
        private int id;
        public Caja1(int id )
        {
            InitializeComponent();
            this.id = id;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "INICIAR")
                siguientecaja();
            else
           if (MessageBox.Show("¿Estás seguro?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                siguientecaja();
            }
        }

        public void siguientecaja() //cuando ya fue atendido para sacarlo de la cola
        {
            string x;
            x = Program.servicio.delcola(Program.servicio.frentec, Program.servicio.colacaja, Program.servicio.atrasc);
            if (x == "-666")
            {
                label1.Text = "No hay turnos pendientes"; 
            }
            else

            {
                label1.Text = x;
                Hilos.Program.set(x, id);
                if (button5.Text == "INICIAR")
                {
                    button5.Text = "SIGUIENTE";
                }
            }
        }

        private void Caja1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(412*3, 750);
        }
    }
}
