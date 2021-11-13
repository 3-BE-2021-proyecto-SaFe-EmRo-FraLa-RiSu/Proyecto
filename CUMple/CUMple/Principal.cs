using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void botingprog_Click(object sender, EventArgs e)
        {
            new Pruebadeconexiom().Show();
            this.Hide();
        }

        private void btnentrarexamenes_Click(object sender, EventArgs e)
        {
            new Examenesfrm().Show();
            this.Dispose();
        }

        private void btnnotas_Click(object sender, EventArgs e)
        {
            new examenesnotas().Show();
            this.Dispose();
        }

        }
}
