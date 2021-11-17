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
        MySqlConnection conexionbd2 = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        public listaasistencias()
        {
            InitializeComponent();
        }
        bool krav, adultos, tigres, avanzados,adolescentes;

       
        private void listaasistencias_Load(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;
            string fechaparasql = myDateTime.ToString("yyyy-MM-dd");
            conexionbd.Open();
            string comando = "SELECT nuevo_rango,cedula FROM rango_obtenido WHERE idexamen = (SELECT idexamen from examenes WHERE fecha <= '"+fechaparasql+"' LIMIT 1)";
            MySqlCommand comandoparasql = new MySqlCommand(comando,conexionbd);
            MySqlDataReader lectordedatos = comandoparasql.ExecuteReader();
            conexionbd2.Open();
            while (lectordedatos.Read())
            {
             string update="update discipulos set rango='"+lectordedatos.GetString("nuevo_rango")+"' where cedula='"+lectordedatos.GetString("cedula")+"'";
                MySqlCommand updaterangos = new MySqlCommand(update, conexionbd2);
                updaterangos.ExecuteNonQuery();
            }
           
     
            conexionbd.Close();
            conexionbd2.Close();
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
                if (txbbucar.Text=="" && dgvlistas.RowCount > 0)
                {
                    dgvalumnospresentes.Rows.Clear();

                    foreach (DataGridViewRow filas in dgvlistas.Rows)
                    {
                        dgvalumnospresentes.Rows.Add(filas.Cells["Nombrelist"].Value.ToString(), filas.Cells["Cedulalist"].Value.ToString(), filas.Cells["Claselist"].Value.ToString());
                    }
                   
                }
                else
                {
                    MessageBox.Show("No puede pasar la lista ya que no hay alumnos para pasar. Compruebe que la casilla de busqueda esta vacia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txbbucar_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txbbucar_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txbbucar_TextChanged(object sender, EventArgs e)
        {
            actualizarfiltrado();
        }
        public void actualizarfiltrado()
        {
            if (txbbucar.Text == "")
            {
                        DataTable filas = new DataTable();
            conexionbd.Open();
            if (krav != false || adultos != false || avanzados != false || adolescentes != false || tigres != false)
            {
                if (krav == true)
                {
                    string comando = "SELECT nomcompleto,cedula from discipulos where krav_maga=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 group by cedula";
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount == 0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        txbbucar.Text = "";
                        return;
                    }
                    for (int i = 0; i < dgvlistas.RowCount; i++)
                    {
                        dgvlistas.Rows[i].Cells["Claselist"].Value = "Krav Maga";
                        
                    }

                }

                if (adultos == true)
                {
                    string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 group by cedula";
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount==0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        txbbucar.Text = "";
                        return;
                    }
                    for (int i = 0; i < dgvlistas.RowCount; i++)
                    {
                        dgvlistas.Rows[i].Cells["Claselist"].Value = "Adultos";
                    }

                }

                if (avanzados == true)
                {
                    string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<=13 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=6 and rango NOT IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado') group by cedula";
                   
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount == 0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        txbbucar.Text = "";
                        return;
                    }
                    for (int i = 0; i < dgvlistas.RowCount; i++)
                    {
                        dgvlistas.Rows[i].Cells["Claselist"].Value = "Avanzados";
                    }

                }
                if (adolescentes == true)
                {
                    string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<=13 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmadmuflado confo','Naranja','Naranja confirmado') group by cedula";
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                  
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount == 0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        txbbucar.Text = "";
                        return;
                    }
                    for (int i = 0; i < dgvlistas.RowCount; i++)
                    {
                        dgvlistas.Rows[i].Cells["Claselist"].Value = "Adolescentes";
                    }

                }

                if (tigres == true)
                {
                    string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=3 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado') group by cedula";
                    MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                    comandosql.Fill(filas);
                   
                    dgvlistas.Refresh();
                    dgvlistas.DataSource = filas;
                    if (dgvlistas.RowCount == 0)
                    {
                        conexionbd.Close();
                        MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                        txbbucar.Text = "";
                        return;
                    }

                    for (int i = 0; i < dgvlistas.RowCount; i++)
                    {
                        dgvlistas.Rows[i].Cells["Claselist"].Value = "Tigres";
                    }


                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una clase.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexionbd.Close();
            }
            else
            {
                DataTable filas = new DataTable();
                conexionbd.Open();
                if (krav != false || adultos != false || avanzados != false || adolescentes != false || tigres != false)
                {
                    if (krav == true)
                    {
                        string comando = "SELECT nomcompleto,cedula from discipulos where krav_maga=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 and nomcompleto like '%" + txbbucar.Text + "%' group by cedula";
                        MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                        comandosql.Fill(filas);
                        dgvlistas.Refresh();
                        dgvlistas.DataSource = filas;
                        if (dgvlistas.RowCount == 0)
                        {
                            conexionbd.Close();
                            MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                            txbbucar.Text = "";
                            return;
                        }
                        for (int i = 0; i < dgvlistas.RowCount; i++)
                        {
                        dgvlistas.Rows[i].Cells["Claselist"].Value = "Krav Maga";
                        
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
                            txbbucar.Text = "";
                            return;
                        }
                        for (int i = 0; i < dgvlistas.RowCount; i++)
                        {
                            dgvlistas.Rows[i].Cells["Claselist"].Value = "Adultos";
                        }

                    }

                    if (avanzados == true)
                    {
                        string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<=13 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=6 and nomcompleto like '%" + txbbucar.Text + "%' and rango NOT IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado') group by cedula";                  
                        MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                        comandosql.Fill(filas);
                        dgvlistas.Refresh();
                        dgvlistas.DataSource = filas;
                        if (dgvlistas.RowCount == 0)
                        {
                            conexionbd.Close();
                            MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                            txbbucar.Text = "";
                            return;
                        }
                        for (int i = 0; i < dgvlistas.RowCount; i++)
                        {
                            dgvlistas.Rows[i].Cells["Claselist"].Value = "Avanzados";
                        }

                    }
                    if (adolescentes == true)
                    {
                        string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<=13 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmadmuflado confo','Naranja','Naranja confirmado') and nomcompleto like '%" + txbbucar.Text + "%' group by cedula";
                        MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                        comandosql.Fill(filas);
                  
                        dgvlistas.Refresh();
                        dgvlistas.DataSource = filas;
                        if (dgvlistas.RowCount == 0)
                        {
                            conexionbd.Close();
                            MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                            txbbucar.Text = "";
                            return;
                        }
                        for (int i = 0; i < dgvlistas.RowCount; i++)
                        {
                            dgvlistas.Rows[i].Cells["Claselist"].Value = "Adolescentes";
                        }

                    }

                    if (tigres == true)
                    {
                        string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=3 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado') and nomcompleto like '%" + txbbucar.Text + "%' group by cedula";
                        MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
                        comandosql.Fill(filas);
                   
                        dgvlistas.Refresh();
                        dgvlistas.DataSource = filas;
                        if (dgvlistas.RowCount == 0)
                        {
                            conexionbd.Close();
                            MessageBox.Show("No se encontro a ningún discipulo con este nombre");
                            txbbucar.Text = "";
                            return;
                        }

                        for (int i = 0; i < dgvlistas.RowCount; i++)
                        {
                            dgvlistas.Rows[i].Cells["Claselist"].Value = "Tigres";
                        }


                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una clase.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conexionbd.Close();
            } 
        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
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
            string comando = "SELECT nomcompleto,cedula from discipulos where krav_maga=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=13 group by cedula";
            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
           
                comandosql.Fill(filas);
                dgvlistas.Refresh();
                dgvlistas.DataSource = filas;
                for (int i = 0; i < dgvlistas.RowCount; i++)
                {
                    dgvlistas.Rows[i].Cells["Claselist"].Value = "Krav Maga";

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
            string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=3 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado') and nomcompleto like '%" + txbbucar.Text + "%' group by cedula";
            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
            comandosql.Fill(filas);
            dgvlistas.Refresh();
            dgvlistas.DataSource = filas;
            for (int i = 0; i < dgvlistas.RowCount; i++)
            {
                dgvlistas.Rows[i].Cells["Claselist"].Value = "Tigres";
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


            string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<=13 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=6 and rango NOT IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmado','Naranja','Naranja confirmado') group by cedula";

            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
            comandosql.Fill(filas);
            dgvlistas.Refresh();
            dgvlistas.DataSource = filas;
            for (int i = 0; i < dgvlistas.RowCount; i++)
            {
                dgvlistas.Rows[i].Cells["Claselist"].Value = "Avanzados";
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

            string comando = "SELECT nomcompleto,cedula from discipulos where taekwondo=1 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)<=13 and TIMESTAMPDIFF(YEAR,fecha_de_nac,CURRENT_DATE)>=6 and rango IN ('Blanco','Blanco confirmado','Amarillo','Amarillo confirmadmuflado confo','Naranja','Naranja confirmado') group by cedula";
            MySqlDataAdapter comandosql = new MySqlDataAdapter(comando, conexionbd);
            comandosql.Fill(filas);

            dgvlistas.Refresh();
            dgvlistas.DataSource = filas;
          
            for (int i = 0; i < dgvlistas.RowCount; i++)
            {
                dgvlistas.Rows[i].Cells["Claselist"].Value = "Adolescentes";
            }
        }

        private void dgvlistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
              
                DataGridViewRow filas = dgvlistas.Rows[e.RowIndex];
                for (int i = 0; i < dgvalumnospresentes.RowCount; i++)
                {
                    string cedula = filas.Cells["Cedulalist"].Value.ToString();
                    if (dgvalumnospresentes.Rows[i].Cells["Cedulapres"].Value.ToString() == cedula)
                    {
                        MessageBox.Show("Este alumno ya esta ingresado.");
                        return;
                    }

                }
                dgvalumnospresentes.Rows.Add(filas.Cells["Nombrelist"].Value.ToString(),filas.Cells["Cedulalist"].Value.ToString(), filas.Cells["Claselist"].Value.ToString());
              
            }
           
        }

        private bool comprobarquenosepasolista(int idclase,string identificaciondeclase)
        {
            conexionbd.Open();
            DateTime myDateTime = DateTime.Now;
            string fechaparasql = myDateTime.ToString("yyyy-MM-dd");
            string listanopasada="select * from van where fecha='"+fechaparasql+"' and idclase="+idclase+"";
            MySqlCommand comandocomprobar = new MySqlCommand(listanopasada,conexionbd);
            MySqlDataReader lector = comandocomprobar.ExecuteReader();
            if (lector.Read())
            {
                MessageBox.Show("Ya se paso la lista de los "+identificaciondeclase+"");
                conexionbd.Close();
                return true;
            }
            else
            {
                conexionbd.Close();
                return false;
            }
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            
            DateTime myDateTime = DateTime.Now;
            string fechaparasql = myDateTime.ToString("yyyy-MM-dd");
            if (adultos==true)
            {
                if (comprobarquenosepasolista(1,"adultos")==true)
                {
                 
                    return;
                }

                if (dgvalumnospresentes.RowCount==0)
                {
                    MessageBox.Show("No puede pasar la lista si no hay alumnos presente","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                conexionbd.Open();
                for (int i = 0; i < dgvalumnospresentes.RowCount; i++)
                {
                    
                    string pasarlista = "insert into van values(1,'" + fechaparasql + "','"+dgvalumnospresentes.Rows[i].Cells["Cedulapres"].Value.ToString() +"',1)";
                    MySqlCommand comandoparamysql = new MySqlCommand(pasarlista,conexionbd);
                    comandoparamysql.ExecuteNonQuery();

                }
                dgvalumnospresentes.Rows.Clear();
                conexionbd.Close();
            }

            if (avanzados == true)
            {
                if (comprobarquenosepasolista(2, "avanzados") == true)
                {

                    return;
                }

                if (dgvalumnospresentes.RowCount == 0)
                {
                    MessageBox.Show("No puede pasar la lista si no hay alumnos presente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                conexionbd.Open();
                for (int i = 0; i < dgvalumnospresentes.RowCount; i++)
                {

                    string pasarlista = "insert into van values(1,'" + fechaparasql + "','" + dgvalumnospresentes.Rows[i].Cells["Cedulapres"].Value.ToString() + "',2)";
                    MySqlCommand comandoparamysql = new MySqlCommand(pasarlista, conexionbd);
                    comandoparamysql.ExecuteNonQuery();

                }
                dgvalumnospresentes.Rows.Clear();
                conexionbd.Close();
            }


            if (adolescentes == true)
            {
                if (comprobarquenosepasolista(3, "adolescentes") == true)
                {

                    return;
                }

                if (dgvalumnospresentes.RowCount == 0)
                {
                    MessageBox.Show("No puede pasar la lista si no hay alumnos presente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                conexionbd.Open();
                for (int i = 0; i < dgvalumnospresentes.RowCount; i++)
                {

                    string pasarlista = "insert into van values(1,'" + fechaparasql + "','" + dgvalumnospresentes.Rows[i].Cells["Cedulapres"].Value.ToString() + "',3)";
                    MySqlCommand comandoparamysql = new MySqlCommand(pasarlista, conexionbd);
                    comandoparamysql.ExecuteNonQuery();

                }
                dgvalumnospresentes.Rows.Clear();
                conexionbd.Close();
            }


            if (tigres == true)
            {
                if (comprobarquenosepasolista(4, "tigres") == true)
                {

                    return;
                }

                if (dgvalumnospresentes.RowCount == 0)
                {
                    MessageBox.Show("No puede pasar la lista si no hay alumnos presente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                conexionbd.Open();
                for (int i = 0; i < dgvalumnospresentes.RowCount; i++)
                {

                    string pasarlista = "insert into van values(1,'" + fechaparasql + "','" + dgvalumnospresentes.Rows[i].Cells["Cedulapres"].Value.ToString() + "',4)";
                    MySqlCommand comandoparamysql = new MySqlCommand(pasarlista, conexionbd);
                    comandoparamysql.ExecuteNonQuery();

                }
                dgvalumnospresentes.Rows.Clear();
                conexionbd.Close();
            }

            if (krav == true)
            {
                if (comprobarquenosepasolista(5, "krav maga") == true)
                {

                    return;
                }

                if (dgvalumnospresentes.RowCount == 0)
                {
                    MessageBox.Show("No puede pasar la lista si no hay alumnos presente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                conexionbd.Open();
                for (int i = 0; i < dgvalumnospresentes.RowCount; i++)
                {

                    string pasarlista = "insert into van values(1,'" + fechaparasql + "','" + dgvalumnospresentes.Rows[i].Cells["Cedulapres"].Value.ToString() + "',5)";
                    MySqlCommand comandoparamysql = new MySqlCommand(pasarlista, conexionbd);
                    comandoparamysql.ExecuteNonQuery();

                }
                dgvalumnospresentes.Rows.Clear();
                conexionbd.Close();
            }
        }

        private void btnvolverpruebaconexion_Click(object sender, EventArgs e)
        {
            new Principal("Adm").Show();
            this.Dispose();
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
                dgvlistas.Rows[i].Cells["Claselist"].Value = "Adultos";
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
