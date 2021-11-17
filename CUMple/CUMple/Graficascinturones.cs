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
            Graficadecinturones.Series["rango"].Points.Clear();
        }
        private void btncargarcinturones_Click(object sender, EventArgs e)
        {
            cargargrafica();
        }

        public void creargrafica(string rangos, string leercant_alumnos)
        {
            MySqlCommand comandoleeralumnos = new MySqlCommand(leercant_alumnos, conexionprograma);
            MySqlDataReader lectordedatoscinturones;
            MySqlCommand comandoleerrangos = new MySqlCommand(rangos, conexionprograma2);
            MySqlDataReader lectorderangos;
            Graficadecinturones.Series["rango"].Points.Clear();
            conexionprograma.Open();
            conexionprograma2.Open();
            try
            {            
              
                lectordedatoscinturones = comandoleeralumnos.ExecuteReader();
                lectorderangos = comandoleerrangos.ExecuteReader();
                while (lectordedatoscinturones.Read() && lectorderangos.Read())
                {
                    Graficadecinturones.Series["rango"].Points.AddXY(lectorderangos.GetString("nuevo_rango"), lectordedatoscinturones.GetInt32("COUNT(*)"));
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
            if (fechaparasql==Fechadatatimer.Value.ToString())
            {
           
            }
            else
            {
                
                creargrafica("SELECT nuevo_rango FROM rango_obtenido WHERE idexamen=(SELECT idexamen from examenes WHERE fecha<='" + Fechadatatimer.Text + "' LIMIT 1) GROUP BY nuevo_rango", "SELECT COUNT(*) FROM rango_obtenido WHERE idexamen=(SELECT idexamen from examenes WHERE fecha<='" + Fechadatatimer.Text + "' LIMIT 1) GROUP BY nuevo_rango");
            }
            
            
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {

        }

        private void btnvolveruserprofile_Click(object sender, EventArgs e)
        {
            new Principal(true).Show();
            this.Dispose();
        }
    }
} 

