
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
            this.Graficadealumnos.Location = new System.Drawing.Point(-7, -1);
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
            this.Graficadealumnos.Size = new System.Drawing.Size(670, 523);
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
            this.cmbmeses.Location = new System.Drawing.Point(552, 49);
            this.cmbmeses.Name = "cmbmeses";
            this.cmbmeses.Size = new System.Drawing.Size(86, 21);
            this.cmbmeses.TabIndex = 4;
            this.cmbmeses.Text = "Mes:";
            this.cmbmeses.SelectedIndexChanged += new System.EventHandler(this.comboxmeses_SelectedIndexChanged);
            // 
            // Pruebadeconexiom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 522);
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
    }
}