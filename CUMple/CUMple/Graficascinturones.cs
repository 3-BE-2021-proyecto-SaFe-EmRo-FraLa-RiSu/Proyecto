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
    public partial class Graficascinturones : Form
    {
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        MySqlConnection conexionprograma2 = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        public Graficascinturones()
        {
            InitializeComponent();
        }
        public void limpiargrafica()
        {
            Graficadecinturones.Series["Rangos"].Points.Clear();
        }
        private void btncargarcinturones_Click(object sender, EventArgs e)
        {
            cargargrafica();
        }

        public void creargrafica(string rangos, string leercant_alumnos,string getstring)
        {
            MySqlCommand comandoleeralumnos = new MySqlCommand(leercant_alumnos, conexionprograma);
            MySqlDataReader lectordedatoscinturones;
            MySqlCommand comandoleerrangos = new MySqlCommand(rangos, conexionprograma2);
            MySqlDataReader lectorderangos;
            Graficadecinturones.Series["Rangos"].Points.Clear();
            conexionprograma.Open();
            conexionprograma2.Open();
            try
            {            
              
                lectordedatoscinturones = comandoleeralumnos.ExecuteReader();
                lectorderangos = comandoleerrangos.ExecuteReader();
                while (lectordedatoscinturones.Read() && lectorderangos.Read())
                {
                    Graficadecinturones.Series["Rangos"].Points.AddXY(lectorderangos.GetString(getstring), lectordedatoscinturones.GetInt32("COUNT(*)"));
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexionprograma.Close();
            conexionprograma2.Close();
        }
        private void Graficascinturones_Load(object sender, EventArgs e)
        {
            cargargrafica();
        }
        
        private void dtpfec_nac_ValueChanged(object sender, EventArgs e)
        {
            cargargrafica();
        }

        public void cargargrafica() 
        {
            limpiargrafica();
            
        }

        private void Graficadecinturones_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;
            string fechaparasql = myDateTime.ToString("yyyy-MM-dd");
            
            if (fechaparasql==Fechadatatimer.Value.ToString("yyyy-MM-dd"))
            {
                creargrafica("Select rango from discipulos group by rango","select count(*) from discipulos group by rango","rango");
            }
            else
            {
                creargrafica("SELECT nuevo_rango FROM rango_obtenido WHERE idexamen=(SELECT idexamen from examenes WHERE fecha<='" + Fechadatatimer.Text + "' LIMIT 1) GROUP BY nuevo_rango", "SELECT COUNT(*) FROM rango_obtenido WHERE idexamen=(SELECT idexamen from examenes WHERE fecha<='" + Fechadatatimer.Text + "' LIMIT 1) GROUP BY nuevo_rango","nuevo_rango");
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {

        }

        private void btnvolveruserprofile_Click(object sender, EventArgs e)
        {
            new Principal("Adm").Show();
            this.Dispose();
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
    }
} 

