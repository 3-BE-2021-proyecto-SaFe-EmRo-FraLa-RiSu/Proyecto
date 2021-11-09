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
        private void comboboxidactualizado()
        {
            MySqlDataReader lectordedatos;
            string comand = "Select idexamen from examenes;";
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
            comboboxidactualizadocedula();
            dgvexamenes.DataSource=cargarexamenes(idexamen1);
            
        }

        public void editarexamen(string columna, string datonuevo, int idexamen,string cedula, string columna2)
        {

            conexionbd.Open();
            string comando = "update rango_obtenido set " + columna + "='" + datonuevo + "' where idexamen=" + idexamen + " and " + columna2 + "='" + cedula + "' ;";
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
            string id = cbidexamen.SelectedItem.ToString();
           dgvexamenes.DataSource=cargarexamenes(id);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cbcedula.SelectedIndex != -1 && txbnota.Text != "" && cbrango.SelectedIndex != -1 && cbidexamen.SelectedIndex!=-1)
            {
                string rango=cbrango.SelectedItem.ToString();
                string cedula = cbcedula.SelectedItem.ToString();


                bool alumnoyacreado = true;

                conexionbd.Open();
                for (int i = 0; i < dgvexamenes.RowCount-1; i++)
                {
                    if(dgvexamenes.Rows[i].Cells[3].Value.ToString()==cedula)
                    {
                        MessageBox.Show("No se puede agregar a un alumno dos veces a un exámen");
                    }
                    else {
                        alumnoyacreado = false;
                    }
                }
                if (alumnoyacreado == false)
                {
                    string comando = "insert into rango_obtenido values('" + txbnota.Text + "','" + rango + "'," + cbidexamen.SelectedItem.ToString() + ",'" + cedula + "');";
                    MySqlCommand comandoingresarexamenes = new MySqlCommand(comando, conexionbd);
                    comandoingresarexamenes.ExecuteNonQuery();
                    MessageBox.Show("Se agrego correctamente el examen");
                }
                   
                conexionbd.Close();
               
             
               
            }

            else
            {
                MessageBox.Show("Los datos no se han podido ingresar correctamente." + "\nAsegurese que todas las casillas estan con datos ingresados o que los datos sean validos y que ningún id este seleccionado");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (cbcedula.SelectedIndex != -1 && txbnota.Text != "" && cbrango.SelectedIndex != -1 && cbidexamen.SelectedIndex != -1)
            {
                conexionbd.Open();
                int id = Int32.Parse(cbidexamen.SelectedItem.ToString());
                string comandostring = "delete * from rango_obtenido where idexamen=" + id + " and cedula='"+cbcedula.SelectedItem.ToString()+"'";
                MySqlCommand comandoborrarexamenes = new MySqlCommand(comandostring, conexionbd);
                comandoborrarexamenes.ExecuteNonQuery();
                MessageBox.Show("Se elimino correctamente el examen");
                conexionbd.Close();
                dgvexamenes.Rows.Clear();
                dgvexamenes.DataSource = cargarexamenes(id.ToString());
            }
            else
            {
                MessageBox.Show("Debe seleccionar un id y una cédula para borrar al alumno");
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
                    
                
                }

                if (cbrango.SelectedIndex!=1 && cbcedula.SelectedIndex != 1 )
                {
                    string rango = cbrango.SelectedItem.ToString();
                    string cedula = cbcedula.SelectedItem.ToString();


                
                            editarexamen("nuevo_rango", rango, idselecionado ,cedula,"cedula");
                    
                   
                }

                if(txbnota.Text!="")
                {
                    int nota = Int32.Parse(txbnota.Text);
                
                if(nota>0 && nota<=90)
                {
                    string cedula = cbidexamen.SelectedItem.ToString();

                        MessageBox.Show(nota.ToString());              
                editarexamen("notas", txbnota.Text,idselecionado, cedula, "cedula");                                                     
                  
                }
                   
                }
                MessageBox.Show("El examén se ha editado de manera correcta");
                dgvexamenes.DataSource = cargarexamenes(idselecionado.ToString());
            }
    }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            DataTable dtexamenes = new DataTable();

            if (cbidexamen.SelectedIndex != -1 && cbrango.SelectedIndex != -1 && txbnota.Text != "" && cbcedula.SelectedIndex!=-1)
            {
                string comandostring = "select * from rango_obtenido where idexamen=" + cbidexamen.SelectedItem.ToString() + " and cedula='"+cbcedula.SelectedItem.ToString()+"' and nuevo_rango='"+cbrango.SelectedItem.ToString()+"'";
                MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

                try
                {
                    conexionbd.Open();
                    dgvexamenes.DataSource = null;
                    comandotraerexamenes.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    MessageBox.Show("Se encontro el exámen de manera correcta");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                
            }








            conexionbd.Close();
        }
    }
}
