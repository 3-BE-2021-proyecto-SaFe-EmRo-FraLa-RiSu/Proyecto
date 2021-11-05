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
    public partial class examenesnotas : Form
    {
        public examenesnotas(string idexamenobtenido)
        {
            InitializeComponent();
            idexamen1 = idexamenobtenido;
        }
        string idexamen1;
        MySqlConnection conexionbd = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        private DataTable cargarexamenes(string idexamenx)
        {

            DataTable dtexamenes = new DataTable();
            string comandostring = "select * from rango_obtenido where idexamen="+idexamenx+";";
            MySqlDataAdapter comandotraernotas = new MySqlDataAdapter(comandostring, conexionbd);
            try
            {
                conexionbd.Open();
                comandotraernotas.Fill(dtexamenes);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
             conexionbd.Close();
             return dtexamenes;
        }
        private void comboboxidactualizado()
        {
            MySqlDataReader lectordedatos;
            string comand = "Select idexamen from rango_obtenido;";
            conexionbd.Open();
            MySqlCommand comando = new MySqlCommand(comand, conexionbd);
            lectordedatos = comando.ExecuteReader();
            while (lectordedatos.Read())
            {
                cbidexamen.Items.Add(lectordedatos["idexamen"].ToString());
            }
            conexionbd.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void examenesnotas_Load(object sender, EventArgs e)
        {
            comboboxidactualizado();
            dgvexamenes.DataSource=cargarexamenes(idexamen1);
        
        }

        private void cbidexamen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cbcedula.SelectedIndex != -1 && txbnota.Text != "" && cbrango.SelectedIndex != -1 && cbidexamen.SelectedIndex==-1)
            {
                string rango=cbrango.SelectedItem.ToString();
                string cedula = cbcedula.SelectedItem.ToString();

             


                conexionbd.Open();
                string comando = "insert into rango_obtenido (notas,nuevo_rango,cedula) values('" + txbnota.Text + "','" + rango + "','"+ cedula+ "');";
                MySqlCommand comandoingresarexamenes = new MySqlCommand(comando, conexionbd);
                comandoingresarexamenes.ExecuteNonQuery();
                MessageBox.Show("Se agrego correctamente el examen");               
                conexionbd.Close();
                cbidexamen.Items.Clear();
                comboboxidactualizado();
               
            }

            else
            {
                MessageBox.Show("Los datos no se han podido ingresar correctamente." + "\nAsegurese que todas las casillas estan con datos ingresados y que ningún id este seleccionado");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
