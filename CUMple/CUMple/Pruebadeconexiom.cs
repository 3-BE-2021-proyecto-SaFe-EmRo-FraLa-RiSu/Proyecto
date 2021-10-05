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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Graficadealumnos_Click_1(object sender, EventArgs e)
        {

        }

        private void comboxmeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graficadealumnos.Series["Asistencias"].Points.Clear();
            Graficadealumnos.Series["Faltas"].Points.Clear();
            int mesesindex = cmbmeses.SelectedIndex, meses;
            meses = mesesindex + 1;
            creargrafica("Asistencias", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=1 and month(fecha)='" + meses + "' and concurre=1 group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and month(fecha)='" + meses + "' and concurre=1 group by v.idclase;");
            creargrafica("Faltas", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=1 and month(fecha)='" + meses + "' and concurre=0 group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and month(fecha)='" + meses + "' and concurre=0 group by v.idclase;");

          
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
