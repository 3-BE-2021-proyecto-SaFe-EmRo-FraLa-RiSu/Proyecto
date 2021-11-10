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
    public partial class Examenesfrm : Form
    {
        MySqlConnection conexionbd = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");

        public Examenesfrm()
        {
            InitializeComponent();

        }

        public void editarexamen(string columna, string datonuevo, int idexamen)
        {

            conexionbd.Open();
            string comando = "update examenes set " + columna + "='"+datonuevo+"' where idexamen="+idexamen+";";
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
            dgvexamenes.DataSource= cargarexamenes();

          
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
        private DataTable cargarexamenes()
        {
            
            DataTable dtexamenes = new DataTable();
            string comandostring = "select * from examenes;";
            MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring,conexionbd);
            try
            {
                conexionbd.Open();
                comandotraerexamenes.Fill(dtexamenes);
           
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
            }
          
             
        
            conexionbd.Close();
            return dtexamenes;
        }
     

        private void Examenesfrm_Load(object sender, EventArgs e)
        {
            Fechadatatimer.Enabled = false;
            horadatatimer.Enabled = false;
            dgvexamenes.DataSource=cargarexamenes();
            comboboxidactualizado();
            if (cbidexamen.SelectedIndex == -1)
            {

                btnagregar.Enabled = true;
                btneditar.Enabled = false;
                btneliminar.Enabled = false;
            }
            else
            {
                btnagregar.Enabled = false;
                btneditar.Enabled = true;
                btneliminar.Enabled = true;

            }
        }

        private void dgvexamenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex>-1)
            {
                DataGridViewRow filas = this.dgvexamenes.Rows[e.RowIndex];
                string id = filas.Cells[4].Value.ToString();
                new examenesnotas(id).Show();
            }
            
          
            
        }

       public void limpiar()
        {
            cbidexamen.SelectedIndex = -1;
            cbdisciplina.SelectedIndex = -1;
            txbexaminadores.Text = "";
            Fechadatatimer.ResetText();
            horadatatimer.ResetText();
            cbhabhora.Checked = false;
            cbhabfe.Checked = false;
            
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
          

            if(cbidexamen.SelectedIndex !=-1 ) {
                int idselecionado = Int32.Parse(cbidexamen.SelectedItem.ToString());
                if (cbdisciplina.SelectedIndex!=-1)
            {
                editarexamen("disciplina", cbdisciplina.SelectedItem.ToString(), idselecionado);
            }
            if (txbexaminadores.Text != "")
            {
                editarexamen("examinadores", txbexaminadores.Text, idselecionado);
            }
            if (Fechadatatimer.Enabled == true)
                {
                editarexamen("fecha", Fechadatatimer.Text, idselecionado);
            }
            if (horadatatimer.Enabled == true )
            {
                editarexamen("hora", horadatatimer.Text, idselecionado);
            }
                MessageBox.Show("El examén se ha editado de manera correcta");
                limpiar();
            }
          
        }
           
        private void cbidexamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbidexamen.SelectedIndex==-1)
            {

                btnagregar.Enabled = true;
                btneditar.Enabled = false;
                btneliminar.Enabled = false;
            }
            else
            {
                btnagregar.Enabled = false;
                btneditar.Enabled = true;
                btneliminar.Enabled = true;

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            if (cbdisciplina.SelectedIndex!=-1 && txbexaminadores.Text!="" && cbidexamen.SelectedIndex==-1)
            {
                string disciplina = cbdisciplina.SelectedItem.ToString();
               
                MessageBox.Show(Fechadatatimer.Text);
               

                conexionbd.Open();
                string comando = "insert into examenes (disciplina,examinadores,fecha,hora) values('"+disciplina+"','"+txbexaminadores.Text+"','"+Fechadatatimer.Text+"','"+horadatatimer.Text+"');";
                MySqlCommand comandoingresarexamenes = new MySqlCommand(comando,conexionbd);
                comandoingresarexamenes.ExecuteNonQuery();
                MessageBox.Show("Se agrego correctamente el examen");
                limpiar();
                conexionbd.Close();
                cbidexamen.Items.Clear();
                comboboxidactualizado();
                dgvexamenes.DataSource = cargarexamenes();
            }

            else
            {
                MessageBox.Show("Los datos no se han podido ingresar correctamente."+"\nAsegurese que todas las casillas estan con datos ingresados y que ningún id este seleccionado");
            }
           
        }

        private void btnvolverexamenes_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Dispose();
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
                limpiar();
                conexionbd.Close();
                cbidexamen.Items.Clear();
                comboboxidactualizado();
                dgvexamenes.DataSource = cargarexamenes();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una id a la cual borrar");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            dgvexamenes.DataSource = cargarexamenes();
        }

        private void cbdisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void horadatatimer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbhabfe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhabfe.Checked==true)
            {
                Fechadatatimer.Enabled = true;
            }
            else
            {
                Fechadatatimer.Enabled = false;
            }
        }

        private void cbhabhora_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhabhora.Checked == true)
            {
                horadatatimer.Enabled = true;
            }
            else
            {
                horadatatimer.Enabled = false;
            }
        }

        private void rata_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbbuscar_Click(object sender, EventArgs e)
        {                
            DataTable dtexamenes = new DataTable();

            if (cbidexamen.SelectedIndex != -1 && cbdisciplina.SelectedIndex==-1 && Fechadatatimer.Enabled==false && horadatatimer.Enabled==false && txbexaminadores.Text=="")
            {
                string comandostring = "select * from examenes where idexamen='"+cbidexamen.SelectedItem+"';";
                MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);
              
                try
                {
                   conexionbd.Open();
                    dgvexamenes.DataSource = null;
                    comandotraerexamenes.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        conexionbd.Close();
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                    }
                    else
                    {

                        MessageBox.Show("Se encontro el exámen de manera correcta");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
              
                limpiar();
            }

            else if(cbidexamen.SelectedIndex == -1 && cbdisciplina.SelectedIndex != -1 && Fechadatatimer.Enabled == false && horadatatimer.Enabled == false && txbexaminadores.Text == "")
            {
                string comandostring = "select * from examenes where disciplina='" + cbdisciplina.SelectedItem.ToString() + "';";
                MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

                try
                {
                    conexionbd.Open();
                    dgvexamenes.DataSource = null;
                    comandotraerexamenes.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;

                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                    }
                    else
                    {

                        MessageBox.Show("Se encontro el exámen de manera correcta");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                limpiar();
            }

            else if (cbidexamen.SelectedIndex == -1 && cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == true && horadatatimer.Enabled == false && txbexaminadores.Text == "")
            {
                string comandostring = "select * from examenes where fecha='" + Fechadatatimer.Text + "';";
                MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

                try
                {
                    conexionbd.Open();
                    dgvexamenes.DataSource = null;
                    comandotraerexamenes.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                    }
                    else
                    {

                        MessageBox.Show("Se encontro el exámen de manera correcta");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                limpiar();
            }

            else if (cbidexamen.SelectedIndex == -1 && cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == false && horadatatimer.Enabled == true && txbexaminadores.Text == "")
            {
                string comandostring = "select * from examenes where hora='" + horadatatimer.Text + "';";
                MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

                try
                {
                    conexionbd.Open();
                    dgvexamenes.DataSource = null;
                    comandotraerexamenes.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                    }
                    else
                    {                 
                        MessageBox.Show("Se encontro el exámen de manera correcta");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                limpiar();
            }
            else if (cbidexamen.SelectedIndex == -1 && cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == false && horadatatimer.Enabled == false && txbexaminadores.Text != "")
            {
                string comandostring = "select * from examenes where examinadores='" + txbexaminadores.Text + "';";
                MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

                try
                {
                    conexionbd.Open();
                    dgvexamenes.DataSource = null;
                    comandotraerexamenes.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                    }
                    else
                    {

                        MessageBox.Show("Se encontro el exámen de manera correcta");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                limpiar();
            }
            else if (cbidexamen.SelectedIndex == -1 && cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == true && horadatatimer.Enabled == false && txbexaminadores.Text != "")
            {
                string comandostring = "select * from examenes where examinadores='" + txbexaminadores.Text + "' and fecha='"+Fechadatatimer.Text+"';";
                MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

                try
                {
                    conexionbd.Open();
                    dgvexamenes.DataSource = null;
                    comandotraerexamenes.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                    }
                    else
                    {

                        MessageBox.Show("Se encontro el exámen de manera correcta");


                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                limpiar();
            }

            else if (cbidexamen.SelectedIndex == -1 && cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == true && horadatatimer.Enabled == true && txbexaminadores.Text == "")
            {
                string comandostring = "select * from examenes where fecha='"+Fechadatatimer.Text+"' and hora='"+horadatatimer.Text+"';";
                MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

                try
                {
                    conexionbd.Open();
                    dgvexamenes.DataSource = null;
                    comandotraerexamenes.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                    }
                    else
                    {

                        MessageBox.Show("Se encontro el exámen de manera correcta");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                limpiar();
            }
            else
            {
                MessageBox.Show("Solo puede seleccionar un elemento o"+"\n buscar un examinador y una fecha. O una fecha y una hora");
            }




            conexionbd.Close();


        }

    }
        }
    

