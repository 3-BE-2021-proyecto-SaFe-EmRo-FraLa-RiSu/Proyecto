
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
            this.btnvolvercrearlosusuarios = new System.Windows.Forms.Button();
            this.btcrearusuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // txbusucre
            // 
            this.txbusucre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbusucre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbusucre.Location = new System.Drawing.Point(420, 167);
            this.txbusucre.Name = "txbusucre";
            this.txbusucre.Size = new System.Drawing.Size(245, 35);
            this.txbusucre.TabIndex = 1;
            this.txbusucre.TextChanged += new System.EventHandler(this.txbusucre_TextChanged);
            // 
            // txtbcontra
            // 
            this.txtbcontra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbcontra.Location = new System.Drawing.Point(420, 218);
            this.txtbcontra.Name = "txtbcontra";
            this.txtbcontra.Size = new System.Drawing.Size(245, 35);
            this.txtbcontra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // btnvolvercrearlosusuarios
            // 
            this.btnvolvercrearlosusuarios.BackColor = System.Drawing.Color.DarkRed;
            this.btnvolvercrearlosusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvolvercrearlosusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolvercrearlosusuarios.ForeColor = System.Drawing.Color.Transparent;
            this.btnvolvercrearlosusuarios.Location = new System.Drawing.Point(999, 497);
            this.btnvolvercrearlosusuarios.Name = "btnvolvercrearlosusuarios";
            this.btnvolvercrearlosusuarios.Size = new System.Drawing.Size(43, 42);
            this.btnvolvercrearlosusuarios.TabIndex = 4;
            this.btnvolvercrearlosusuarios.Text = "⮎";
            this.btnvolvercrearlosusuarios.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnvolvercrearlosusuarios.UseVisualStyleBackColor = false;
            this.btnvolvercrearlosusuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btcrearusuario
            // 
            this.btcrearusuario.BackColor = System.Drawing.Color.LimeGreen;
            this.btcrearusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btcrearusuario.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcrearusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btcrearusuario.Location = new System.Drawing.Point(788, 357);
            this.btcrearusuario.Name = "btcrearusuario";
            this.btcrearusuario.Size = new System.Drawing.Size(162, 36);
            this.btcrearusuario.TabIndex = 5;
            this.btcrearusuario.Text = "Crear usuario";
            this.btcrearusuario.UseVisualStyleBackColor = false;
            this.btcrearusuario.Click += new System.EventHandler(this.btcrearusuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Editar usuarios";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkboxadmin
            // 
            this.chkboxadmin.AutoSize = true;
            this.chkboxadmin.BackColor = System.Drawing.Color.Transparent;
            this.chkboxadmin.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxadmin.Location = new System.Drawing.Point(775, 307);
            this.chkboxadmin.Name = "chkboxadmin";
            this.chkboxadmin.Size = new System.Drawing.Size(199, 33);
            this.chkboxadmin.TabIndex = 9;
            this.chkboxadmin.Text = "Administrador";
            this.chkboxadmin.UseVisualStyleBackColor = false;
            this.chkboxadmin.CheckedChanged += new System.EventHandler(this.chkboxadmin_CheckedChanged);
            // 
            // txbcontraconf
            // 
            this.txbcontraconf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbcontraconf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcontraconf.Location = new System.Drawing.Point(420, 259);
            this.txbcontraconf.Name = "txbcontraconf";
            this.txbcontraconf.Size = new System.Drawing.Size(245, 35);
            this.txbcontraconf.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirmar contraseña";
            // 
            // btnborrarusuario
            // 
            this.btnborrarusuario.BackColor = System.Drawing.Color.Maroon;
            this.btnborrarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrarusuario.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrarusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnborrarusuario.Location = new System.Drawing.Point(79, 474);
            this.btnborrarusuario.Name = "btnborrarusuario";
            this.btnborrarusuario.Size = new System.Drawing.Size(162, 36);
            this.btnborrarusuario.TabIndex = 12;
            this.btnborrarusuario.Text = "Borrar usuario";
            this.btnborrarusuario.UseVisualStyleBackColor = false;
            this.btnborrarusuario.Click += new System.EventHandler(this.btnborrarusuario_Click);
            // 
            // btneditarusuario
            // 
            this.btneditarusuario.BackColor = System.Drawing.Color.DarkCyan;
            this.btneditarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditarusuario.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditarusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneditarusuario.Location = new System.Drawing.Point(79, 357);
            this.btneditarusuario.Name = "btneditarusuario";
            this.btneditarusuario.Size = new System.Drawing.Size(162, 36);
            this.btneditarusuario.TabIndex = 13;
            this.btneditarusuario.Text = "Editar usuario";
            this.btneditarusuario.UseVisualStyleBackColor = false;
            this.btneditarusuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // Editarusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.btneditarusuario);
            this.Controls.Add(this.btnborrarusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbcontraconf);
            this.Controls.Add(this.chkboxadmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btcrearusuario);
            this.Controls.Add(this.btnvolvercrearlosusuarios);
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
        private System.Windows.Forms.Button btnvolvercrearlosusuarios;
        private System.Windows.Forms.Button btcrearusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkboxadmin;
        private System.Windows.Forms.TextBox txbcontraconf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnborrarusuario;
        private System.Windows.Forms.Button btneditarusuario;
    }
}