using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CUMple
{


    public partial class Principal : Form
    {
        public Principal(string tipo)
        {
            InitializeComponent();
            if (tipo == "Adm")
            {
                btnverexamenespersonales.Visible = false;
            }
            else
            {
                flowLayoutPanel3.Visible = false;
                btnvolver.Visible = false;
                btncinturones.Visible = false;
                btnentrarexamenes.Visible = false;
                btnlista.Visible = false;               
                flowLayoutPanel2.Visible = false;
                panelapoyo4.Visible = false;
            }

         
        }
        string cedulaprin;

       public Principal(string tipo, string cedula)
        {
            InitializeComponent();
            if (tipo == "Adm")
            {
                btnverexamenespersonales.Visible = false;
            }
            else
            {
                flowLayoutPanel3.Visible = false;
                btnvolver.Visible = false;
                btncinturones.Visible = false;
                btnentrarexamenes.Visible = false;
                btnlista.Visible = false;
                botingprog.Visible = false;
                panelapoyo5.Visible = false;
                flowLayoutPanel2.Visible = false;
                panelapoyo4.Visible = false;
            }

            cedulaprin = cedula;  
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
     
        }

        private void botingprog_Click(object sender, EventArgs e)
        {
            new Pruebadeconexiom().Show();
            this.Hide();
        }

        private void btnentrarexamenes_Click(object sender, EventArgs e)
        {
            new Examenesfrm().Show();
            this.Dispose();
        }

        private void btnnotas_Click(object sender, EventArgs e)
        {
            
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            minimizar.Visible = false;
            maximizar.Visible = true;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            minimizar.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void barradebotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void barramenu_Paint(object sender, PaintEventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Principal_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void barradebotones_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void barramenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void imagenata_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Graficascinturones().Show();
            this.Dispose();
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            new listaasistencias().Show();
            this.Dispose();
        }

        private void btnvolveradmin(object sender, EventArgs e)
        {
            new formadmin().Show();
            this.Dispose();
        }

        private void btngraficacinturones_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Users\Emilio\Desktop\Emi\Cortesproyecto\Manual.docx");
        }

        private void btnverexamenespersonales_Click(object sender, EventArgs e)
        {
            new Misexamenes(cedulaprin).Show();
            this.Dispose();
        }

        private void btnverasistenciaspersonales_Click(object sender, EventArgs e)
        {
            new Misasistencias(cedulaprin).Show();
        }

        private void panelapoyo4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
