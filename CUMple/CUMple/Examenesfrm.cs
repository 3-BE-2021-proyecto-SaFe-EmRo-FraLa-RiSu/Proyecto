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

        private void dgvexamenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
          

            if(cbidexamen.SelectedIndex !=-1 ) {
                int idselecionado = Int32.Parse(cbidexamen.SelectedItem.ToString());
                if (txbdisciplina.Text!="")
            {
                editarexamen("disciplina",txbdisciplina.Text, idselecionado);
            }
            if (txbexaminadores.Text != "")
            {
                editarexamen("examinadores", txbexaminadores.Text, idselecionado);
            }
            if (txbfecha.Text != "")
            {
                editarexamen("fecha", txbfecha.Text, idselecionado);
            }
            if (txbhora.Text != "")
            {
                editarexamen("hora", txbhora.Text, idselecionado);
            }
            }
            else
            {
                MessageBox.Show("Debe selecionar un id de examén");
            }
        }
           
        private void cbidexamen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txbdisciplina.Text!="" && txbexaminadores.Text!="" && txbfecha.Text!="" && txbhora.Text!="")
            {
                string comando = "insert into examenes (disciplina,examinadores,fecha,hora) values("+txbdisciplina.Text+","+txbexaminadores.Text+","+txbfecha.Text+","+txbhora.Text+")";
            }
        }

        private void btnvolverexamenes_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Dispose();
        }
    }
}
