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
        }


        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        public void MyButtonClick(object sender, EventArgs e)
        {
            addText((Button)sender);
        }
        private void addText(Button button)
        {
            cedula.AppendText(button.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }
    }
}
