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
            int taekwondobool, krav_magabool; 

            if (chbtaekwondo.Checked == true){
                taekwondobool = 1;
            }else{
                taekwondobool = 0;
            }
            if (chbkrav.Checked == true){
                krav_magabool = 1;
            }else{
                krav_magabool = 0;
            }

            //agregarusuario(txbtxbnombrecompleto.ToString(), txbcedula.ToString(), txbcelular.ToString(), txbprofesion.ToString(), dtpfec_nac.ToString() , txbemail.ToString(), taekwondobool.ToString(), krav_magabool.ToString());

            conexionprograma.Open();
            string comando = "insert into discipulos values ("+txbcelular.ToString()+", "/* fecha actual */+""+txbnombrecompleto.ToString()+", "+krav_magabool.ToString()+", "+taekwondobool.ToString()+", "+txbprofesion.ToString()+", "+dtpfec_nac.ToString()+", "+txbemail.ToString()+");";
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
        /*
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
        */
        

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
