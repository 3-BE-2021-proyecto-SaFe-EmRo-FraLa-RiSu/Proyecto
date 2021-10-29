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
            lblnomperf.Text = nombrebuscado;
            
        }            
     
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        public void editarusuario(string columna,string datonuevo, string datoacambiar, string cedula)
        {      
            conexionprograma.Open();
            string comando = "update discipulos set "+ columna + "='"+ datonuevo + "' where "+ columna +"='"+ datoacambiar + "' and cedula ='" + cedula + "';";
            MySqlCommand comandoeditarusuario = new MySqlCommand(comando,conexionprograma);
            try
            {
                comandoeditarusuario.ExecuteNonQuery();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            MessageBox.Show("El usuario se ha editado correctamente");

            conexionprograma.Close();
            
            if (columna == "nomcompleto") 
            {
                new Userprofile(datonuevo).Show();
                this.Dispose();
            }
        }
        
        public string mostrarlabel(string agarrardato)
        {
          
            conexionprograma.Open();
            string dato;
            string mostrardiscipulos= "select * from discipulos where nomcompleto='"+ lblnomperf.Text +"'";
            MySqlCommand comandolabel = new MySqlCommand(mostrardiscipulos,conexionprograma);
            MySqlDataReader lectordecomando = comandolabel.ExecuteReader();
           if (lectordecomando.Read())
            { 
                                             //tabla
                dato=lectordecomando.GetString(agarrardato);
                conexionprograma.Close();
                return dato;         
            }
           else
            {
                conexionprograma.Close();
                return dato = "";

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
           
            //Agregar que la fecha de ingreso se genere automaticamente

            //if ( hay un usuario seleccionado   ) { pedir que se seleccione uno }
            //else {
            if (txbprofedit.Text != "") 
            {
                editarusuario("profesiones", txbprofedit.Text, lblprofperf.Text, lblcedperf.Text);
                lblprofperf.Text = mostrarlabel("profesiones");
            }
           

            if (txbnomedit.Text != "")
            {
                editarusuario("nomcompleto", txbnomedit.Text, lblnomperf.Text, lblcedperf.Text);
                lblnomperf.Text = mostrarlabel("nomcompleto");                
            }
           
            if (txbceddit.Text != "")
            {
                editarusuario("cedula", txbceddit.Text, lblcedperf.Text, lblcedperf.Text);
                lblcedperf.Text = mostrarlabel("cedula");
            }
           
            if (txbceledit.Text != "")
            {
                editarusuario("celular", txbceledit.Text, lblcelpref.Text, lblcedperf.Text);
                lblcelpref.Text = mostrarlabel("celular");
            }
           
            if (txbemailedit.Text != "")
            {
                editarusuario("emails", txbemailedit.Text, lblemailpref.Text, lblcedperf.Text);
                lblemailpref.Text = mostrarlabel("emails");
            }                   
                        
            if (txbfecdenacedit.Text != "")
            {
                editarusuario("fecha_de_nac", txbfecdenacedit.Text, lblfecnacpref.Text, lblcedperf.Text);
                lblfecnacpref.Text = mostrarlabel("fecha_de_nac");

            }
          
            //}
            
         
          
         
           
           
           
        }

        private void lblmostnom_Click(object sender, EventArgs e)
        {

        }

        private void txbfecdenacedit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnomperf_Click(object sender, EventArgs e)
        {

        }

        private void btnvolveruserprofile_Click(object sender, EventArgs e)
        {
            new formadmin().Show();
            this.Dispose();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txbceddit.Text != "" && txbceledit.Text != "" && txbemailedit.Text != "" && txbfecdenacedit.Text != "" && txbnomedit.Text != "" && txbprofedit.Text != "")
            {
                string agregardiscipulocomandostring="insert into discipulos(cedular,cedula,nomcompleto,krav_maga,taekwondo,profesiones,fecha_de_nac,emails) values('"+txbceledit.Text+"','"+txbceddit.Text+"','"+txbnomedit.Text+"')";
                MySqlCommand agregardiscipulos = new MySqlCommand(agregardiscipulocomandostring, conexionprograma);
                agregardiscipulos.ExecuteNonQuery();
            }
        }
    }
}
