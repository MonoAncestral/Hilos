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
        Clases.ServicioTurnos st = new Clases.ServicioTurnos();

        public Asesor1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                //siguiente en la cola
            }
        }

        private void Asesor1_Load(object sender, EventArgs e)
        {

        }
    }
}
