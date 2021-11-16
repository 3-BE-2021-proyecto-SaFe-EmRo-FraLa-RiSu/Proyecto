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
        public Graficascinturones()
        {
            InitializeComponent();
        }
        public void limpiargrafica()
        {
            Graficadecinturones.Series["Cinturones"].Points.Clear();
        }
        private void btncargarcinturones_Click(object sender, EventArgs e)
        {
            cargargrafica();
        }

        public void creargrafica(string rangos, string leercant_alumnos)
        {
        MySqlCommand comandoleertaekwondo = new MySqlCommand(leercant_alumnos, conexionprograma);
        MySqlDataReader lectordedatoscinturones;
            try
            {            
                conexionprograma.Open();
                lectordedatoscinturones = comandoleertaekwondo.ExecuteReader();
                while (lectordedatoscinturones.Read())
                {
                    Graficadecinturones.Series[rangos].Points.AddXY(lectordedatoscinturones.GetString("Cinturones"));
                }
                conexionprograma.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Graficascinturones_Load(object sender, EventArgs e)
        {

        }
        
        private void dtpfec_nac_ValueChanged(object sender, EventArgs e)
        {
            cargargrafica();
        }

        public void cargargrafica() 
        {
            limpiargrafica();
            creargrafica("Cinturones", "select nomcompleto, nuevo_rango, fecha from discipulos d join rango_obtenido r on d.cedula = r.cedula join examenes e on r.idexamen = e.idexamen where fecha <= '" + dtpfecha.Text + "' group by nomcompleto;");
        }
    }
} 

