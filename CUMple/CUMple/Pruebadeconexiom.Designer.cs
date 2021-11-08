
namespace CUMple
{
    partial class Pruebadeconexiom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pruebadeconexiom));
            this.Graficadealumnos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbmeses = new System.Windows.Forms.ComboBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.btncargardatos = new System.Windows.Forms.Button();
            this.btncargarmeses = new System.Windows.Forms.Button();
            this.btncargaraños = new System.Windows.Forms.Button();
            this.btnvolverpruebaconexion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.cerrarclic = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Graficadealumnos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // Graficadealumnos
            // 
            this.Graficadealumnos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Graficadealumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.Graficadealumnos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graficadealumnos.Legends.Add(legend1);
            this.Graficadealumnos.Location = new System.Drawing.Point(285, 135);
            this.Graficadealumnos.Name = "Graficadealumnos";
            this.Graficadealumnos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Asistencias";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Faltas";
            this.Graficadealumnos.Series.Add(series1);
            this.Graficadealumnos.Series.Add(series2);
            this.Graficadealumnos.Size = new System.Drawing.Size(633, 453);
            this.Graficadealumnos.TabIndex = 0;
            this.Graficadealumnos.Text = "chart1";
            this.Graficadealumnos.Click += new System.EventHandler(this.Graficadealumnos_Click_1);
            // 
            // cmbmeses
            // 
            this.cmbmeses.FormattingEnabled = true;
            this.cmbmeses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbmeses.Location = new System.Drawing.Point(957, 167);
            this.cmbmeses.Name = "cmbmeses";
            this.cmbmeses.Size = new System.Drawing.Size(86, 21);
            this.cmbmeses.TabIndex = 4;
            this.cmbmeses.Text = "Mes:";
            this.cmbmeses.SelectedIndexChanged += new System.EventHandler(this.comboxmeses_SelectedIndexChanged);
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(957, 206);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(86, 21);
            this.cmbAño.TabIndex = 5;
            this.cmbAño.Text = "Año:";
            this.cmbAño.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btncargardatos
            // 
            this.btncargardatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargardatos.Location = new System.Drawing.Point(957, 248);
            this.btncargardatos.Name = "btncargardatos";
            this.btncargardatos.Size = new System.Drawing.Size(86, 25);
            this.btncargardatos.TabIndex = 7;
            this.btncargardatos.Text = "Cargar";
            this.btncargardatos.UseVisualStyleBackColor = true;
            this.btncargardatos.Click += new System.EventHandler(this.btncargardatos_Click);
            // 
            // btncargarmeses
            // 
            this.btncargarmeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargarmeses.Location = new System.Drawing.Point(957, 297);
            this.btncargarmeses.Name = "btncargarmeses";
            this.btncargarmeses.Size = new System.Drawing.Size(86, 39);
            this.btncargarmeses.TabIndex = 8;
            this.btncargarmeses.Text = "Cargar todos los meses";
            this.btncargarmeses.UseVisualStyleBackColor = true;
            this.btncargarmeses.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btncargaraños
            // 
            this.btncargaraños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargaraños.Location = new System.Drawing.Point(957, 354);
            this.btncargaraños.Name = "btncargaraños";
            this.btncargaraños.Size = new System.Drawing.Size(86, 39);
            this.btncargaraños.TabIndex = 9;
            this.btncargaraños.Text = "Cargar todos los años";
            this.btncargaraños.UseVisualStyleBackColor = true;
            this.btncargaraños.Click += new System.EventHandler(this.btncargaraños_Click);
            // 
            // btnvolverpruebaconexion
            // 
            this.btnvolverpruebaconexion.BackColor = System.Drawing.Color.DarkRed;
            this.btnvolverpruebaconexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvolverpruebaconexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverpruebaconexion.ForeColor = System.Drawing.Color.Transparent;
            this.btnvolverpruebaconexion.Location = new System.Drawing.Point(1000, 531);
            this.btnvolverpruebaconexion.Name = "btnvolverpruebaconexion";
            this.btnvolverpruebaconexion.Size = new System.Drawing.Size(43, 42);
            this.btnvolverpruebaconexion.TabIndex = 10;
            this.btnvolverpruebaconexion.Text = "⮎";
            this.btnvolverpruebaconexion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnvolverpruebaconexion.UseVisualStyleBackColor = false;
            this.btnvolverpruebaconexion.Click += new System.EventHandler(this.btnvolvercrearlosusuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.restaurar);
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.cerrarclic);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 112);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 488);
            this.panel2.TabIndex = 13;
            // 
            // restaurar
            // 
            this.restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restaurar.Image = ((System.Drawing.Image)(resources.GetObject("restaurar.Image")));
            this.restaurar.Location = new System.Drawing.Point(988, 30);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(41, 42);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restaurar.TabIndex = 15;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // minimizar
            // 
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(941, 30);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(41, 42);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 14;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrarclic
            // 
            this.cerrarclic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cerrarclic.Image = ((System.Drawing.Image)(resources.GetObject("cerrarclic.Image")));
            this.cerrarclic.Location = new System.Drawing.Point(1035, 30);
            this.cerrarclic.Name = "cerrarclic";
            this.cerrarclic.Size = new System.Drawing.Size(41, 42);
            this.cerrarclic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrarclic.TabIndex = 13;
            this.cerrarclic.TabStop = false;
            this.cerrarclic.Click += new System.EventHandler(this.cerrarclic_Click);
            // 
            // maximizar
            // 
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(988, 30);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(41, 42);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizar.TabIndex = 12;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // Pruebadeconexiom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnvolverpruebaconexion);
            this.Controls.Add(this.btncargaraños);
            this.Controls.Add(this.btncargarmeses);
            this.Controls.Add(this.btncargardatos);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.cmbmeses);
            this.Controls.Add(this.Graficadealumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pruebadeconexiom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pruebadeconexiom";
            this.Load += new System.EventHandler(this.Pruebadeconexiom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graficadealumnos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graficadealumnos;
        private System.Windows.Forms.ComboBox cmbmeses;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Button btncargardatos;
        private System.Windows.Forms.Button btncargarmeses;
        private System.Windows.Forms.Button btncargaraños;
        private System.Windows.Forms.Button btnvolverpruebaconexion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox cerrarclic;
        private System.Windows.Forms.PictureBox maximizar;
    }
}