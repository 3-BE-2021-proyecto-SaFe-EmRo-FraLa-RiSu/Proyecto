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
    public partial class Examenesfrm : Form
    {
        MySqlConnection conexionbd = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");

        public Examenesfrm()
        {
            InitializeComponent();

        }

        private DataTable cargarexamenes()
        {
            DataTable dtexamenes = new DataTable();
            string comandostring = "select * from examenes;";

            MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring,conexionbd);
         
          
                conexionbd.Open();
            comandotraerexamenes.Fill(dtexamenes);
               
        
            conexionbd.Close();
            return dtexamenes;
        }

        private void Examenesfrm_Load(object sender, EventArgs e)
        {
            dgvexamenes.DataSource=cargarexamenes();
        }

        private void dgvexamenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
