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
        public examenesnotas(string idexamen)
        {
            
            InitializeComponent();
             idexamen1=idexamen;
        }
        string idexamen1;
        MySqlConnection conexionbd = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");



        private void editarexamenes(string columnaaeditar,string datonuevo, string datodefinitivo)
        {
            string comand = "update examenes set "+columnaaeditar+"='"+datonuevo+ "' where and cedula='"+ datodefinitivo + "' ;";
            conexionbd.Open();
            MySqlCommand comando = new MySqlCommand(comand, conexionbd);
          
        }
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
            dgvexamenes.DataSource = cargarexamenes(idexamen1);
                 
        }

        private void cbidexamen_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvexamenes.Refresh();
            dgvexamenes.DataSource = cargarexamenes(cbidexamen.SelectedItem.ToString());
         
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cbcedula.SelectedIndex != -1 && txbnota.Text != "" && cbrango.SelectedIndex != -1 && cbidexamen.SelectedIndex != -1)
            {
                string rango = cbrango.SelectedItem.ToString();
                string cedula = cbcedula.SelectedItem.ToString();
                int nota = Int32.Parse(txbnota.Text);

                for (int i = 0; i < dgvexamenes.RowCount-1; i++)
                {
                    if (cedula == dgvexamenes.Rows[i].Cells["cedula"].Value.ToString())
                    {
                       
                        MessageBox.Show("El alumno ya fue ingresado");
                        return;                       
                    }
                }
                if (nota>0 && nota<=90)
                {
                    conexionbd.Open();
                    MySqlCommand añadiralumno = new MySqlCommand("insert into rango_obtenido values(" + nota + ",'" + rango + "'," + cbidexamen.SelectedItem.ToString() + ",'" + cedula + "')", conexionbd);
                    añadiralumno.ExecuteNonQuery();
                    conexionbd.Close();
                    dgvexamenes.DataSource = cargarexamenes(cbidexamen.SelectedItem.ToString());                
                }
                else
                {
                    MessageBox.Show("La nota debe estar entre 1 y 90");
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
            
            
            if (cbcedula.SelectedIndex!=-1 && cbidexamen.SelectedIndex!=-1)
            {
                string cedula = cbcedula.SelectedItem.ToString();
                for (int i = 0; i < dgvexamenes.RowCount - 1; i++)
                {
                  if (cedula == dgvexamenes.Rows[i].Cells["cedula"].Value.ToString())
                    {
                        MySqlCommand borraralumndo = new MySqlCommand("delete from rango_obtenido where cedula='" + cedula + "' AND idexamen='" + cbidexamen.SelectedItem.ToString() + "'", conexionbd);
                        conexionbd.Open();
                        borraralumndo.ExecuteNonQuery();
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes(cbidexamen.SelectedItem.ToString());
                        return;
                    }

                }
                MessageBox.Show("El alumno no existe");

            }
            else
            {
                MessageBox.Show("Para borrar al alumno del examen debe estar seleccionado la id del exámen y la cédula");
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
            minimizar.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            minimizar.Visible = false;
            maximizar.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (txbnota.Text!="")
            {

                editarexamenes("notas", txbnota.Text, cbcedula.SelectedItem.ToString());
            }

            if (true)
            {

            }
        }

        private void dgvexamenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow filas = dgvexamenes.Rows[e.RowIndex];
                if (filas.Cells["cedula"].Value.ToString() == "")
                {
                    MessageBox.Show("Esta seleccionando una casilla vacia", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }              
                txbnota.Text = filas.Cells["notas"].Value.ToString();
                cbcedula.SelectedItem = filas.Cells["cedula"].Value.ToString();
                cbrango.SelectedItem = filas.Cells["nuevo_rango"].Value.ToString();
                cbidexamen.SelectedItem = filas.Cells["idexamen"].Value.ToString();
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void examenesnotas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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

        private void btnvolverexamenes_Click(object sender, EventArgs e)
        {
            new Examenesfrm().Show();
            this.Dispose();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
