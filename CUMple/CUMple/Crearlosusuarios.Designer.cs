﻿
namespace CUMple
{
    partial class Editarusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editarusuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txbusucre = new System.Windows.Forms.TextBox();
            this.txtbcontra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btcrearusuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkboxadmin = new System.Windows.Forms.CheckBox();
            this.txbcontraconf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnborrarusuario = new System.Windows.Forms.Button();
            this.btneditarusuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // txbusucre
            // 
            this.txbusucre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbusucre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbusucre.Location = new System.Drawing.Point(238, 186);
            this.txbusucre.Name = "txbusucre";
            this.txbusucre.Size = new System.Drawing.Size(245, 35);
            this.txbusucre.TabIndex = 1;
            this.txbusucre.TextChanged += new System.EventHandler(this.txbusucre_TextChanged);
            // 
            // txtbcontra
            // 
            this.txtbcontra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbcontra.Location = new System.Drawing.Point(238, 229);
            this.txtbcontra.Name = "txtbcontra";
            this.txtbcontra.Size = new System.Drawing.Size(245, 35);
            this.txtbcontra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(16, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "⮎";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btcrearusuario
            // 
            this.btcrearusuario.BackColor = System.Drawing.Color.LimeGreen;
            this.btcrearusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btcrearusuario.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcrearusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btcrearusuario.Location = new System.Drawing.Point(276, 315);
            this.btcrearusuario.Name = "btcrearusuario";
            this.btcrearusuario.Size = new System.Drawing.Size(160, 36);
            this.btcrearusuario.TabIndex = 5;
            this.btcrearusuario.Text = "Crear usuario";
            this.btcrearusuario.UseVisualStyleBackColor = false;
            this.btcrearusuario.Click += new System.EventHandler(this.btcrearusuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Editar usuarios";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = global::CUMple.Properties.Resources.logo_live_messenger_msn_Messenger_ShurKonrad_2013_2_;
            this.label4.Location = new System.Drawing.Point(284, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 108);
            this.label4.TabIndex = 8;
            // 
            // chkboxadmin
            // 
            this.chkboxadmin.AutoSize = true;
            this.chkboxadmin.Location = new System.Drawing.Point(442, 357);
            this.chkboxadmin.Name = "chkboxadmin";
            this.chkboxadmin.Size = new System.Drawing.Size(89, 17);
            this.chkboxadmin.TabIndex = 9;
            this.chkboxadmin.Text = "Administrador";
            this.chkboxadmin.UseVisualStyleBackColor = true;
            this.chkboxadmin.CheckedChanged += new System.EventHandler(this.chkboxadmin_CheckedChanged);
            // 
            // txbcontraconf
            // 
            this.txbcontraconf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbcontraconf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcontraconf.Location = new System.Drawing.Point(238, 270);
            this.txbcontraconf.Name = "txbcontraconf";
            this.txbcontraconf.Size = new System.Drawing.Size(245, 35);
            this.txbcontraconf.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirmar contraseña";
            // 
            // btnborrarusuario
            // 
            this.btnborrarusuario.BackColor = System.Drawing.Color.DarkRed;
            this.btnborrarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrarusuario.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrarusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnborrarusuario.Location = new System.Drawing.Point(276, 357);
            this.btnborrarusuario.Name = "btnborrarusuario";
            this.btnborrarusuario.Size = new System.Drawing.Size(160, 36);
            this.btnborrarusuario.TabIndex = 12;
            this.btnborrarusuario.Text = "Borrar usuario";
            this.btnborrarusuario.UseVisualStyleBackColor = false;
            this.btnborrarusuario.Click += new System.EventHandler(this.btnborrarusuario_Click);
            // 
            // btneditarusuario
            // 
            this.btneditarusuario.BackColor = System.Drawing.Color.Olive;
            this.btneditarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditarusuario.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditarusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneditarusuario.Location = new System.Drawing.Point(274, 399);
            this.btneditarusuario.Name = "btneditarusuario";
            this.btneditarusuario.Size = new System.Drawing.Size(160, 36);
            this.btneditarusuario.TabIndex = 13;
            this.btneditarusuario.Text = "Editar usuario";
            this.btneditarusuario.UseVisualStyleBackColor = false;
            this.btneditarusuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // Editarusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CUMple.Properties.Resources.logo_de_Academia_DO_difuminado_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(609, 457);
            this.Controls.Add(this.btneditarusuario);
            this.Controls.Add(this.btnborrarusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbcontraconf);
            this.Controls.Add(this.chkboxadmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btcrearusuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbcontra);
            this.Controls.Add(this.txbusucre);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editarusuarios";
            this.Text = "Editar usuarios";
            this.Load += new System.EventHandler(this.Crearlosusuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbusucre;
        private System.Windows.Forms.TextBox txtbcontra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btcrearusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkboxadmin;
        private System.Windows.Forms.TextBox txbcontraconf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnborrarusuario;
        private System.Windows.Forms.Button btneditarusuario;
    }
}