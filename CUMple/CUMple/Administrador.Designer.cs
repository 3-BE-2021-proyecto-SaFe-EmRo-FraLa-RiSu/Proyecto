
namespace CUMple
{
    partial class formadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formadmin));
            this.lblxd = new System.Windows.Forms.Label();
            this.botingprog = new System.Windows.Forms.Button();
            this.botcrearus = new System.Windows.Forms.Button();
            this.txbdiscipulo = new System.Windows.Forms.TextBox();
            this.btnbuscardis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblxd
            // 
            this.lblxd.AutoSize = true;
            this.lblxd.BackColor = System.Drawing.Color.Transparent;
            this.lblxd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxd.Location = new System.Drawing.Point(99, 38);
            this.lblxd.Name = "lblxd";
            this.lblxd.Size = new System.Drawing.Size(289, 26);
            this.lblxd.TabIndex = 0;
            this.lblxd.Text = "Bienvenido, administrador.";
            // 
            // botingprog
            // 
            this.botingprog.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botingprog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botingprog.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botingprog.ForeColor = System.Drawing.Color.White;
            this.botingprog.Location = new System.Drawing.Point(119, 100);
            this.botingprog.Name = "botingprog";
            this.botingprog.Size = new System.Drawing.Size(245, 41);
            this.botingprog.TabIndex = 1;
            this.botingprog.Text = "Ingresar al programa";
            this.botingprog.UseVisualStyleBackColor = false;
            this.botingprog.Click += new System.EventHandler(this.botingprog_Click);
            // 
            // botcrearus
            // 
            this.botcrearus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botcrearus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botcrearus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botcrearus.ForeColor = System.Drawing.Color.White;
            this.botcrearus.Location = new System.Drawing.Point(119, 164);
            this.botcrearus.Name = "botcrearus";
            this.botcrearus.Size = new System.Drawing.Size(245, 41);
            this.botcrearus.TabIndex = 2;
            this.botcrearus.Text = "Editar usuarios";
            this.botcrearus.UseVisualStyleBackColor = false;
            this.botcrearus.Click += new System.EventHandler(this.botcrearus_Click);
            // 
            // txbdiscipulo
            // 
            this.txbdiscipulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdiscipulo.Location = new System.Drawing.Point(119, 216);
            this.txbdiscipulo.Name = "txbdiscipulo";
            this.txbdiscipulo.Size = new System.Drawing.Size(245, 29);
            this.txbdiscipulo.TabIndex = 3;
            // 
            // btnbuscardis
            // 
            this.btnbuscardis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnbuscardis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscardis.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscardis.ForeColor = System.Drawing.Color.White;
            this.btnbuscardis.Location = new System.Drawing.Point(119, 251);
            this.btnbuscardis.Name = "btnbuscardis";
            this.btnbuscardis.Size = new System.Drawing.Size(245, 41);
            this.btnbuscardis.TabIndex = 4;
            this.btnbuscardis.Text = "Buscar Alumnos";
            this.btnbuscardis.UseVisualStyleBackColor = false;
            this.btnbuscardis.Click += new System.EventHandler(this.btnbuscardis_Click);
            // 
            // formadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CUMple.Properties.Resources.logo_de_Academia_DO_difuminado_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 327);
            this.Controls.Add(this.btnbuscardis);
            this.Controls.Add(this.txbdiscipulo);
            this.Controls.Add(this.botcrearus);
            this.Controls.Add(this.botingprog);
            this.Controls.Add(this.lblxd);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formadmin";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.formadmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblxd;
        private System.Windows.Forms.Button botingprog;
        private System.Windows.Forms.Button botcrearus;
        private System.Windows.Forms.TextBox txbdiscipulo;
        private System.Windows.Forms.Button btnbuscardis;
    }
}