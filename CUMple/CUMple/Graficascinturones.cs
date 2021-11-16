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
            if (cmbanoscinturones.SelectedItem != null && cmbanoscinturones.SelectedItem.ToString() != "Ninguno" && cmbmesescinturones.SelectedItem != null && cmbmesescinturones.SelectedItem.ToString() != "Ninguno")
            {
                limpiargrafica();
                int mesesindex = cmbmesescinturones.SelectedIndex, meses, años = Int32.Parse(cmbmesescinturones.SelectedItem.ToString());
                meses = mesesindex + 1;
                creargrafica("Cinturones", "select count(*)'Cinturones', ");//consulta mysql
            }
            else if (cmbanoscinturones.SelectedItem == null || cmbanoscinturones.SelectedItem.ToString() == "Ninguno")
            {
                int mesesindex = cmbmesescinturones.SelectedIndex, meses;
                meses = mesesindex + 1;
                buscarsolomes(meses);
            }
            else if (cmbmesescinturones.SelectedItem == null || cmbmesescinturones.SelectedItem.ToString() == "Ninguno")
            {
                buscarsoloaño(Int32.Parse(cmbmesescinturones.SelectedItem.ToString()));
            }
        }

        public void buscarsolomes(int meses) 
        {
            limpiargrafica();
            creargrafica("","");
        }
        public void buscarsoloaño(int año)
        {
            limpiargrafica();
            creargrafica("Cinturones", "");
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
                throw;
            }
        }
        private void Graficascinturones_Load(object sender, EventArgs e)
        {
            cmbanoscinturones.Items.Add("Ninguno");
            MySqlDataReader lectordedatos;
            string comand = "Select year(fecha) from examenes group by year(fecha);";
            conexionprograma.Open();
            MySqlCommand comando = new MySqlCommand(comand, conexionprograma);
            lectordedatos = comando.ExecuteReader();
            while (lectordedatos.Read())
            {
                cmbanoscinturones.Items.Add(lectordedatos["year(fecha)"].ToString());
            }
            conexionprograma.Close();
        }
    }
}
