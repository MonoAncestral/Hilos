﻿using System;
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

       
        Formusuario fu = new Formusuario();

        public Asesor1()
        {
            InitializeComponent();
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
                Hilos.Program.set(x);
                if (x.Contains("SC"))
                {
                    label3.Text = "Asesoría se servicios";
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

        public void siguientecaja() //cuando ya fue atendido para sacarlo de la cola
        {
            string x;
            x = Program.servicio.delcola(Program.servicio.frentec, Program.servicio.colacaja, Program.servicio.atrasc);
            if (x == "-666")
                MessageBox.Show("");
            else

            {
                label1.Text = x;
                if (x.Contains("SC"))
                    label3.Text = "Asesoría se servicios";
                else
                    label3.Text = "Asesoría comercial";
            }
        }


        private void Asesor1_Load(object sender, EventArgs e)
        {

        }
    }
}
