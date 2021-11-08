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
  
        private void comboboxidactualizadocedula()
        {
            MySqlDataReader lectordedatos;
            string comand = "Select cedula from discipulos;";
            conexionbd.Open();
            MySqlCommand comando = new MySqlCommand(comand, conexionbd);
            lectordedatos = comando.ExecuteReader();
            while (lectordedatos.Read())
            {
                cbcedula.Items.Add(lectordedatos["cedula"].ToString());
            }
            conexionbd.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void examenesnotas_Load(object sender, EventArgs e)
        {
          
            comboboxidactualizadocedula();
            dgvexamenes.DataSource=cargarexamenes(idexamen1);
        
        }

        public void editarexamen(string columna, string datonuevo,string datoacambiar, int idexamen)
        {

            conexionbd.Open();
            string comando = "update rango_obtenido set " + columna + "='" + datonuevo + "' where idexamen=" + idexamen + " and "+columna+"='"+datoacambiar+"';";
            MySqlCommand comandoeditarusuario = new MySqlCommand(comando, conexionbd);
            try
            {
                comandoeditarusuario.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
            conexionbd.Close();
            dgvexamenes.DataSource = cargarexamenes(idexamen.ToString());


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
             
               
            }

            else
            {
                MessageBox.Show("Los datos no se han podido ingresar correctamente." + "\nAsegurese que todas las casillas estan con datos ingresados o que los datos sean validos y que ningún id este seleccionado");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (cbidexamen.SelectedIndex != -1)
            {
                conexionbd.Open();
                int id = Int32.Parse(cbidexamen.SelectedItem.ToString());
                string comandostring = "delete from examenes where idexamen=" + id + "";
                MySqlCommand comandoborrarexamenes = new MySqlCommand(comandostring, conexionbd);
                comandoborrarexamenes.ExecuteNonQuery();
                MessageBox.Show("Se elimino correctamente el examen");
                conexionbd.Close();
                cbidexamen.Items.Clear();
             
                dgvexamenes.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una id a la cual borrar");
            }
        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void txbnota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            if (cbidexamen.SelectedIndex != -1)
            {
                int idselecionado = Int32.Parse(cbidexamen.SelectedItem.ToString());
              
               
                if (cbcedula.SelectedIndex!=1)
                {
                    string cedula = cbidexamen.SelectedItem.ToString();
                    editarexamen("cedula", cedula,"",idselecionado);
                
                }

                if (cbrango.SelectedIndex!=1)
                {
                    string rango = cbrango.SelectedItem.ToString();
                    editarexamen("nuevo_rango", rango, "", idselecionado);
                }

                if(txbnota.Text!="")
                {

                    editarexamen("notas", txbnota.Text, "", idselecionado);
                }
                MessageBox.Show("El examén se ha editado de manera correcta");
            }
        }
    }
}
