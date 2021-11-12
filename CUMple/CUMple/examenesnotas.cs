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
        private void comboboxcedula()
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
            comboboxcedula();
            comboboxidactualizado();
            dgvexamenes.DataSource=cargarexamenes(idexamen1);
        
        }

        private void cbidexamen_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvexamenes.Refresh();
            dgvexamenes.DataSource = cargarexamenes(cbidexamen.SelectedItem.ToString());
         
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cbcedula.SelectedIndex != -1 && txbnota.Text != "" && cbrango.SelectedIndex != -1 && cbidexamen.SelectedIndex!=-1)
            {
                string rango=cbrango.SelectedItem.ToString();
                string cedula = cbcedula.SelectedItem.ToString();
                int nota = Int32.Parse(txbnota.Text);
             
             

                foreach (DataGridViewRow filas in dgvexamenes.Rows)
                {
                              
                    if (cedula == Convert.ToString(filas.Cells["cedula"].Value))
                    {
                        MessageBox.Show("El alumno ya fue creado");
                        break;
                    }
                    else
                    {

                      
                        if ((nota > 0 && nota<=90))
                        {
                            conexionbd.Open();
                            string comando = "insert into rango_obtenido values(" + nota + ",'" + rango + "'," + cbidexamen.SelectedItem.ToString() + ",'" + cedula + "');";
                            MySqlCommand comandoingresarexamenes = new MySqlCommand(comando, conexionbd);
                            comandoingresarexamenes.ExecuteNonQuery();
                            MessageBox.Show("Se agrego correctamente el examen");
                            conexionbd.Close();                           
                            dgvexamenes.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("La nota debe estar entre 90 y 0");
                        }
                        break;
                    }
                }
                
                    
               
              
              
             
              

             

            }

            else
            {
                MessageBox.Show("Los datos no se han podido ingresar correctamente." +
                    "Asegurese que todas las casillas estan con datos ingresados y que ningún id este seleccionado.");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
