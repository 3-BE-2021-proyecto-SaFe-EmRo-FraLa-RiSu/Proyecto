
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
            this.btnbuscardis = new System.Windows.Forms.Button();
            this.cmbalumnosexistentes = new System.Windows.Forms.ComboBox();
            this.btnagregarusuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblxd
            // 
            this.lblxd.AutoSize = true;
            this.lblxd.BackColor = System.Drawing.Color.Lavender;
            this.lblxd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxd.Location = new System.Drawing.Point(445, 109);
            this.lblxd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblxd.Name = "lblxd";
            this.lblxd.Size = new System.Drawing.Size(428, 41);
            this.lblxd.TabIndex = 0;
            this.lblxd.Text = "Bienvenido, administrador.";
            // 
            // botingprog
            // 
            this.botingprog.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botingprog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botingprog.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botingprog.ForeColor = System.Drawing.Color.White;
            this.botingprog.Location = new System.Drawing.Point(690, 271);
            this.botingprog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botingprog.Name = "botingprog";
            this.botingprog.Size = new System.Drawing.Size(378, 63);
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
            this.botcrearus.Location = new System.Drawing.Point(690, 344);
            this.botcrearus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botcrearus.Name = "botcrearus";
            this.botcrearus.Size = new System.Drawing.Size(378, 63);
            this.botcrearus.TabIndex = 3;
            this.botcrearus.Text = "Editar usuarios";
            this.botcrearus.UseVisualStyleBackColor = false;
            this.botcrearus.Click += new System.EventHandler(this.botcrearus_Click);
            // 
            // btnbuscardis
            // 
            this.btnbuscardis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnbuscardis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscardis.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscardis.ForeColor = System.Drawing.Color.White;
            this.btnbuscardis.Location = new System.Drawing.Point(210, 271);
            this.btnbuscardis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbuscardis.Name = "btnbuscardis";
            this.btnbuscardis.Size = new System.Drawing.Size(378, 63);
            this.btnbuscardis.TabIndex = 5;
            this.btnbuscardis.Text = "Administrar Discipulo";
            this.btnbuscardis.UseVisualStyleBackColor = false;
            this.btnbuscardis.Click += new System.EventHandler(this.btnbuscardis_Click);
            // 
            // cmbalumnosexistentes
            // 
            this.cmbalumnosexistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbalumnosexistentes.FormattingEnabled = true;
            this.cmbalumnosexistentes.Location = new System.Drawing.Point(210, 218);
            this.cmbalumnosexistentes.Name = "cmbalumnosexistentes";
            this.cmbalumnosexistentes.Size = new System.Drawing.Size(378, 45);
            this.cmbalumnosexistentes.TabIndex = 2;
            this.cmbalumnosexistentes.Text = "Seleccionar Discipulo:";
            this.cmbalumnosexistentes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnagregarusuarios
            // 
            this.btnagregarusuarios.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnagregarusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregarusuarios.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarusuarios.ForeColor = System.Drawing.Color.White;
            this.btnagregarusuarios.Location = new System.Drawing.Point(210, 344);
            this.btnagregarusuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregarusuarios.Name = "btnagregarusuarios";
            this.btnagregarusuarios.Size = new System.Drawing.Size(378, 63);
            this.btnagregarusuarios.TabIndex = 4;
            this.btnagregarusuarios.Text = "Agregar Discipulos";
            this.btnagregarusuarios.UseVisualStyleBackColor = false;
            this.btnagregarusuarios.Click += new System.EventHandler(this.btnagregarusuarios_Click);
            // 
            // formadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CUMple.Properties.Resources.logo_de_Academia_DO_difuminado_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1306, 715);
            this.Controls.Add(this.btnagregarusuarios);
            this.Controls.Add(this.cmbalumnosexistentes);
            this.Controls.Add(this.btnbuscardis);
            this.Controls.Add(this.botcrearus);
            this.Controls.Add(this.botingprog);
            this.Controls.Add(this.lblxd);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.formadmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblxd;
        private System.Windows.Forms.Button botingprog;
        private System.Windows.Forms.Button botcrearus;
        private System.Windows.Forms.Button btnbuscardis;
        private System.Windows.Forms.ComboBox cmbalumnosexistentes;
        private System.Windows.Forms.Button btnagregarusuarios;
    }
}