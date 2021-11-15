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
        int id;
        public void buscarexamenes()

        {
        

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
          
        }

        private void dgvexamenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
            
            
          
            
        }

       public void limpiar()
        {
            
            cbdisciplina.SelectedIndex = -1;
            txbexaminadores.Text = "";
            Fechadatatimer.ResetText();
            horadatatimer.ResetText();
            cbhabhora.Checked = false;
            cbhabfe.Checked = false;
            
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
           
            if (cbdisciplina.SelectedIndex!=-1)
            {
                editarexamen("disciplina", cbdisciplina.SelectedItem.ToString(), id);
            }
            if (txbexaminadores.Text != "")
            {
                editarexamen("examinadores", txbexaminadores.Text, id);
            }
            if (Fechadatatimer.Enabled == true)
                {
                editarexamen("fecha", Fechadatatimer.Text, id);
            }
            if (horadatatimer.Enabled == true )
            {
                editarexamen("hora", horadatatimer.Text, id);
            }
                MessageBox.Show("El examén se ha editado de manera correcta");
                limpiar();
            

        }
               
        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            if (cbdisciplina.SelectedIndex!=-1 && txbexaminadores.Text!="" && Fechadatatimer.Enabled==true && horadatatimer.Enabled==true)
            {
                string disciplina = cbdisciplina.SelectedItem.ToString();

                conexionbd.Open();
                for (int i = 0; i < dgvexamenes.RowCount-1; i++)
                {
               
                   
                   
                    if (horadatatimer.Value != DateTime.Parse(dgvexamenes.Rows[i].Cells["colhora"].Value.ToString()))
                    {
                            string comando = "insert into examenes (disciplina,examinadores,fecha,hora) values('" + disciplina + "','" + txbexaminadores.Text + "','" + Fechadatatimer.Text + "','" + horadatatimer.Text + "');";
                            MySqlCommand comandoingresarexamenes = new MySqlCommand(comando, conexionbd);
                            comandoingresarexamenes.ExecuteNonQuery();
                            limpiar();
                          
                            conexionbd.Close();
                            dgvexamenes.DataSource = cargarexamenes();
                     
                      
                        return;

                    }
                  
                }
                MessageBox.Show("El exámen con los datos que quiere crear ya existe");
                conexionbd.Close();




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
           
            if (txbexaminadores.Text!="" && cbdisciplina.SelectedIndex!=-1 && Fechadatatimer.Enabled==true && horadatatimer.Enabled==true)
            {
                conexionbd.Open();
          
                
                for (int i = 0; i < dgvexamenes.RowCount-1; i++)
                {
                    if (txbexaminadores.Text == dgvexamenes.Rows[i].Cells["colexaminadores"].Value.ToString() && cbdisciplina.SelectedItem.ToString()==dgvexamenes.Rows[i].Cells["coldisciplina"].Value.ToString() && Fechadatatimer.Value== DateTime.Parse(dgvexamenes.Rows[i].Cells["colfecha"].Value.ToString()) && horadatatimer.Value== DateTime.Parse(dgvexamenes.Rows[i].Cells["colhora"].Value.ToString()))
                    {
                        string comandostring = "delete from examenes where idexamen="+ dgvexamenes.Rows[i].Cells["colidexamen"].Value.ToString() + "";
                        MySqlCommand comandoborrarexamenes = new MySqlCommand(comandostring, conexionbd);
                        comandoborrarexamenes.ExecuteNonQuery();
                        limpiar();
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        return;
                    }
                }
                conexionbd.Close();
                MessageBox.Show("No se encontro el exámen el cual se quiere borrar");
               
            }
            else
            {
                MessageBox.Show("Todas las casillas deben de tener datos seleccionados");
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

            string disciplina,comandodisciplina="";
            string examinadores, comandoexamenes="";
            string fecha, comandofecha="";
            string hora, comandohora="";

            if (cbdisciplina.SelectedIndex!=-1)
            {
               disciplina=cbdisciplina.SelectedItem.ToString();
               comandodisciplina=" disciplina='"+disciplina+"'";
            }
            if (txbexaminadores.Text!="")
            {
                examinadores = txbexaminadores.Text;
                comandoexamenes = " examinadores='"+examinadores+"'";
            }

            if (Fechadatatimer.Enabled !=false)
            {
                fecha = Fechadatatimer.Text;

               comandofecha = " fecha='" + fecha + "'";
                
            }

            if (horadatatimer.Enabled != false)
            {
                hora = horadatatimer.Text;
                comandohora = " hora='"+hora+"'";
            }

            conexionbd.Open();

            for (int i = 0; i < dgvexamenes.RowCount-1; i++)
            {
                if (cbdisciplina.SelectedIndex!=-1 && Fechadatatimer.Enabled == false && horadatatimer.Enabled == false && txbexaminadores.Text == "")
                {
                    MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from examenes where"+comandodisciplina+"",conexionbd);
                    dgvexamenes.Refresh();
                    comandobuscar.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                        return;
                    }
                    conexionbd.Close();
                    return;
                }
               else if (txbexaminadores.Text!="" && Fechadatatimer.Enabled == false && horadatatimer.Enabled == false && cbdisciplina.SelectedIndex==-1)
                {
                    MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from examenes where" + comandoexamenes+ "", conexionbd);
                    dgvexamenes.Refresh();
                    comandobuscar.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                        return;
                    }
                    conexionbd.Close();
                    return;
                }
              else  if (txbexaminadores.Text == "" && Fechadatatimer.Enabled != false && horadatatimer.Enabled == false && cbdisciplina.SelectedIndex == -1)
                {
             
                    MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from examenes where" + comandofecha + "", conexionbd);
                    dgvexamenes.Refresh();
                    comandobuscar.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                        return;
                    }
                    conexionbd.Close();
                    return;
                }
               else if (txbexaminadores.Text == "" && Fechadatatimer.Enabled == false && horadatatimer.Enabled != false && cbdisciplina.SelectedIndex == -1)
                {
                    MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from examenes where" + comandohora + "", conexionbd);
                    dgvexamenes.Refresh();
                    comandobuscar.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                        return;
                    }
                    conexionbd.Close();
                    return;
                }

                else if (txbexaminadores.Text == "" && Fechadatatimer.Enabled != false && horadatatimer.Enabled != false && cbdisciplina.SelectedIndex == -1)
                {
                    MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from examenes where" + comandohora + " and"+comandofecha+"", conexionbd);
                    dgvexamenes.Refresh();
                    comandobuscar.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                        return;
                    }
                    conexionbd.Close();
                    return;
                }

                else if (txbexaminadores.Text != "" && Fechadatatimer.Enabled != false && horadatatimer.Enabled != false && cbdisciplina.SelectedIndex == -1)
                {
                    MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from examenes where" + comandohora + " and" + comandofecha + " and"+comandoexamenes+"", conexionbd);
                    dgvexamenes.Refresh();
                    comandobuscar.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                        return;
                    }
                    conexionbd.Close();
                    return;
                }
                else if (txbexaminadores.Text != "" && Fechadatatimer.Enabled != false && horadatatimer.Enabled == false && cbdisciplina.SelectedIndex == -1)
                {
                    MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from examenes where" + comandofecha + " and" + comandoexamenes + "", conexionbd);
                    dgvexamenes.Refresh();
                    comandobuscar.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                        return;
                    }
                    conexionbd.Close();
                    return;
                }
                else if (txbexaminadores.Text != "" && Fechadatatimer.Enabled != false && horadatatimer.Enabled != false && cbdisciplina.SelectedIndex != -1)
                {
                    MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from examenes where" + comandodisciplina + " and" + comandoexamenes + "and"+comandohora + " and"+comandofecha+"", conexionbd);
                    dgvexamenes.Refresh();
                    comandobuscar.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                        return;
                    }
                    conexionbd.Close();
                    return;
                }

                else if (txbexaminadores.Text != "" && Fechadatatimer.Enabled != false && horadatatimer.Enabled == false && cbdisciplina.SelectedIndex == -1)
                {
                    MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from examenes where" + comandodisciplina + " and" + comandoexamenes + "", conexionbd);
                    dgvexamenes.Refresh();
                    comandobuscar.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;
                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
                        limpiar();
                        return;
                    }
                    conexionbd.Close();
                    return;
                }

                else if (txbexaminadores.Text == "" && Fechadatatimer.Enabled == false && horadatatimer.Enabled == false && cbdisciplina.SelectedIndex == -1)
                {
                    MessageBox.Show("Las casillas no pueden estar vacias");
                    conexionbd.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Solo se puede buscar por un elemento o por: " +
                        "\n-Fecha y hora"+ 
                        "\n-Fecha y examinador"+
                        "\n-Fecha, hora y examinador"+
                        "\n-Examinador y disciplina"+
                        "\n-Fecha,hora,examinador y disciplina");
                    conexionbd.Close();
                    return;
                }



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
            minim.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }

        private void txbexaminadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 225))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dgvexamenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                DataGridViewRow filas=dgvexamenes.Rows[e.RowIndex];
                if (filas.Cells["colexaminadores"].Value.ToString()=="")
                {
                    MessageBox.Show("Esta seleccionando una casilla vacia","Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    txbexaminadores.Text = filas.Cells["colexaminadores"].Value.ToString();
                    cbdisciplina.SelectedItem = filas.Cells["coldisciplina"].Value.ToString();
                    cbhabfe.Checked = true;
                    cbhabhora.Checked = true;
                    id = Int32.Parse(filas.Cells["colidexamen"].Value.ToString());
                    Fechadatatimer.Value = Convert.ToDateTime(Convert.ToString(filas.Cells["colfecha"].Value));
                    horadatatimer.Value = Convert.ToDateTime(Convert.ToString(filas.Cells["colhora"].Value));
                }
              

            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Examenesfrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Examenesfrm_KeyDown(object sender, KeyEventArgs a)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txbexaminadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            minim.Visible = false;
            maximizar.Visible = true;
        }
    }
}
    

