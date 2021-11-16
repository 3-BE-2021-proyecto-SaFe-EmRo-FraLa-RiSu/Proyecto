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
            try
            {            
                conexionprograma.Open();
                conexionprograma2.Open();
                lectordedatoscinturones = comandoleeralumnos.ExecuteReader();
                lectorderangos = comandoleerrangos.ExecuteReader();
                while (lectordedatoscinturones.Read() && lectorderangos.Read())
                {
                    Graficadecinturones.Series["rango"].Points.AddXY(lectorderangos.GetString("rango"), lectordedatoscinturones.GetInt32("Alumnos"));
                }
                conexionprograma.Close();
                conexionprograma2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            creargrafica("select rango from discipulos group by rango", "select count(*)'Alumnos' from discipulos group by rango");
        }
    }
} 

