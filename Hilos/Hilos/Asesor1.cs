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

        Form1 f = new Form1();
        Formusuario fu = new Formusuario();

        public Asesor1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                fu.button18.PerformClick();
            }
        }

        public void siguiente1() //cuando ya fue atendido para sacarlo de la cola
        {
            string x;
            x = Program.servicio.delcola(Program.servicio.frentea, Program.servicio.asesor, Program.servicio.atrasa);
            if (x == "-666")
                MessageBox.Show("");
            else
                MessageBox.Show(x + " Salió de la cola");
        }

        private void Asesor1_Load(object sender, EventArgs e)
        {

        }
    }
}
