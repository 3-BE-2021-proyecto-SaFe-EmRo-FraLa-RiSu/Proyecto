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
    public partial class Editarusuarios : Form
    {
        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");

        public Editarusuarios()
        {
            InitializeComponent();
            MySqlDataReader lectordedatos;
            string comand = "Select usuario from usuarios;";
            conexionprograma.Open();
            MySqlCommand comando = new MySqlCommand(comand, conexionprograma);
            lectordedatos = comando.ExecuteReader();
            while (lectordedatos.Read())
            {
                cmbusuarioseleccionado.Items.Add(lectordedatos["usuario"].ToString());
            }
            conexionprograma.Close();
            cmbusuarioseleccionado.Items.Add("Crear usuario nuevo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formadmin().Show();
            this.Dispose();
        }

        private void btcrearusuario_Click(object sender, EventArgs e)
        {
            if (txbusucre.Text=="" || txtbcontra.Text=="" || txbcontraconf.Text == "")
            {
                MessageBox.Show("Ningún campo puede estar vacio");

            }
            else 
            {
                conexionprograma.Open();
                string comandocompararusuarios = "select usuario from usuarios;";
                MySqlCommand comandoparacompararusuarios = new MySqlCommand(comandocompararusuarios, conexionprograma);
                MySqlDataReader lector = comandoparacompararusuarios.ExecuteReader();
                while (lector.Read())
                {
                    if (lector.GetString("usuario")== txbusucre.Text)
                    {
                        MessageBox.Show("El usuario ya existe en la base de datos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexionprograma.Close();
                        return;
                    }
                }
                conexionprograma.Close();

                if (chkboxadmin.Checked && txbcontraconf.Text.Equals(txtbcontra.Text))
                {
               
                try
                {
                    conexionprograma.Open();
                    string comandocrearusuariostring = "insert into usuarios(usuario,contraseña,tipo)values('" + txbusucre.Text + "','" + txtbcontra.Text + "','Adm');";
                    MySqlCommand comandoparacrearusuarios = new MySqlCommand(comandocrearusuariostring, conexionprograma);
                    comandoparacrearusuarios.ExecuteNonQuery();
                 
                        txbusucre.Text = "";
                        txtbcontra.Text = "";
                        txbcontraconf.Text = "";
                        MessageBox.Show("El usuario se creo correctamente");
                    conexionprograma.Close();
                 
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                   
                }
                else if(chkboxadmin.Checked && txbcontraconf.Text!=txtbcontra.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
               
                else if (chkboxadmin.Checked==false && txbcontraconf.Text.Equals(txtbcontra.Text))
                { 
           
                try
                {
                    conexionprograma.Open();
                    string comandocrearusuariostring = "insert into usuarios(usuario,contraseña,tipo)values('" + txbusucre.Text + "','" + txtbcontra.Text + "','Alm');";
                    MySqlCommand comandoparacrearusuarios = new MySqlCommand(comandocrearusuariostring, conexionprograma);
                    comandoparacrearusuarios.ExecuteNonQuery();
            
                    MessageBox.Show("El usuario se creo correctamente");
                        txbusucre.Text = "";
                        txtbcontra.Text = "";
                        txbcontraconf.Text = "";
                        conexionprograma.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


                }
                else if (chkboxadmin.Checked==false && txbcontraconf.Text != txtbcontra.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Crearlosusuarios_Load(object sender, EventArgs e)
        {
            
        }
        public string mostrarlabel(string agarrardato)
        {
            conexionprograma.Open();
            string dato = "";
            string mostrardiscipulos = "select * from usuarios where usuario ='" + cmbusuarioseleccionado.SelectedItem.ToString() + "'";
            MySqlCommand comandolabel = new MySqlCommand(mostrardiscipulos, conexionprograma);
            MySqlDataReader lectordecomando = comandolabel.ExecuteReader();
            if (lectordecomando.Read())
            {
                dato = lectordecomando.GetString(agarrardato);
                conexionprograma.Close();
                return dato;
            }
            else
            {
                conexionprograma.Close();
                return dato;
            }
        }
        private void txbusucre_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkboxadmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnborrarusuario_Click(object sender, EventArgs e)
        {
            if (txbusucre.Text == "" || txtbcontra.Text == "" || txbcontraconf.Text == "")
            {
                MessageBox.Show("Ningún campo puede estar vacio");

            }
            else
            {
                if (chkboxadmin.Checked && txbcontraconf.Text.Equals(txtbcontra.Text))
                {

                    try
                    {
                        conexionprograma.Open();
                        string comandocrearusuariostring = "delete from usuarios where usuario='" + txbusucre.Text + "' and contraseña='" + txtbcontra.Text + "';";
                        MySqlCommand comandoparacrearusuarios = new MySqlCommand(comandocrearusuariostring, conexionprograma);
                        comandoparacrearusuarios.ExecuteNonQuery();
                        txbusucre.Text = "";
                        txtbcontra.Text = "";
                        txbcontraconf.Text = "";
                        MessageBox.Show("El usuario se borro correctamente");
                        conexionprograma.Close();

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                        throw;
                    }

                }
                else if (chkboxadmin.Checked && txbcontraconf.Text != txtbcontra.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                else if (chkboxadmin.Checked == false && txbcontraconf.Text.Equals(txtbcontra.Text))
                {
                    
                    try
                    {
                        conexionprograma.Open();
                        string comandocrearusuariostring = "delete from usuarios where usuario='" + txbusucre.Text + "' and contraseña='" + txtbcontra.Text + "';";
                        MySqlCommand comandoparacrearusuarios = new MySqlCommand(comandocrearusuariostring, conexionprograma);
                        comandoparacrearusuarios.ExecuteNonQuery();
                        txbusucre.Text = "";
                        txtbcontra.Text = "";
                        txbcontraconf.Text = "";
                        MessageBox.Show("El usuario se borro correctamente");
                        conexionprograma.Close();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                        throw;
                    }

                }
                else if (chkboxadmin.Checked == false && txbcontraconf.Text != txtbcontra.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            minimizarr.Visible = true;
        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = true;
            maximizar.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbusuarioseleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbusuarioseleccionado.SelectedItem.ToString() != "Crear usuario nuevo")
            {
                txbusucre.Text = cmbusuarioseleccionado.SelectedItem.ToString();
               
                string comandd = "select contraseña from usuarios where usuario='lol';";

                conexionprograma.Open();
                MySqlCommand comando = new MySqlCommand(comandd, conexionprograma);
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    txbcontraconf.Text = (lector.GetValue(lector.GetOrdinal("contraseña")).ToString());
                }
                conexionprograma.Close();
            }
            else
            {
                txbusucre.Text = "";
                txbcedula.Text = "";
                txbcontraconf.Text = "";
            }
            
        }
    }
}
