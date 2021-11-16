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

        private void listaasistencias_Load(object sender, EventArgs e)
        {

        }

        private void btneditarusuario_Click(object sender, EventArgs e)
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
            string comando = "SELECT nomcompleto,tipos FROM discipulos d JOIN van v ON d.cedula = v.cedula JOIN clase c ON v.idclase = c.idclase where nomcompleto like '%" + txbbucar.Text  + "%' GROUP BY c.idclase";
            conexionbd.Open();
            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
            comandosql.Fill(filas);
            conexionbd.Close();
            dgvasistencias.Refresh();
            dgvasistencias.DataSource = filas;
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
