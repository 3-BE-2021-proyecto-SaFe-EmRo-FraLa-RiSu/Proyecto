﻿
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
            this.txbuserb = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbconb
            // 
            this.txbconb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbconb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbconb.Location = new System.Drawing.Point(145, 164);
            this.txbconb.Name = "txbconb";
            this.txbconb.Size = new System.Drawing.Size(229, 35);
            this.txbconb.TabIndex = 0;
            this.txbconb.UseSystemPasswordChar = true;
            this.txbconb.TextChanged += new System.EventHandler(this.txbconb_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(172, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbuserb
            // 
            this.txbuserb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbuserb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbuserb.Location = new System.Drawing.Point(145, 119);
            this.txbuserb.Name = "txbuserb";
            this.txbuserb.Size = new System.Drawing.Size(229, 35);
            this.txbuserb.TabIndex = 2;
            this.txbuserb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(40, 119);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(86, 27);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "Usuario";
            this.lblemail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblcontraseña.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.Location = new System.Drawing.Point(18, 164);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(121, 27);
            this.lblcontraseña.TabIndex = 4;
            this.lblcontraseña.Text = "Contraseña";
            this.lblcontraseña.Click += new System.EventHandler(this.lblcontraseña_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "¡Bienvenido!";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // forming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CUMple.Properties.Resources.logo_de_Academia_DO_difuminado_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(419, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txbuserb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbconb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Marcoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbconb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbuserb;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label label1;
    }
}
