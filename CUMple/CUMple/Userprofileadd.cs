﻿using System;
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
    public partial class Userprofileadd : Form
    {
        public Userprofileadd()
        {
            InitializeComponent();
        }

        MySqlConnection conexionprograma = new MySqlConnection("Server=localhost; Database=programa; uid=root; pwd=;");

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string aviso = "Es necesario rellenar los siguientes campos:";
            int taekwondobool, krav_magabool, camposincompletos = 0;            
            if (chbtaekwondo.Checked == true){
                taekwondobool = 1;
            }else{
                taekwondobool = 0;
            }
            if (chbkrav.Checked == true){
                krav_magabool = 1;
            }else{
                krav_magabool = 0;
            }
            if (txbnombrecompleto.Text == "")
            {
                aviso = aviso + "\n-Nombre completo";
                camposincompletos++;
            }          
            if (txbcedula.Text == "")
            {
                aviso = aviso + "\n-Cedula";
                camposincompletos++;
            }
            if (txbcelular.Text == "")
            {
                aviso = aviso + "\n-Celular";
                camposincompletos++;
            }
            if (krav_magabool == 0 && taekwondobool == 0)
            {
                aviso = aviso + "\n-Disciplina";
                camposincompletos++;
            }
            if (txbprofesion.Text == "")
            {
                aviso = aviso + "\n-Profesion";
                camposincompletos++;
            }
            if (dtpfec_nac.ToString() == dtpfechadeingreso.ToString())
            {
                aviso = aviso + "\n-Fecha de nacimiento";
                camposincompletos++;
            }
            if (txbemail.Text == "")
            {
                aviso = aviso + "\n-Email";
                camposincompletos++;
            }
            if (camposincompletos == 0)
            {
                agregarusuario(txbnombrecompleto.Text, txbcedula.ToString(), txbcelular.ToString(), txbprofesion.Text, dtpfec_nac.ToString(), txbemail.Text, taekwondobool, krav_magabool, dtpfechadeingreso.ToString());
                /*
                conexionprograma.Open();
                string comando = "insert into discipulos values ('" + txbcelular.ToString()+ "', '" + dtpfechadeingreso.ToString()+ "', '" + txbnombrecompleto.ToString()+ "', '" + krav_magabool+ "', '" + taekwondobool+ "', '" + txbprofesion.ToString()+ "', '" + dtpfec_nac.ToString()+ "', '" + txbemail.ToString()+ "');";
                MySqlCommand comandoeditarusuario = new MySqlCommand(comando, conexionprograma);
                try
                {
                    comandoeditarusuario.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("El usuario se ha creado correctamente");
                conexionprograma.Close();
                */
            }
            else 
            {
                MessageBox.Show(""+aviso);
            }
        }
        
        public void agregarusuario(string nombrecompleto, string cedula , string celular, string profesion, string fech_nac, string email, int taekwondo, int krav, string fech_ingreso)
        { 
            
            conexionprograma.Open();
            string comando = "insert into discipulos values ('" + celular + "', '" + fech_ingreso + "', '" + nombrecompleto + "', '" + krav + "', '" + taekwondo + "', '" + profesion + "', '" + fech_nac + "', '" + email + "');";
            MySqlCommand comandoeditarusuario = new MySqlCommand(comando, conexionprograma);
            try
            {
                comandoeditarusuario.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("El usuario se ha creado correctamente");
            conexionprograma.Close();
        }
        
        

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnvolveruserprofile_Click(object sender, EventArgs e)
        {
            new formadmin().Show();
            this.Dispose();
        }

        private void cerrarclic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }
    }
}