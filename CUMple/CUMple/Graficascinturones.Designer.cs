
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graficadecinturones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnvolver = new System.Windows.Forms.Button();
            this.Fechadatatimer = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
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
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.Graficadecinturones.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            legend3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.Graficadecinturones.Legends.Add(legend3);
            this.Graficadecinturones.Location = new System.Drawing.Point(187, 37);
            this.Graficadecinturones.Name = "Graficadecinturones";
            this.Graficadecinturones.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "rango";
            this.Graficadecinturones.Series.Add(series3);
            this.Graficadecinturones.Size = new System.Drawing.Size(614, 337);
            this.Graficadecinturones.TabIndex = 1;
            this.Graficadecinturones.Text = "chart1";
            this.Graficadecinturones.Click += new System.EventHandler(this.Graficadecinturones_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(25, 302);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(139, 31);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // Fechadatatimer
            // 
            this.Fechadatatimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fechadatatimer.CustomFormat = "yyyy-MM-dd";
            this.Fechadatatimer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechadatatimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fechadatatimer.Location = new System.Drawing.Point(37, 52);
            this.Fechadatatimer.Name = "Fechadatatimer";
            this.Fechadatatimer.Size = new System.Drawing.Size(127, 27);
            this.Fechadatatimer.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Graficascinturones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fechadatatimer);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.Graficadecinturones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Graficascinturones";
            this.Text = "Graficascinturones";
            this.Load += new System.EventHandler(this.Graficascinturones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graficadecinturones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graficadecinturones;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.DateTimePicker Fechadatatimer;
        private System.Windows.Forms.Button button1;
    }
}