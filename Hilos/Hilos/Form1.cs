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
    public partial class Form1 : Form
    {

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void exe(string t, Label t2)
        {
            t2.Text = t;

            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10

            // Synchronous
            synthesizer.SpeakAsync("TURNO " + t +  " PASAR A ASESOR NÚMERO 1");
        }

        private void label5_Click(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
