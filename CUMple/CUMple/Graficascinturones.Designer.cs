
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graficascinturones));
            this.Graficadecinturones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Fechadatatimer = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnvolveruserprofile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.cerrarclic = new System.Windows.Forms.PictureBox();
            this.restaurar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Graficadecinturones)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // Graficadecinturones
            // 
            this.Graficadecinturones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Graficadecinturones.BackColor = System.Drawing.Color.Transparent;
            this.Graficadecinturones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Graficadecinturones.BorderlineColor = System.Drawing.Color.Transparent;
            this.Graficadecinturones.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.AxisX.Interval = 1D;
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
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.Graficadecinturones.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            legend1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.Graficadecinturones.Legends.Add(legend1);
            this.Graficadecinturones.Location = new System.Drawing.Point(332, 60);
            this.Graficadecinturones.Name = "Graficadecinturones";
            this.Graficadecinturones.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Rangos";
            this.Graficadecinturones.Series.Add(series1);
            this.Graficadecinturones.Size = new System.Drawing.Size(749, 579);
            this.Graficadecinturones.TabIndex = 1;
            this.Graficadecinturones.Text = "chart1";
            this.Graficadecinturones.Click += new System.EventHandler(this.Graficadecinturones_Click);
            // 
            // Fechadatatimer
            // 
            this.Fechadatatimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fechadatatimer.CustomFormat = "yyyy-MM-dd";
            this.Fechadatatimer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechadatatimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fechadatatimer.Location = new System.Drawing.Point(199, 111);
            this.Fechadatatimer.Name = "Fechadatatimer";
            this.Fechadatatimer.Size = new System.Drawing.Size(127, 27);
            this.Fechadatatimer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panelapoyo2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnvolveruserprofile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 633);
            this.panel1.TabIndex = 49;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 266);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(5, 44);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // panelapoyo2
            // 
            this.panelapoyo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo2.Location = new System.Drawing.Point(0, 176);
            this.panelapoyo2.Name = "panelapoyo2";
            this.panelapoyo2.Size = new System.Drawing.Size(5, 44);
            this.panelapoyo2.TabIndex = 20;
            // 
            // btnvolveruserprofile
            // 
            this.btnvolveruserprofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnvolveruserprofile.FlatAppearance.BorderSize = 0;
            this.btnvolveruserprofile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnvolveruserprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolveruserprofile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolveruserprofile.ForeColor = System.Drawing.Color.Transparent;
            this.btnvolveruserprofile.Location = new System.Drawing.Point(4, 266);
            this.btnvolveruserprofile.Margin = new System.Windows.Forms.Padding(2);
            this.btnvolveruserprofile.Name = "btnvolveruserprofile";
            this.btnvolveruserprofile.Size = new System.Drawing.Size(161, 44);
            this.btnvolveruserprofile.TabIndex = 3;
            this.btnvolveruserprofile.Text = "Volver";
            this.btnvolveruserprofile.UseVisualStyleBackColor = false;
            this.btnvolveruserprofile.Click += new System.EventHandler(this.btnvolveruserprofile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.maximizar);
            this.panel2.Controls.Add(this.minimizar);
            this.panel2.Controls.Add(this.cerrarclic);
            this.panel2.Controls.Add(this.restaurar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 35);
            this.panel2.TabIndex = 48;
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1032, 5);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(37, 30);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 27;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(989, 2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(37, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 26;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrarclic
            // 
            this.cerrarclic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarclic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cerrarclic.Image = ((System.Drawing.Image)(resources.GetObject("cerrarclic.Image")));
            this.cerrarclic.Location = new System.Drawing.Point(1075, 2);
            this.cerrarclic.Name = "cerrarclic";
            this.cerrarclic.Size = new System.Drawing.Size(37, 30);
            this.cerrarclic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarclic.TabIndex = 25;
            this.cerrarclic.TabStop = false;
            this.cerrarclic.Click += new System.EventHandler(this.cerrarclic_Click);
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restaurar.Image = ((System.Drawing.Image)(resources.GetObject("restaurar.Image")));
            this.restaurar.Location = new System.Drawing.Point(1032, 2);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(37, 30);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.restaurar.TabIndex = 28;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // Graficascinturones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1113, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Fechadatatimer);
            this.Controls.Add(this.Graficadecinturones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Graficascinturones";
            this.Text = "Graficascinturones";
            this.Load += new System.EventHandler(this.Graficascinturones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graficadecinturones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graficadecinturones;
        private System.Windows.Forms.DateTimePicker Fechadatatimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo2;
        private System.Windows.Forms.Button btnvolveruserprofile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox cerrarclic;
        private System.Windows.Forms.PictureBox restaurar;
    }
}