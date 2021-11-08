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
    public partial class Userprofileadd : Form
    {
        public Userprofileadd()
        {
            InitializeComponent();
        }

        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");

        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregarusuario(txbtxbnombrecompleto.ToString(), txbcedula.ToString(), txbcelular.ToString(), txbprofesion.ToString(), txbfecnac, txbemail, chbtaekwondo, chbkrav);
        }
        public void agregarusuario(string nombrecompleto, string cedula , string celular, string profesion, string fech_nac, string email, string taekwondo, string krav)
        { 
            conexionprograma.Open();
            string comando = "";
            MySqlCommand comandoeditarusuario = new MySqlCommand(comando, conexionprograma);
            try
            {
                comandoeditarusuario.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("El usuario se ha creado correctamente");
            conexionprograma.Close();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnvolveruserprofile_Click(object sender, EventArgs e)
        {
            new formadmin().Show();
            this.Dispose();
        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }
    }
}
