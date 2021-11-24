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

    public partial class Misasistencias : Form
    {
        string cedulaporagarrar;
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=alumno; pwd=alumnocontraseña;");
        MySqlConnection conexionprograma2 = new MySqlConnection("Server=localhost; Database=programa; uid=alumno; pwd=alumnocontraseña;");
        public Misasistencias(string cedula)
        {
            InitializeComponent();
            cedulaporagarrar = cedula;
        }
        public void limpiargrafica()
        {
            Graficadealumnos.Series["Asistencias"].Points.Clear();
            Graficadealumnos.Series["Faltas"].Points.Clear();

        }
        public void creargrafica(string series, string strleertkd, string strleerkrav)
        {
            conexionprograma.Open();
            conexionprograma2.Open();
            MySqlCommand comandoparagraficataekwondo = new MySqlCommand(strleertkd, conexionprograma); //Asistencias
            MySqlCommand comandoparagraficakrav = new MySqlCommand(strleerkrav, conexionprograma2); //Faltas
            MySqlDataReader lectordedatostkd = comandoparagraficataekwondo.ExecuteReader();
            MySqlDataReader lectordedatoskrav = comandoparagraficakrav.ExecuteReader();
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
        private void btnvolverpruebaconexion_Click(object sender, EventArgs e)
        {
            new Principal("Alm", cedulaporagarrar).Show();
        }
        public void buscarsolomes(int mes)
        {
            limpiargrafica();
            int mesesindex = cmbmeses.SelectedIndex, meses;
            meses = mesesindex + 1;
            creargrafica("Asistencias", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where concurre=1 and month(fecha)='" + meses + "' group by YEAR(fecha);", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where concurre=1 and month(fecha)='" + meses + "' group by YEAR(fecha);");
            creargrafica("Faltas", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where concurre=0 and month(fecha)='" + meses + "' group by YEAR(fecha);", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where concurre=0 and month(fecha)='" + meses + "' group by YEAR(fecha);");
        }
        public void buscarsoloaño(int ano)
        {
            limpiargrafica();
            creargrafica("Asistencias", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where concurre=1 and year(fecha)='" + ano + "' group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where concurre=1 and year(fecha)='" + ano + "' group by v.idclase;");
            creargrafica("Faltas", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where concurre=0 and year(fecha)='" + ano + "' group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where concurre=0 and year(fecha)='" + ano + "' group by v.idclase;");
        }
        private void btncargardatos_Click(object sender, EventArgs e)
        {
            if (cmbAño.SelectedIndex != -1 && cmbAño.SelectedItem.ToString() != "Ninguno" && cmbmeses.SelectedIndex != -1 && cmbmeses.SelectedItem.ToString() != "Ninguno")
            {
                limpiargrafica();
                int mesesindex = cmbmeses.SelectedIndex, años = Int32.Parse(cmbAño.SelectedItem.ToString());


                MessageBox.Show(mesesindex.ToString());

                creargrafica("Asistencias", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase an month(fecha)='" + mesesindex + "' and year(fecha)='" + años + "' and concurre=1 group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and month(fecha)='" + mesesindex + "' and year(fecha)='" + años + "' and concurre=1 group by v.idclase;");
                creargrafica("Faltas", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=1 and month(fecha)='" + mesesindex + "' and year(fecha)='" + años + "' and concurre=0 group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where v.idclase=5 and month(fecha)='" + mesesindex + "' and year(fecha)='" + años + "' and concurre=0 group by v.idclase;");

                creargrafica("Asistencias", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where month(fecha)='" + mesesindex + "' and year(fecha)='" + años + "' and concurre=1 group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where month(fecha)='" + mesesindex + "' and year(fecha)='" + años + "' and concurre=1 group by v.idclase;");
                creargrafica("Faltas", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where month(fecha)='" + mesesindex + "' and year(fecha)='" + años + "' and concurre=0 group by v.idclase;", "select count(*)'Asistencia',tipos,fecha from discipulos d join van v on d.cedula=v.cedula join clase c on v.idclase=c.idclase where month(fecha)='" + mesesindex + "' and year(fecha)='" + años + "' and concurre=0 group by v.idclase;");

            }
            else if (cmbAño.SelectedIndex == -1 || cmbAño.SelectedItem.ToString() == "Ninguno")
            {
                int mesesindex = cmbmeses.SelectedIndex, meses;
                meses = mesesindex + 1;
                buscarsolomes(meses);
            }
            else if (cmbmeses.SelectedIndex == -1 || cmbmeses.SelectedItem.ToString() == "Ninguno")
            {
                buscarsoloaño(Int32.Parse(cmbAño.SelectedItem.ToString()));
            }
            if (Graficadealumnos.Series["Asistencias"].Points.Count == 0 && Graficadealumnos.Series["Faltas"].Points.Count == 0)
            {
                MessageBox.Show("No hay datos de este mes.");
            }

        }

        private void Misasistencias_Load(object sender, EventArgs e)
        {
            cmbAño.Items.Add("Ninguno");
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
    }
}
