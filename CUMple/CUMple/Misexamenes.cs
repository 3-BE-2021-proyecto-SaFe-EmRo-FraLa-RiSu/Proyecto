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
    public partial class Misexamenes : Form
    {
        string cedulax;
        public Misexamenes(string cedula)
        {
            InitializeComponent();
            cedulax = cedula;
        }

        MySqlConnection conexionbd = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbhabfe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void horadatatimer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fechadatatimer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private DataTable cargarexamenes(string cedula)
        {

            DataTable dtexamenes = new DataTable();
            string comandostring = "select * from rango_obtenido where cedula=" + cedula + ";";
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

        private void Misexamenes_Load(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            txbnota.Text = "";
         
            cbrango.SelectedIndex = -1;
            dgvexamenes.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dtexamenes = new DataTable();

            string nota, comandonota = "";
            string rango, comandorango = "";

                if (txbnota.Text != "")
                {
                    nota = txbnota.Text;
                    comandonota = " nota=" + nota + "";
                }
                if (cbrango.SelectedIndex != -1)
                {
                    rango = cbrango.SelectedItem.ToString();
                    comandorango = " nuevo_rango='" + rango + "'";
                }
                for (int i = 0; i < dgvexamenes.RowCount - 1; i++)
                {
                    if (txbnota.Text != "" && cbrango.SelectedIndex == -1)
                    {
                        MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from rango_obtenido where" + comandonota + "", conexionbd);
                        dgvexamenes.Refresh();
                        comandobuscar.Fill(dtexamenes);
                        dgvexamenes.DataSource = dtexamenes;
                        if (dgvexamenes.Rows[0].Cells[0].Value == null)
                        {
                            MessageBox.Show("No tienes datos aquí");
                            conexionbd.Close();
                            dgvexamenes.DataSource = cargarexamenes(cedulax);
                            limpiar();
                            return;
                        }
                        conexionbd.Close();
                        return;
                    }
                    if (txbnota.Text == "" && cbrango.SelectedIndex != -1)
                    {
                        MySqlDataAdapter comandobuscar = new MySqlDataAdapter("select * from rango_obtenido where" + comandorango + "", conexionbd);
                        dgvexamenes.Refresh();
                        comandobuscar.Fill(dtexamenes);
                        dgvexamenes.DataSource = dtexamenes;
                        if (dgvexamenes.Rows[0].Cells[0].Value == null)
                        {
                            MessageBox.Show("No tienes datos de esta fecha");
                            conexionbd.Close();
                            dgvexamenes.DataSource = cargarexamenes(cedulax);
                            limpiar();
                            return;
                        }
                        conexionbd.Close();
                        return;
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvexamenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void minim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            maximizar.Visible = true;
            minim.Visible = false;
        }

        private void restau_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            minim.Visible = true;
        }
    }
}
