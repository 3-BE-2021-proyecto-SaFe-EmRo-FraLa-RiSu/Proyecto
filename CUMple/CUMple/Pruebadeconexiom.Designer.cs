
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pruebadeconexiom));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbmeses = new System.Windows.Forms.ComboBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.btncargardatos = new System.Windows.Forms.Button();
            this.btnvolverpruebaconexion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.cerrarclic = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Graficadealumnos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graficadealumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbmeses
            // 
            this.cmbmeses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbmeses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cmbmeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbmeses.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmeses.ForeColor = System.Drawing.Color.White;
            this.cmbmeses.FormattingEnabled = true;
            this.cmbmeses.Items.AddRange(new object[] {
            "Ninguno",
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
            this.cmbmeses.Location = new System.Drawing.Point(199, 146);
            this.cmbmeses.Name = "cmbmeses";
            this.cmbmeses.Size = new System.Drawing.Size(114, 26);
            this.cmbmeses.TabIndex = 1;
            this.cmbmeses.Text = "Mes:";
            this.cmbmeses.SelectedIndexChanged += new System.EventHandler(this.comboxmeses_SelectedIndexChanged);
            // 
            // cmbAño
            // 
            this.cmbAño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cmbAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAño.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAño.ForeColor = System.Drawing.Color.White;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(199, 204);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(114, 26);
            this.cmbAño.TabIndex = 2;
            this.cmbAño.Text = "Año:";
            this.cmbAño.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btncargardatos
            // 
            this.btncargardatos.FlatAppearance.BorderSize = 0;
            this.btncargardatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btncargardatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargardatos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargardatos.ForeColor = System.Drawing.SystemColors.Window;
            this.btncargardatos.Location = new System.Drawing.Point(3, 55);
            this.btncargardatos.Name = "btncargardatos";
            this.btncargardatos.Size = new System.Drawing.Size(163, 44);
            this.btncargardatos.TabIndex = 3;
            this.btncargardatos.Text = "Cargar";
            this.btncargardatos.UseVisualStyleBackColor = true;
            this.btncargardatos.Click += new System.EventHandler(this.btncargardatos_Click);
            // 
            // btnvolverpruebaconexion
            // 
            this.btnvolverpruebaconexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnvolverpruebaconexion.FlatAppearance.BorderSize = 0;
            this.btnvolverpruebaconexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnvolverpruebaconexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolverpruebaconexion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverpruebaconexion.ForeColor = System.Drawing.Color.Transparent;
            this.btnvolverpruebaconexion.Location = new System.Drawing.Point(3, 142);
            this.btnvolverpruebaconexion.Name = "btnvolverpruebaconexion";
            this.btnvolverpruebaconexion.Size = new System.Drawing.Size(163, 42);
            this.btnvolverpruebaconexion.TabIndex = 4;
            this.btnvolverpruebaconexion.Text = "Volver";
            this.btnvolverpruebaconexion.UseVisualStyleBackColor = false;
            this.btnvolverpruebaconexion.Click += new System.EventHandler(this.btnvolvercrearlosusuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.restaurar);
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.cerrarclic);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restaurar.Image = ((System.Drawing.Image)(resources.GetObject("restaurar.Image")));
            this.restaurar.Location = new System.Drawing.Point(1008, 2);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(37, 30);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar.TabIndex = 15;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(961, 2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(37, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 14;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrarclic
            // 
            this.cerrarclic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarclic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cerrarclic.Image = ((System.Drawing.Image)(resources.GetObject("cerrarclic.Image")));
            this.cerrarclic.Location = new System.Drawing.Point(1051, 2);
            this.cerrarclic.Name = "cerrarclic";
            this.cerrarclic.Size = new System.Drawing.Size(37, 30);
            this.cerrarclic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarclic.TabIndex = 13;
            this.cerrarclic.TabStop = false;
            this.cerrarclic.Click += new System.EventHandler(this.cerrarclic_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1004, 2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(37, 30);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 12;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panelapoyo1);
            this.panel2.Controls.Add(this.btnvolverpruebaconexion);
            this.panel2.Controls.Add(this.btncargardatos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 565);
            this.panel2.TabIndex = 13;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(7, 42);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // panelapoyo1
            // 
            this.panelapoyo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo1.Location = new System.Drawing.Point(0, 55);
            this.panelapoyo1.Name = "panelapoyo1";
            this.panelapoyo1.Size = new System.Drawing.Size(5, 44);
            this.panelapoyo1.TabIndex = 22;
            // 
            // Graficadealumnos
            // 
            this.Graficadealumnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Graficadealumnos.BackColor = System.Drawing.Color.Transparent;
            this.Graficadealumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Graficadealumnos.BorderlineColor = System.Drawing.Color.Transparent;
            this.Graficadealumnos.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.Graficadealumnos.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            legend1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.Graficadealumnos.Legends.Add(legend1);
            this.Graficadealumnos.Location = new System.Drawing.Point(377, 63);
            this.Graficadealumnos.Name = "Graficadealumnos";
            this.Graficadealumnos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(24)))));
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Asistencias";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Faltas";
            this.Graficadealumnos.Series.Add(series1);
            this.Graficadealumnos.Series.Add(series2);
            this.Graficadealumnos.Size = new System.Drawing.Size(686, 501);
            this.Graficadealumnos.TabIndex = 24;
            this.Graficadealumnos.Text = "chart1";
            // 
            // Pruebadeconexiom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.Graficadealumnos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbmeses);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pruebadeconexiom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pruebadeconexiom";
            this.Load += new System.EventHandler(this.Pruebadeconexiom_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pruebadeconexiom_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graficadealumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbmeses;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Button btncargardatos;
        private System.Windows.Forms.Button btnvolverpruebaconexion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox cerrarclic;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graficadealumnos;
    }
}