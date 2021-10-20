using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            new Principal().Show();
            this.Dispose();
        }
        private void botcrearus_Click(object sender, EventArgs e)
        {
            new Editarusuarios().Show();
            this.Dispose();
            
        }

        private void btnbuscardis_Click(object sender, EventArgs e)
        {
            new Userprofile(txbdiscipulo.Text).Show();
            this.Dispose();
        }
    }
}
