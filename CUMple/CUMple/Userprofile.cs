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
    public partial class Userprofile : Form
    {
        public Userprofile(string nombrebuscado)
        {
            InitializeComponent();
            lblnombreuser.Text = nombrebuscado;
        }
  
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");

        public void editarusuario(string columna,string datoacambiar,string datonuevo)
        {
            conexionprograma.Open();
            string comando = "update discipulos set "+columna+"='"+datonuevo+"' where "+ columna +"='"+datoacambiar+"';";
            MySqlCommand comandoeditarusuario = new MySqlCommand(comando,conexionprograma);
            try
            {
                comandoeditarusuario.ExecuteNonQuery();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            MessageBox.Show("El usuario se ha editado correctamente");

            conexionprograma.Close();
        }
        
        public string mostrarlabel(string agarrardato)
        {
            conexionprograma.Open();
            string dato;
            string mostrardiscipulos= "select * from discipulos where nomcompleto='"+lblnombreuser.Text+"'";
            MySqlCommand comandolabel = new MySqlCommand(mostrardiscipulos,conexionprograma);
            MySqlDataReader lectordecomando = comandolabel.ExecuteReader();
            if (lectordecomando.Read())
            {                                   //tabla
                dato=lectordecomando.GetString(agarrardato);
                conexionprograma.Close();
                return dato;
            }
            else
            {
                MessageBox.Show("El usuario indicado no existe.");
                conexionprograma.Close();
                return dato="";
            }
           


           
        }
        private void Userprofile_Load(object sender, EventArgs e)
        {
           
            lblcedperf.Text = mostrarlabel("cedula");
            lblcelpref.Text = mostrarlabel("celular");
            lblemailpref.Text = mostrarlabel("emails");
            lblfecingpref.Text = mostrarlabel("fecha_de_ing");
            lblfecnacpref.Text = mostrarlabel("fecha_de_nac");
            lblnomperf.Text = mostrarlabel("nomcompleto");
            lblprofperf .Text = mostrarlabel("profesiones");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
           
            

            //if ( hay un usuario seleccionado   ) { pedir que se seleccione uno }
            //else {
            if (txbprofedit.Text == "") 
            {
            }
            else 
            {
                editarusuario("profesiones",txbprofedit.Text,lblprofperf.Text);
            }

            if (txbnomedit.Text == "")
            {
            }
            else
            {
                editarusuario("nomcompleto", txbnomedit.Text, lblnomperf.Text);
            }
            if (txbceddit.Text == "")
            {
            }
            else
            {
                editarusuario("cedula", txbceddit.Text, lblcedperf.Text);
            }
            if (txbceledit.Text == "")
            {
            }
            else
            {
                editarusuario("celular", txbceledit.Text, lblcelpref.Text);
            }
            if (txbemailedit.Text == "")
            {              
            }
            else
            {
                editarusuario("emails", txbemailedit.Text, lblemailpref.Text);
            }
          
            if (txbfecdeingdit.Text == "")
            {

            }
            else
            {
                editarusuario("fecha_de_ing", txbfecdeingdit.Text, txbfecdeingdit.Text);
            }
            if (txbfecdenacedit.Text == "")
            {

            }
            else
            {
                editarusuario("fecha_de_nac", txbfecdenacedit.Text, lblfecnacpref.Text);
            }
            //}
        }

        private void lblmostnom_Click(object sender, EventArgs e)
        {

        }

        private void txbfecdenacedit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
