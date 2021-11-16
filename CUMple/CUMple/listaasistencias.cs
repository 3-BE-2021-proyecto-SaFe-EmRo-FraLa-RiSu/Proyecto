using MySql.Data.MySqlClient;
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
    public partial class listaasistencias : Form
    {
        MySqlConnection conexionbd = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        public listaasistencias()
        {
            InitializeComponent();
        }
        bool krav, adultos, tigres, avanzados,adolescentes;

        private void listaasistencias_Load(object sender, EventArgs e)
        {

        }

        private void panelapoyo2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void txbbucar_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txbbucar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable filas = new DataTable();

            if (krav!=false || adultos!=false || avanzados!=false || adolescentes!=false ||  tigres!=false)
            {
                if (krav == true)
                {
                    string comando = "SELECT nomcompleto,fecha_de_nac from discipulos where MONTH(fecha_de_nac)<='2008' and krav_maga=1 group by cedula";

                    MySqlCommand comandosql = new MySqlCommand(comando, conexionbd);
                   

                }

                if (adultos==true)
                {
                    string comando = "SELECT nomcompleto,fecha_de_nac from discipulos where MONTH(fecha_de_nac)<='2008' and taekwondo=1 group by cedula";

                    MySqlCommand comandosql = new MySqlCommand(comando, conexionbd);
                }

                if (avanzados == true)
                {
                    string comando = "SELECT nomcompleto,fecha_de_nac,rango from discipulos where MONTH(fecha_de_nac)<='2008' and taekwondo=1 and rango NOT IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado','Camuflado','Camuflado confirmado') group by cedula";

                    MySqlCommand comandosql = new MySqlCommand(comando, conexionbd);
                }
                if (avanzados == true)
                {
                    string comando = "SELECT nomcompleto,fecha_de_nac,rango from discipulos where MONTH(fecha_de_nac)<='2008' and taekwondo=1 and rango  IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado','Camuflado','Camuflado confirmado') group by cedula";

                    MySqlCommand comandosql = new MySqlCommand(comando, conexionbd);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una clase.","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txbbucar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            restaurar.Visible = true;
            maximizar.Visible = false;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void listaasistencias_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnkravmaga_Click(object sender, EventArgs e)
        {
             krav = true;
             adultos = false;
             tigres = false;
             avanzados = false;
            adolescentes = false;
        }

        private void clicktigres(object sender, EventArgs e)
        {
            krav = false;
            adultos = false;
            tigres = true;
            avanzados = false;
            adolescentes = false;
        }

        private void btnavanzados_Click(object sender, EventArgs e)
        {
            krav = false;
            adultos = false;
            tigres = false;
            avanzados = true;
            adolescentes = false;
        }

        private void adolescentes_Click(object sender, EventArgs e)
        {
            krav = false;
            adultos = false;
            tigres = false;
            avanzados = false;
            adolescentes = true;
        }

        private void dgvasistencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadulto(object sender, EventArgs e)
        {
            krav = false;
            adultos = true;
            tigres = false;
            avanzados = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

      
    }
}
