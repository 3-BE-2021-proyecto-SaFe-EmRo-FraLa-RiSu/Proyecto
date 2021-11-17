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
    public partial class Userprofile : Form
    {
        public Userprofile(string nombrebuscado, int index)
        {
            InitializeComponent();
            cargarcmb(index);
        }
        public void cargarcmb(int index) 
        {
            MySqlDataReader lectordedatos;
            string comand = "Select nomcompleto from discipulos;";
            conexionprograma.Open();
            MySqlCommand comando = new MySqlCommand(comand, conexionprograma);
            lectordedatos = comando.ExecuteReader();
            while (lectordedatos.Read())
            {
                cmbdiscipuloseleccionado.Items.Add(lectordedatos["nomcompleto"].ToString());
            }
            conexionprograma.Close();
            cmbdiscipuloseleccionado.SelectedIndex = index;
        }

     
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        MySqlConnection conexionprograma2 = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        public void editarusuario(string columna,string datonuevo, string datoacambiar, string cedula)
        {      
            conexionprograma.Open();
            string comando = "update discipulos set "+ columna + "='"+ datonuevo + "' where "+ columna +"='"+ datoacambiar + "' and cedula ='" + cedula + "';";
            MySqlCommand comandoeditarusuario = new MySqlCommand(comando,conexionprograma);
            try
            {
                comandoeditarusuario.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexionprograma.Close();
            
            if (columna == "nomcompleto") 
            {
                MessageBox.Show("El usuario se ha editado correctamente");
                new Userprofile(datonuevo, cmbdiscipuloseleccionado.SelectedIndex).Show();
                this.Dispose();
            }
        }
        
        public string mostrarlabel(string agarrardato)
        {
            
            conexionprograma.Open();
            string dato;
            string mostrardiscipulos= "select * from discipulos where nomcompleto='"+ cmbdiscipuloseleccionado.SelectedItem.ToString() +"'";
            MySqlCommand comandolabel = new MySqlCommand(mostrardiscipulos,conexionprograma);
            MySqlDataReader lectordecomando = comandolabel.ExecuteReader();
           if (lectordecomando.Read())
            { 
                                             //tabla
                dato=lectordecomando.GetString(agarrardato);
                conexionprograma.Close();
                return dato;         
            }
           else
            {
                conexionprograma.Close();
                return dato = "";

            }





        }
        private void Userprofile_Load(object sender, EventArgs e)
        {
            mskcedula.Text = mostrarlabel("cedula");
            mskcelular.Text = mostrarlabel("celular");
            txbemailedit.Text = mostrarlabel("emails");
            lblfecingpref.Text = mostrarlabel("fecha_de_ing");
            txbfecdenacedit.Text = mostrarlabel("fecha_de_nac");
            txbnomedit.Text = mostrarlabel("nomcompleto");
            txbprofedit.Text = mostrarlabel("profesiones");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            conexionprograma.Open();
            string comandocomparardiscipulos = "select cedula from discipulos;";
            MySqlCommand comandoparacomparardiscipulos = new MySqlCommand(comandocomparardiscipulos, conexionprograma);
            MySqlDataReader lector = comandoparacomparardiscipulos.ExecuteReader();
            while (lector.Read())
            {
                if (lector.GetString("cedula") == mskcedula.Text)
                {
                    MessageBox.Show("Ya hay un usuario existente con esa cédula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexionprograma.Close();
                    return;
                }
            }
            if (txbprofedit.Text != mostrarlabel("profesiones")) 
            {
                editarusuario("profesiones", txbprofedit.Text, mostrarlabel("profesiones"), mostrarlabel("cedula"));
            }          
            if (txbnomedit.Text != mostrarlabel("nomcompleto"))
            {
                editarusuario("nomcompleto", txbnomedit.Text, mostrarlabel("nomcompleto"), mostrarlabel("cedula"));             
            }           
            if (mskcedula.Text != mostrarlabel("cedula"))
            {
                editarusuario("cedula", mskcedula.Text, mostrarlabel("cedula"), mostrarlabel("cedula"));
            }           
            if (mskcelular.Text != mostrarlabel("celular"))
            {
                editarusuario("celular", mskcelular.Text, mostrarlabel("celular"), mostrarlabel("cedula"));
            }           
            if (txbemailedit.Text != mostrarlabel("emails"))
            {
                editarusuario("emails", txbemailedit.Text, mostrarlabel("emails"), mostrarlabel("cedula"));
            }                                           
            if (txbfecdenacedit.Text != mostrarlabel("fecha_de_nac"))
            {
                editarusuario("fecha_de_nac", txbfecdenacedit.Text, mostrarlabel("fecha_de_nac"), mostrarlabel("cedula"));
            }      
        }

        private void lblmostnom_Click(object sender, EventArgs e)
        {

        }

        private void txbfecdenacedit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnomperf_Click(object sender, EventArgs e)
        {

        }

        private void btnvolveruserprofile_Click(object sender, EventArgs e)
        {
            new formadmin().Show();
            this.Dispose();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbceddit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbnomedit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbprofedit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbnomedit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 65 && e.KeyChar != 8) || (e.KeyChar > 90 && e.KeyChar < 97) || (e.KeyChar > 122 && e.KeyChar != 130 && e.KeyChar < 160) || e.KeyChar > 165) && e.KeyChar != Convert.ToChar(Keys.Space))
            {
                MessageBox.Show("Solo letras permitidas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txbprofedit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 65 && e.KeyChar != 8) || (e.KeyChar > 90 && e.KeyChar < 97) || (e.KeyChar > 122 && e.KeyChar != 130 && e.KeyChar < 160) || e.KeyChar > 165) && e.KeyChar != Convert.ToChar(Keys.Space))
            {
                MessageBox.Show("Solo letras permitidas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txbceddit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 8 || (e.KeyChar > 8 && e.KeyChar < 48) || e.KeyChar > 57)
            {
                MessageBox.Show("Solo números permitidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txbceledit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 8 || (e.KeyChar > 8 && e.KeyChar < 48) || e.KeyChar > 57)
            {
                MessageBox.Show("Solo números permitidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void mskcédula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 8 || (e.KeyChar > 8 && e.KeyChar < 48) || e.KeyChar > 57)
            {
                MessageBox.Show("Solo números permitidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Userprofile_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cmbdiscipuloseleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskcedula.Text = mostrarlabel("cedula");
            mskcelular.Text = mostrarlabel("celular");
            txbemailedit.Text = mostrarlabel("emails");
            lblfecingpref.Text = mostrarlabel("fecha_de_ing");
            txbfecdenacedit.Text = mostrarlabel("fecha_de_nac");
            txbnomedit.Text = mostrarlabel("nomcompleto");
            txbprofedit.Text = mostrarlabel("profesiones");
        }

        private void cerrarclic_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }

        private void restaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexionprograma2.Open();
            string comandoeliminarusuario = "delete from discipulos where cedula = '"+mostrarlabel("cedula").ToString()+"';";
            MySqlCommand comandoparaeliminarusuario = new MySqlCommand(comandoeliminarusuario, conexionprograma2);
            
            if (comandoparaeliminarusuario.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("El usuario fue eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbdiscipuloseleccionado.Items.Clear();
                cargarcmb(1);
            }
            else
            {
                MessageBox.Show("El usuario a eliminar no concuerda con ningun usuario existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexionprograma2.Close();
        }

        private void mskcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 8 || (e.KeyChar > 8 && e.KeyChar < 48) || e.KeyChar > 57)
            {
                MessageBox.Show("Solo números permitidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cmbdiscipuloseleccionado_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
