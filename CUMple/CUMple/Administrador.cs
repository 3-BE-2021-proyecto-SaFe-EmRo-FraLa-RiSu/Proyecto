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
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        MySqlDataReader lectordedatos;
        
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
            conexionprograma.Open();
            string comandostring = "select * from discipulos where nomcompleto='"+txbdiscipulo.Text+"'";
            MySqlCommand comandoparalabd = new MySqlCommand(comandostring,conexionprograma);
            lectordedatos = comandoparalabd.ExecuteReader();
            new Userprofile(txbdiscipulo.Text).Show();
            this.Dispose();
        }
    }
}
