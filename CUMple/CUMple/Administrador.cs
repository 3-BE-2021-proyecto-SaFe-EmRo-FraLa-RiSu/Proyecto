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
    public partial class formadmin : Form
    {
        public formadmin()
        {
            InitializeComponent();
        }
      
        private void formadmin_Load(object sender, EventArgs e)
        {

        }

        private void botingprog_Click(object sender, EventArgs e)
        {
            Crearlosusuarios chong = new Crearlosusuarios();
            chong.Show();
            this.Dispose();
        }
    }
}
