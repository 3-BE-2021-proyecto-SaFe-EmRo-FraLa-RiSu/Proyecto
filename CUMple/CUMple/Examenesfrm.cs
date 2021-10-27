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

        public void editarusuario(string columna, string datonuevo, string datoacambiar, string idexamen)
        {

            conexionbd.Open();
            string comando = "update examenes set " + columna + "='" + datonuevo + "' where " + columna + "='" + datoacambiar + "' and idexamen ='" + idexamen + "';";
            MySqlCommand comandoeditarusuario = new MySqlCommand(comando, conexionbd);
            try
            {
                comandoeditarusuario.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
         
            }
            MessageBox.Show("Se edito el exámen correctamente.");
            cargarexamenes();
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
            dgvexamenes.DataSource=cargarexamenes();
        }

        private void dgvexamenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (txbdisciplina.Text!="" && cbidexamen.SelectedIndex!=null)
            {

            }
            if (txbexaminadores.Text != "" && cbidexamen.SelectedIndex != null)
            {

            }
            if (txbfecha.Text != "" && cbidexamen.SelectedIndex != null)
            {

            }
            if (txbhora.Text != "" && cbidexamen.SelectedIndex != null)
            {

            }
        }

        private void cbidexamen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
