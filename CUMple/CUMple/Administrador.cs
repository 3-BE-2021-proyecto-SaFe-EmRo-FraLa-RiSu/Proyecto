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
            new Principal("Adm").Show();
            this.Dispose();
        }
        private void botcrearus_Click(object sender, EventArgs e)
        {
            if (cmbalumnosexistentes.SelectedIndex != -1) {
                new Userprofile(cmbalumnosexistentes.SelectedItem.ToString(), cmbalumnosexistentes.SelectedIndex).Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un discipulo primero");
            }
        }

        private void btnbuscardis_Click(object sender, EventArgs e)
        {
         
            new Userprofile(cmbalumnosexistentes.SelectedItem.ToString(),2).Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            new Userprofileadd().Show();
            this.Dispose();
        }

        private void cmbalumnosexistentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 225)) 
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txbapellidofiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 65 && e.KeyChar != 8) || (e.KeyChar > 90 && e.KeyChar < 97) || (e.KeyChar > 122 && e.KeyChar != 130 && e.KeyChar < 160) || e.KeyChar > 165) && e.KeyChar != Convert.ToChar(Keys.Space))
            {
                MessageBox.Show("Solo letras permitidas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public void actualizarfiltrado() 
        {
            if (txbapellidofiltrar.Text == "")
            {
                cmbalumnosexistentes.Items.Clear();
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
            else 
            {
                cmbalumnosexistentes.Items.Clear();
                MySqlDataReader lectordedatos;
                string buscar = "Select nomcompleto from discipulos where nomcompleto like '%" + txbapellidofiltrar.Text + "%'";
                conexionprograma.Open();
                MySqlCommand comando = new MySqlCommand(buscar, conexionprograma);
                lectordedatos = comando.ExecuteReader();
                while (lectordedatos.Read())
                {
                    cmbalumnosexistentes.Items.Add(lectordedatos["nomcompleto"].ToString());
                }
                conexionprograma.Close();
            }
        }


        private void lblxd_Click(object sender, EventArgs e)
        {

        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void formadmin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Editarusuarios().Show();
            this.Dispose();
        }

        private void txbapellidofiltrar_TextChanged(object sender, EventArgs e)
        {
            actualizarfiltrado();
        }
    }
}
