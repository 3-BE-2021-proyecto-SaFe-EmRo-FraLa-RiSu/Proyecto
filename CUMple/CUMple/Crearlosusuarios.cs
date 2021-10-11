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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btcrearusuario_Click(object sender, EventArgs e)
        {
          if (txbusucre.Text=="" || txtbcontra.Text=="" || txbcontraconf.Text == "")
            {
                MessageBox.Show("Ningún campo puede estar vacio");

            }
          else { 
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
                    throw;
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
                throw;
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
    }
}
