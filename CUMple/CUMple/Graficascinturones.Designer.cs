
namespace CUMple
{
    partial class Graficascinturones
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
            this.Graficadecinturones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbfiltrarrangos = new System.Windows.Forms.ComboBox();
            this.btncargarcinturones = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Graficadecinturones)).BeginInit();
            this.SuspendLayout();
            // 
            // Graficadecinturones
            // 
            this.Graficadecinturones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Graficadecinturones.BackColor = System.Drawing.Color.Transparent;
            this.Graficadecinturones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Graficadecinturones.BorderlineColor = System.Drawing.Color.Transparent;
            this.Graficadecinturones.BorderSkin.BorderColor = System.Drawing.Color.White;
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
            this.Graficadecinturones.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            legend1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.Graficadecinturones.Legends.Add(legend1);
            this.Graficadecinturones.Location = new System.Drawing.Point(286, 111);
            this.Graficadecinturones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Graficadecinturones.Name = "Graficadecinturones";
            this.Graficadecinturones.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Cinturones";
            this.Graficadecinturones.Series.Add(series1);
            this.Graficadecinturones.Size = new System.Drawing.Size(921, 518);
            this.Graficadecinturones.TabIndex = 1;
            this.Graficadecinturones.Text = "chart1";
            // 
            // cmbfiltrarrangos
            // 
            this.cmbfiltrarrangos.FormattingEnabled = true;
            this.cmbfiltrarrangos.Location = new System.Drawing.Point(26, 65);
            this.cmbfiltrarrangos.Name = "cmbfiltrarrangos";
            this.cmbfiltrarrangos.Size = new System.Drawing.Size(208, 28);
            this.cmbfiltrarrangos.TabIndex = 2;
            this.cmbfiltrarrangos.Text = "Filtrar:";
            // 
            // btncargarcinturones
            // 
            this.btncargarcinturones.Location = new System.Drawing.Point(26, 142);
            this.btncargarcinturones.Name = "btncargarcinturones";
            this.btncargarcinturones.Size = new System.Drawing.Size(208, 48);
            this.btncargarcinturones.TabIndex = 4;
            this.btncargarcinturones.Text = "cargar";
            this.btncargarcinturones.UseVisualStyleBackColor = true;
            this.btncargarcinturones.Click += new System.EventHandler(this.btncargarcinturones_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(26, 216);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(208, 48);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // dtpfecha
            // 
            this.dtpfecha.CustomFormat = "yyyy-MM-dd";
            this.dtpfecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(286, 65);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(184, 37);
            this.dtpfecha.TabIndex = 43;
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dtpfec_nac_ValueChanged);
            // 
            // Graficascinturones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 842);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btncargarcinturones);
            this.Controls.Add(this.cmbfiltrarrangos);
            this.Controls.Add(this.Graficadecinturones);
            this.Name = "Graficascinturones";
            this.Text = "Graficascinturones";
            this.Load += new System.EventHandler(this.Graficascinturones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graficadecinturones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graficadecinturones;
        private System.Windows.Forms.ComboBox cmbfiltrarrangos;
        private System.Windows.Forms.Button btncargarcinturones;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.DateTimePicker dtpfecha;
    }
}