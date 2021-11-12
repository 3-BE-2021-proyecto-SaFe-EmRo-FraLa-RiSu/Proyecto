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
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
         private void formadmin_Load(object sender, EventArgs e)
        {
            MySqlDataReader lectordedatos;
            string comand = "Select nomcompleto from discipulos;";
            conexionprograma.Open();
            MySqlCommand comando = new MySqlCommand(comand, conexionprograma);
            lectordedatos = comando.ExecuteReader();
            while (lectordedatos.Read())
            {
                cmbalumnosexistentes.Items.Add(lectordedatos["nomcompleto"].ToString());
            }
            conexionprograma.Close();
        } 

        private void botingprog_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Dispose();
        }
        private void botcrearus_Click(object sender, EventArgs e)
        {
            if (cmbalumnosexistentes.SelectedIndex != -1) {
                new Editarusuarios().Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un discipulo primero");
            }
        }

        private void btnbuscardis_Click(object sender, EventArgs e)
        {
         
            new Userprofile(cmbalumnosexistentes.SelectedItem.ToString()).Show();
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
