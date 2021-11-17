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
    public partial class listaasistencias : Form
    {
        MySqlConnection conexionbd = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        public listaasistencias()
        {
            InitializeComponent();
        }
        bool krav, adultos, tigres, avanzados,adolescentes;

       
        private void listaasistencias_Load(object sender, EventArgs e)
        {

        }

        private void panelapoyo2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (krav != false || adultos != false || avanzados != false || adolescentes != false || tigres != false)
            {
                if (krav==true && txbbucar.Text=="")
                {
                    dgvalumnospresentes.Refresh();
                    dgvalumnospresentes.DataSource = dgvlistas.DataSource;
                }
            }
        }
        private void txbbucar_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txbbucar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable filas = new DataTable();
            conexionbd.Open();
            if (krav != false || adultos != false || avanzados != false || adolescentes != false || tigres != false)
            {
                if (krav == true)
                {
                    string comando = "SELECT nomcompleto from discipulos where krav_maga=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 and nomcompleto like '%" + txbbucar.Text + "%' group by cedula";
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount == 0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        e.Handled = true;
                        txbbucar.Text = "";
                        return;
                    }
                    for (int i = 0; i < dgvlistas.RowCount; i++)
                    {
                        dgvlistas.Rows[i].Cells["Clase"].Value = "Krav Maga";
                        
                    }

                }

                if (adultos == true)
                {
                    string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 and nomcompleto like '%" + txbbucar.Text + "%' group by cedula";
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount==0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        e.Handled = true;
                        txbbucar.Text = "";
                        return;
                    }
                    for (int i = 0; i < dgvlistas.RowCount; i++)
                    {
                        dgvlistas.Rows[i].Cells["Clase"].Value = "Adultos";
                    }

                }

                if (avanzados == true)
                {
                    string comando = "SELECT nomcompleto from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 and nomcompleto like '%" + txbbucar.Text + "%' and rango NOT IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado','Camuflado','Camuflado confirmado') group by cedula";
                   
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount == 0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        e.Handled = true;
                        txbbucar.Text = "";
                        return;
                    }
                    for (int i = 0; i < dgvlistas.RowCount; i++)
                    {
                        dgvlistas.Rows[i].Cells["Clase"].Value = "Avanzados";
                    }

                }
                if (adolescentes == true)
                {
                    string comando = "SELECT nomcompleto from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<=13 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmadmuflado confo','Naranja','Naranja confirmado','Camuflado','Cairmado') and nomcompleto like '%" + txbbucar.Text + "%' group by cedula";
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                  
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount == 0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        e.Handled = true;
                        txbbucar.Text = "";
                        return;
                    }
                    for (int i = 0; i < dgvlistas.RowCount - 1; i++)
                    {
                        dgvlistas.Rows[i].Cells["Clase"].Value = "Adolescentes";
                    }

                }

                if (tigres == true)
                {
                    string comando = "SELECT nomcompleto from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=3 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado','Camuflado','Camuflado confirmado') and nomcompleto like '%" + txbbucar.Text + "%' group by cedula";
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                   
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount == 0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        e.Handled = true;
                        txbbucar.Text = "";
                        return;
                    }

                    for (int i = 0; i < dgvlistas.RowCount; i++)
                    {
                        dgvlistas.Rows[i].Cells["Clase"].Value = "Tigres";
                    }


                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una clase.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            conexionbd.Close();
        }

        private void txbbucar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            restaurar.Visible = true;
            maximizar.Visible = false;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void listaasistencias_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnkravmaga_Click(object sender, EventArgs e)
        {
           
            dgvalumnospresentes.Rows.Clear();
            krav = true;
            adultos = false;
            tigres = false;
            avanzados = false;
            adolescentes = false;
            DataTable filas = new DataTable();
            conexionbd.Open();
            string comando = "SELECT nomcompleto from discipulos where krav_maga=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 group by cedula";
            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
           
                comandosql.Fill(filas);
                dgvlistas.Refresh();
                dgvlistas.DataSource = filas;
                for (int i = 0; i < dgvlistas.RowCount; i++)
                {
                    dgvlistas.Rows[i].Cells["Clase"].Value = "Krav Maga";

                }

            
            conexionbd.Close();
           
           
        }

        private void clicktigres(object sender, EventArgs e)
        {
            DataTable filas = new DataTable();
            dgvalumnospresentes.Rows.Clear();
            krav = false;
            adultos = false;
            tigres = true;
            avanzados = false;
            adolescentes = false;
            conexionbd.Open();
            string comando = "SELECT nomcompleto from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=3 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado','Camuflado','Camuflado confirmado') and nomcompleto like '%" + txbbucar.Text + "%' group by cedula";
            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
            comandosql.Fill(filas);
            dgvlistas.Refresh();
            dgvlistas.DataSource = filas;
            for (int i = 0; i < dgvlistas.RowCount; i++)
            {
                dgvlistas.Rows[i].Cells["Clase"].Value = "Tigres";
            }
            conexionbd.Close();
        }

        private void btnavanzados_Click(object sender, EventArgs e)
        {
            DataTable filas = new DataTable();
            dgvalumnospresentes.Rows.Clear();
            krav = false;
            adultos = false;
            tigres = false;
            avanzados = true;
            adolescentes = false;


            string comando = "SELECT nomcompleto from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 and rango NOT IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado','Camuflado','Camuflado confirmado') group by cedula";

            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
            comandosql.Fill(filas);
            dgvlistas.Refresh();
            dgvlistas.DataSource = filas;
            for (int i = 0; i < dgvlistas.RowCount; i++)
            {
                dgvlistas.Rows[i].Cells["Clase"].Value = "Avanzados";
            }

        }

        private void adolescentes_Click(object sender, EventArgs e)
        {
            DataTable filas = new DataTable();
            dgvalumnospresentes.Rows.Clear();

            krav = false;
            adultos = false;
            tigres = false;
            avanzados = false;
            adolescentes = true;

            string comando = "SELECT nomcompleto from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<=13 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmadmuflado confo','Naranja','Naranja confirmado','Camuflado','Cairmado') and nomcompleto group by cedula";
            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
            comandosql.Fill(filas);

            dgvlistas.Refresh();
            dgvlistas.DataSource = filas;
          
            for (int i = 0; i < dgvlistas.RowCount - 1; i++)
            {
                dgvlistas.Rows[i].Cells["Clase"].Value = "Adolescentes";
            }
        }

        private void dgvlistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
              
                DataGridViewRow filas = dgvlistas.Rows[e.RowIndex];
                for (int i = 0; i < dgvalumnospresentes.RowCount; i++)
                {
                    string cedula = filas.Cells["cedula"].Value.ToString();
                    if (dgvalumnospresentes.Rows[i].Cells["cedula"].Value.ToString() == cedula)
                    {
                        MessageBox.Show("Este alumno ya esta ingresado.");
                        return;
                    }

                }
                dgvalumnospresentes.Rows.Add(filas.Cells["Nombre"].Value.ToString(),filas.Cells["cedula"].Value.ToString(), filas.Cells["tipo"].Value.ToString());
              
            }
           
        }

        private void btnlista_Click(object sender, EventArgs e)
        {

            DateTime myDateTime = DateTime.Now;
            string fechaparasql = myDateTime.ToString("yyyy-MM-dd");
            if (adultos==true)
            {
                for (int i = 0; i < dgvalumnospresentes.RowCount; i++)
                {
                    string pasarlista = "insert into van values(1,'" + fechaparasql + "','"+dgvalumnospresentes.Rows[i].Cells["cedula"]+"',1)";
                    MySqlCommand comandoparamysql = new MySqlCommand(fechaparasql,conexionbd);
                    comandoparamysql.ExecuteNonQuery();

                }
            }
           
        }

        private void dgvasistencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
           
        }

        private void btnadulto(object sender, EventArgs e)
        {
            DataTable filas = new DataTable();
            dgvalumnospresentes.Rows.Clear();
            krav = false;
            adultos = true;
            tigres = false;
            avanzados = false;
            string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 group by cedula";
            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
            comandosql.Fill(filas);
            dgvlistas.Refresh();
            dgvlistas.DataSource = filas;          
            for (int i = 0; i < dgvlistas.RowCount; i++)
            {
                dgvlistas.Rows[i].Cells["Clase"].Value = "Adultos";
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

      
    }
}
