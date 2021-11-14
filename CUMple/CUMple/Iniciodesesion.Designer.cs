
namespace CUMple
{
    partial class forming
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forming));
            this.txbconb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbuserb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltextologin = new System.Windows.Forms.Label();
            this.logoescuela = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.cerrarclic = new System.Windows.Forms.PictureBox();
            this.panelogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoescuela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).BeginInit();
            this.SuspendLayout();
            // 
            // txbconb
            // 
            this.txbconb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txbconb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbconb.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbconb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbconb.Location = new System.Drawing.Point(346, 202);
            this.txbconb.Margin = new System.Windows.Forms.Padding(2);
            this.txbconb.Name = "txbconb";
            this.txbconb.Size = new System.Drawing.Size(400, 24);
            this.txbconb.TabIndex = 1;
            this.txbconb.Text = "Contraseña";
            this.txbconb.UseSystemPasswordChar = true;
            this.txbconb.TextChanged += new System.EventHandler(this.txbconb_TextChanged);
            this.txbconb.Enter += new System.EventHandler(this.txbconb_Enter);
            this.txbconb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbconb_KeyPress);
            this.txbconb.Leave += new System.EventHandler(this.txbconb_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(444, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelogo
            // 
            this.panelogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panelogo.Controls.Add(this.logoescuela);
            this.panelogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelogo.Location = new System.Drawing.Point(0, 0);
            this.panelogo.Name = "panelogo";
            this.panelogo.Size = new System.Drawing.Size(250, 402);
            this.panelogo.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(346, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 10;
            // 
            // txbuserb
            // 
            this.txbuserb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txbuserb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbuserb.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbuserb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbuserb.Location = new System.Drawing.Point(346, 124);
            this.txbuserb.Margin = new System.Windows.Forms.Padding(2);
            this.txbuserb.Name = "txbuserb";
            this.txbuserb.Size = new System.Drawing.Size(396, 24);
            this.txbuserb.TabIndex = 9;
            this.txbuserb.Text = "Usuario";
            this.txbuserb.Enter += new System.EventHandler(this.txbuserb_Enter);
            this.txbuserb.Leave += new System.EventHandler(this.txbuserb_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(346, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 1);
            this.panel3.TabIndex = 10;
            // 
            // lbltextologin
            // 
            this.lbltextologin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltextologin.AutoSize = true;
            this.lbltextologin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lbltextologin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextologin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbltextologin.Location = new System.Drawing.Point(529, 31);
            this.lbltextologin.Name = "lbltextologin";
            this.lbltextologin.Size = new System.Drawing.Size(57, 24);
            this.lbltextologin.TabIndex = 11;
            this.lbltextologin.Text = "Login";
            // 
            // logoescuela
            // 
            this.logoescuela.Image = global::CUMple.Properties.Resources.logo_de_Academia_DO_difuminado_;
            this.logoescuela.Location = new System.Drawing.Point(0, -3);
            this.logoescuela.Name = "logoescuela";
            this.logoescuela.Size = new System.Drawing.Size(250, 402);
            this.logoescuela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoescuela.TabIndex = 12;
            this.logoescuela.TabStop = false;
            this.logoescuela.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimizar
            // 
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(791, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(37, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 20;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrarclic
            // 
            this.cerrarclic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cerrarclic.Image = ((System.Drawing.Image)(resources.GetObject("cerrarclic.Image")));
            this.cerrarclic.Location = new System.Drawing.Point(834, 12);
            this.cerrarclic.Name = "cerrarclic";
            this.cerrarclic.Size = new System.Drawing.Size(37, 30);
            this.cerrarclic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarclic.TabIndex = 19;
            this.cerrarclic.TabStop = false;
            this.cerrarclic.Click += new System.EventHandler(this.cerrarclic_Click);
            // 
            // forming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 402);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.cerrarclic);
            this.Controls.Add(this.lbltextologin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txbuserb);
            this.Controls.Add(this.panelogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbconb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forming";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Marcoin_Load);
            this.panelogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoescuela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbconb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbuserb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltextologin;
        private System.Windows.Forms.PictureBox logoescuela;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox cerrarclic;
    }
}

