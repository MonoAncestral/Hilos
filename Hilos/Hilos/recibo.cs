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
    public partial class recibo : Form
    {
        public recibo()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, false);
        }

        private void recibo_Load(object sender, EventArgs e)
        {
            tbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tbHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
