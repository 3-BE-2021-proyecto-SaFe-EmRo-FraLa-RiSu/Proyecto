﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUMple
{
    public partial class Misasistencias : Form
    {
        string cedulaporagarrar;
        public Misasistencias(string cedula)
        {
            InitializeComponent();
            cedulaporagarrar = cedula;
        }

        private void btnvolverpruebaconexion_Click(object sender, EventArgs e)
        {
            new Principal("Alm", cedulaporagarrar).Show();
        }

        private void btncargardatos_Click(object sender, EventArgs e)
        {

        }
    }
}
