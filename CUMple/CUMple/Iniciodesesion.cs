using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class forming : Form
    {
        public forming()
        {
            InitializeComponent();
        }
      

        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");
        MySqlCommand comandoparamysql = new MySqlCommand();
        
        
        public class Detallesusarios
        {
            private static string nombreusuario;
            public static string nombreusuario_;


        }

     
    

private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Marcoin_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            conexionprograma.Open();
            string logIn = "SELECT * FROM usuarios WHERE usuario= '" + txbuserb.Text + "' and contraseña= '" + txbconb.Text + "'";
            comandoparamysql = new MySqlCommand(logIn, conexionprograma);
            MySqlDataReader lectordedatos = comandoparamysql.ExecuteReader();
           
            if (lectordedatos.Read() == true && lectordedatos.GetString("tipo") == "Adm")
            {

                new formadmin().Show();
                this.Hide();
                
            }
            else if (lectordedatos.Read() == true && lectordedatos.GetString("tipo") == "Alm")
            {

                new Principal().Show();
                this.Hide();
                
            }

            else 
            {

                MessageBox.Show("Usuario o contraseña incorrecta");
               
            }
         

            if (txbuserb.Text == "" && txbconb.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                
            }

            else if (txbuserb.Text == "")
            {
                MessageBox.Show("El campo de usuario esta vacio");
                txbuserb.Focus();
                
            }
            else if (txbconb.Text == "")
            {
                MessageBox.Show("El campo de la contraseña esta vacio");
                txbconb.Focus();
               
            }

            conexionprograma.Close();


        }

        private void txbconb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblcontraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
