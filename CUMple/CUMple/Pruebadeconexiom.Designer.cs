
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
            this.Graficadealumnos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbmeses = new System.Windows.Forms.ComboBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btncargardatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graficadealumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // Graficadealumnos
            // 
            this.Graficadealumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.Graficadealumnos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graficadealumnos.Legends.Add(legend1);
            this.Graficadealumnos.Location = new System.Drawing.Point(-1, 0);
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
            this.Graficadealumnos.Size = new System.Drawing.Size(584, 523);
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
            this.cmbmeses.Location = new System.Drawing.Point(606, 57);
            this.cmbmeses.Name = "cmbmeses";
            this.cmbmeses.Size = new System.Drawing.Size(86, 21);
            this.cmbmeses.TabIndex = 4;
            this.cmbmeses.Text = "Mes:";
            this.cmbmeses.SelectedIndexChanged += new System.EventHandler(this.comboxmeses_SelectedIndexChanged);
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(606, 125);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(86, 21);
            this.cmbAño.TabIndex = 5;
            this.cmbAño.Text = "Año:";
            this.cmbAño.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btncargardatos
            // 
            this.btncargardatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargardatos.Location = new System.Drawing.Point(606, 217);
            this.btncargardatos.Name = "btncargardatos";
            this.btncargardatos.Size = new System.Drawing.Size(86, 29);
            this.btncargardatos.TabIndex = 7;
            this.btncargardatos.Text = "Cargar";
            this.btncargardatos.UseVisualStyleBackColor = true;
            this.btncargardatos.Click += new System.EventHandler(this.btncargardatos_Click);
            // 
            // Pruebadeconexiom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 518);
            this.Controls.Add(this.btncargardatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.cmbmeses);
            this.Controls.Add(this.Graficadealumnos);
            this.Name = "Pruebadeconexiom";
            this.Text = "Pruebadeconexiom";
            this.Load += new System.EventHandler(this.Pruebadeconexiom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graficadealumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graficadealumnos;
        private System.Windows.Forms.ComboBox cmbmeses;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncargardatos;
    }
}