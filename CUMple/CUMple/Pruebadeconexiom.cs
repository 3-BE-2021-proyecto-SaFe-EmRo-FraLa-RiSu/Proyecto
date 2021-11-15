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
    public partial class Pruebadeconexiom : Form
    {
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        MySqlConnection conexionprograma2 = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
    
        public void limpiargrafica()
        {
            Graficadealumnos.Series["Asistencias"].Points.Clear();
            Graficadealumnos.Series["Faltas"].Points.Clear();

        }
        public void creargrafica(string series, string strleertkd, string strleerkrav)
        {
            MySqlCommand comandoleertaekwondo = new MySqlCommand(strleertkd, conexionprograma);
            MySqlCommand comandoleerkrav = new MySqlCommand(strleerkrav, conexionprograma2);
            MySqlDataReader lectordedatostkd;
            MySqlDataReader lectordedatoskrav;
            try
            {
                conexionprograma.Open();
                conexionprograma2.Open();
                lectordedatostkd = comandoleertaekwondo.ExecuteReader();
                lectordedatoskrav = comandoleerkrav.ExecuteReader();
                while (lectordedatostkd.Read())
                {

                    Graficadealumnos.Series[series].Points.AddXY(lectordedatostkd.GetString("tipos"), lectordedatostkd.GetUInt32("Asistencia"));

                }

                while (lectordedatoskrav.Read())
                {
                    Graficadealumnos.Series[series].Points.AddXY(lectordedatoskrav.GetString("tipos"), lectordedatoskrav.GetUInt32("Asistencia"));

                }


                conexionprograma.Close();
                conexionprograma2.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;

            }
        }
        public Pruebadeconexiom()
        {
            InitializeComponent();
        }

        private void Graficadealumnos_Click(object sender, EventArgs e)
        {
            
        }

        private void Pruebadeconexiom_Load(object sender, EventArgs e)
        {
            cmbAño.Items.Add("Ninguno");
            cmbmeses.Items.Add("Ninguno");
            MySqlDataReader lectordedatos;
            string comand = "Select year(fecha) from van group by year(fecha);";
            conexionprograma.Open();
            MySqlCommand comando = new MySqlCommand(comand, conexionprograma);
            lectordedatos = comando.ExecuteReader();
            while (lectordedatos.Read())
            {
                cmbAño.Items.Add(lectordedatos["year(fecha)"].ToString());
            }
            conexionprograma.Close();            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Graficadealumnos_Click_1(object sender, EventArgs e)
        {

        }

        private void comboxmeses_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btncargardatos_Click(object sender, EventArgs e)
        {
            if (cmbAño.SelectedItem != null && cmbAño.SelectedItem.ToString() != "Ninguno" && cmbmeses.SelectedItem != null && cmbmeses.SelectedItem.ToString() != "Ninguno")
            {
                limpiargrafica();
                int mesesindex = cmbmeses.SelectedIndex, meses, años = Int32.Parse(cmbAño.SelectedItem.ToString());
                meses = mesesindex + 1;
                creargrafica("Asistencias", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=1 and month(fecha)='" + meses + "' and year(fecha)='" + años + "' and concurre=1 group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and month(fecha)='" + meses + "' and year(fecha)='" + años + "' and concurre=1 group by v.idclase;");
                creargrafica("Faltas", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=1 and month(fecha)='" + meses + "' and year(fecha)='" + años + "' and concurre=0 group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and month(fecha)='" + meses + "' and year(fecha)='" + años + "' and concurre=0 group by v.idclase;");
            }
            else if (cmbAño.SelectedItem == null || cmbAño.SelectedItem.ToString() == "Ninguno")
            {
                int mesesindex = cmbmeses.SelectedIndex, meses;
                meses = mesesindex + 1;
                buscarsolomes(meses);
            }
            else if (cmbmeses.SelectedItem == null || cmbmeses.SelectedItem.ToString() == "Ninguno")
            {
                buscarsoloaño();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btncargaraños_Click(object sender, EventArgs e)
        {
            
        }

        private void btnvolvercrearlosusuarios_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Dispose();
        }
        public void buscarsolomes(int mes) 
        {
            limpiargrafica();
            int mesesindex = cmbmeses.SelectedIndex, meses;
            meses = mesesindex + 1;
            creargrafica("Asistencias", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=1 and concurre=1 and month(fecha)='" + meses + "' group by YEAR(fecha);", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and concurre=1 and month(fecha)='" + meses + "' group by YEAR(fecha);");
            creargrafica("Faltas", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=1 and concurre=0 and month(fecha)='" + meses + "' group by YEAR(fecha);", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and concurre=0 and month(fecha)='" + meses + "' group by YEAR(fecha);");

        }
        public void buscarsoloaño() 
        {
            limpiargrafica();
            creargrafica("Asistencias", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=1 and concurre=1 group by year(fecha);", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and concurre=1 group by year(fecha);");
            creargrafica("Faltas", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=1 and concurre=0 group by year(fecha);", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and concurre=0 group by year(fecha);");

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void Pruebadeconexiom_MouseDown(object sender, MouseEventArgs e)
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
