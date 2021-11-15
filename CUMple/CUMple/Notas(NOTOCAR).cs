using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUMple
{
    class Notas_NOTOCAR_
    {
        /*
        DataTable dtexamenes = new DataTable();



                if (cbdisciplina.SelectedIndex != -1 && Fechadatatimer.Enabled == false && horadatatimer.Enabled == false && txbexaminadores.Text == "")
            
                {
                string comandostring = "select * from examenes where disciplina='" + cbdisciplina.SelectedItem.ToString() + "';";
        MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

                try
                {
                    conexionbd.Open();
                    dgvexamenes.Refresh();
                    comandotraerexamenes.Fill(dtexamenes);
                    dgvexamenes.DataSource = dtexamenes;

                    if (dgvexamenes.Rows[0].Cells[0].Value == null)
                    {
                        MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
                        conexionbd.Close();
                        dgvexamenes.DataSource = cargarexamenes();
        limpiar();
    }

}
                catch (Exception ex)
{
    MessageBox.Show(ex.ToString());
}

limpiar();
            }

            else if (cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == true && horadatatimer.Enabled == false && txbexaminadores.Text == "")
{
    string comandostring = "select * from examenes where fecha='" + Fechadatatimer.Text + "';";
    MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

    try
    {
        conexionbd.Open();
        dgvexamenes.Refresh();
        comandotraerexamenes.Fill(dtexamenes);
        dgvexamenes.DataSource = dtexamenes;
        if (dgvexamenes.Rows[0].Cells[0].Value == null)
        {
            MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
            conexionbd.Close();
            dgvexamenes.DataSource = cargarexamenes();
            limpiar();
        }

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }

    limpiar();
}

else if (cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == false && horadatatimer.Enabled == true && txbexaminadores.Text == "")
{
    string comandostring = "select * from examenes where hora='" + horadatatimer.Text + "';";
    MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

    try
    {
        conexionbd.Open();
        dgvexamenes.Refresh();
        comandotraerexamenes.Fill(dtexamenes);
        dgvexamenes.DataSource = dtexamenes;
        if (dgvexamenes.Rows[0].Cells[0].Value == null)
        {
            MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
            dgvexamenes.DataSource = cargarexamenes();
            limpiar();
        }

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }

    limpiar();
}
else if (cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == false && horadatatimer.Enabled == false && txbexaminadores.Text != "")
{
    string comandostring = "select * from examenes where examinadores='" + txbexaminadores.Text + "';";
    MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

    try
    {
        conexionbd.Open();
        dgvexamenes.DataSource = null;
        comandotraerexamenes.Fill(dtexamenes);
        dgvexamenes.DataSource = dtexamenes;
        if (dgvexamenes.Rows[0].Cells[0].Value == null)
        {
            MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
            conexionbd.Close();
            dgvexamenes.DataSource = cargarexamenes();
            limpiar();
        }

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }

    limpiar();
}
else if (cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == true && horadatatimer.Enabled == false && txbexaminadores.Text != "")
{
    string comandostring = "select * from examenes where examinadores='" + txbexaminadores.Text + "' and fecha='" + Fechadatatimer.Text + "';";
    MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

    try
    {
        conexionbd.Open();
        dgvexamenes.Refresh();
        comandotraerexamenes.Fill(dtexamenes);
        dgvexamenes.DataSource = dtexamenes;
        if (dgvexamenes.Rows[0].Cells[0].Value == null)
        {
            MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
            conexionbd.Close();
            dgvexamenes.DataSource = cargarexamenes();
            limpiar();


        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }

    limpiar();
}

else if (cbdisciplina.SelectedIndex == -1 && Fechadatatimer.Enabled == true && horadatatimer.Enabled == true && txbexaminadores.Text == "")
{
    string comandostring = "select * from examenes where fecha='" + Fechadatatimer.Text + "' and hora='" + horadatatimer.Text + "';";
    MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

    try
    {
        conexionbd.Open();
        dgvexamenes.Refresh();
        comandotraerexamenes.Fill(dtexamenes);
        dgvexamenes.DataSource = dtexamenes;
        if (dgvexamenes.Rows[0].Cells[0].Value == null)
        {
            MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
            conexionbd.Close();
            dgvexamenes.DataSource = cargarexamenes();
            limpiar();
        }

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }

    limpiar();
}
else if (cbdisciplina.SelectedIndex != -1 && Fechadatatimer.Enabled == true && horadatatimer.Enabled == true && txbexaminadores.Text == "")
{
    string comandostring = "select * from examenes where fecha='" + Fechadatatimer.Text + "' and hora='" + horadatatimer.Text + "' and disciplina='" + cbdisciplina.SelectedItem + "';";
    MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

    try
    {
        conexionbd.Open();
        dgvexamenes.Refresh();
        comandotraerexamenes.Fill(dtexamenes);
        dgvexamenes.DataSource = dtexamenes;
        if (dgvexamenes.Rows[0].Cells[0].Value == null)
        {
            MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
            conexionbd.Close();
            dgvexamenes.DataSource = cargarexamenes();
            limpiar();
        }

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }

    limpiar();
}
else if (cbdisciplina.SelectedIndex != -1 && Fechadatatimer.Enabled == true && horadatatimer.Enabled == true && txbexaminadores.Text != "")
{
    string comandostring = "select * from examenes where fecha='" + Fechadatatimer.Text + "' and hora='" + horadatatimer.Text + "' and disciplina='" + cbdisciplina.SelectedItem + "' and examinadores='" + txbexaminadores.Text + "';";
    MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

    try
    {
        conexionbd.Open();
        dgvexamenes.Refresh();
        comandotraerexamenes.Fill(dtexamenes);
        dgvexamenes.DataSource = dtexamenes;
        if (dgvexamenes.Rows[0].Cells[0].Value == null)
        {
            MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
            conexionbd.Close();
            dgvexamenes.DataSource = cargarexamenes();
            limpiar();
        }

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }

    limpiar();
}
else if (cbdisciplina.SelectedIndex != -1 && Fechadatatimer.Enabled == true && horadatatimer.Enabled == true && txbexaminadores.Text != "")
{
    string comandostring = "select * from examenes where fecha='" + Fechadatatimer.Text + "' and hora='" + horadatatimer.Text + "' and disciplina='" + cbdisciplina.SelectedItem + "' and examinadores='" + txbexaminadores.Text + "';";
    MySqlDataAdapter comandotraerexamenes = new MySqlDataAdapter(comandostring, conexionbd);

    try
    {
        conexionbd.Open();
        dgvexamenes.Refresh();
        comandotraerexamenes.Fill(dtexamenes);
        dgvexamenes.DataSource = dtexamenes;
        if (dgvexamenes.Rows[0].Cells[0].Value == null)
        {
            MessageBox.Show("El exámen no se ha encontrado. Prueba utilizando otros parametros");
            conexionbd.Close();
            dgvexamenes.DataSource = cargarexamenes();
            limpiar();
        }

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }

    limpiar();
}


conexionbd.Close();
        */
    }
}
