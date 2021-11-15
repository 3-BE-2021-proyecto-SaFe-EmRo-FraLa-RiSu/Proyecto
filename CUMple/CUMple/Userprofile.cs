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
        public Userprofile(string nombrebuscado)
        {
            InitializeComponent();
            llblnombrediscelec.Text = nombrebuscado;
            
        }            
     
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
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
            MessageBox.Show("El usuario se ha editado correctamente");

            conexionprograma.Close();
            
            if (columna == "nomcompleto") 
            {
                new Userprofile(datonuevo).Show();
                this.Dispose();
            }
        }
        
        public string mostrarlabel(string agarrardato)
        {
          
            conexionprograma.Open();
            string dato;
            string mostrardiscipulos= "select * from discipulos where nomcompleto='"+ llblnombrediscelec.Text +"'";
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
            txbceledit.Text = mostrarlabel("celular");
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
           
            //Agregar que la fecha de ingreso se genere automaticamente

            //if ( hay un usuario seleccionado   ) { pedir que se seleccione uno }
            //else {
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
           
            if (txbceledit.Text != mostrarlabel("celular"))
            {
                editarusuario("celular", txbceledit.Text, mostrarlabel("celular"), mostrarlabel("cedula"));
            }
           
            if (txbemailedit.Text != mostrarlabel("emails"))
            {
                editarusuario("emails", txbemailedit.Text, mostrarlabel("emails"), mostrarlabel("cedula"));
            }                   
                        
            if (txbfecdenacedit.Text != mostrarlabel("fecha_de_nac"))
            {
                editarusuario("fecha_de_nac", txbfecdenacedit.Text, mostrarlabel("fecha_de_nac"), mostrarlabel("cedula"));

            }
          
            //}
            
         
          
         
           
           
           
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
            if ((e.KeyChar >= 33 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 225))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txbprofedit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 225))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txbceddit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 225))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txbceledit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 225))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void mskcédula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 225))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
