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
        public Userprofile()
        {
            InitializeComponent();
        }

        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");

        public void editarusuario(string columna,string datoacambiar,string datonuevo)
        {
            conexionprograma.Open();
            string comando = "update usuario set "+columna+"='"+datonuevo+"' where "+ columna +"='"+datoacambiar+"';";
            MySqlCommand comandoeditarusuario = new MySqlCommand(comando,conexionprograma);
            comandoeditarusuario.ExecuteNonQuery();
            conexionprograma.Close();
        }
        
        public string mostrarlabel(string agarrardato)
        {
            conexionprograma.Open();
            string reloco= "select * from usuario";
            MySqlCommand comandolabel = new MySqlCommand(reloco,conexionprograma);
            MySqlDataReader lectordecomando = comandolabel.ExecuteReader();
            lectordecomando.GetString(agarrardato) ;
            conexionprograma.Close();


            return agarrardato;
        }
        private void Userprofile_Load(object sender, EventArgs e)
        {
            lblapperf.Text = mostrarlabel("Apellido");
            lblcedperf.Text = mostrarlabel("Cedula");
            lblcelpref.Text = mostrarlabel("Celular");
            lblemailpref.Text = mostrarlabel("Email");
            lblfecingpref.Text = mostrarlabel("Fechadeing");
            lblfecnacpref.Text = mostrarlabel("Fechadenac");
            lblnomperf.Text = mostrarlabel("Nombre");
            lblprofperf .Text = mostrarlabel("Profesion");
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
                editarusuario("Profesiones",txbprofedit.Text,lblprofperf.Text);
            }

            if (txbnomedit.Text == "")
            {
            }
            else
            {
                editarusuario("Nombre", txbnomedit.Text, lblnomperf.Text);
            }
            if (txbceddit.Text == "")
            {
            }
            else
            {
                editarusuario("Cedula", txbceddit.Text, lblcedperf.Text);
            }
            if (txbceledit.Text == "")
            {
            }
            else
            {
                editarusuario("Celular", txbceledit.Text, lblcelpref.Text);
            }
            if (txbemailedit.Text == "")
            {              
            }
            else
            {
                editarusuario("Emails", txbemailedit.Text, lblemailpref.Text);
            }
          
            if (txbapedit.Text == "")
            {
            }
            else
            {
                editarusuario("Apellido", txbapedit.Text, lblapperf.Text);
            }
            if (txbfecdeingdit.Text == "")
            {

            }
            else
            {
                editarusuario("Fechadeing", txbfecdeingdit.Text, txbfecdeingdit.Text);
            }
            if (txbfecdenacedit.Text == "")
            {

            }
            else
            {
                editarusuario("Fechadenac", txbfecdenacedit.Text, lblfecnacpref.Text);
            }
            //}
        }
    }
}
