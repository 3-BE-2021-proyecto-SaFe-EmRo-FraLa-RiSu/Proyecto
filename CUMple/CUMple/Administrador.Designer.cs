
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
            this.cmbalumnosexistentes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.txbapellidofiltrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblxd
            // 
            this.lblxd.AutoSize = true;
            this.lblxd.BackColor = System.Drawing.Color.Transparent;
            this.lblxd.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxd.Location = new System.Drawing.Point(285, 75);
            this.lblxd.Name = "lblxd";
            this.lblxd.Size = new System.Drawing.Size(267, 23);
            this.lblxd.TabIndex = 0;
            this.lblxd.Text = "Bienvenido, administrador.";
            // 
            // botingprog
            // 
            this.botingprog.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botingprog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botingprog.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botingprog.ForeColor = System.Drawing.Color.White;
            this.botingprog.Location = new System.Drawing.Point(158, 226);
            this.botingprog.Name = "botingprog";
            this.botingprog.Size = new System.Drawing.Size(247, 41);
            this.botingprog.TabIndex = 1;
            this.botingprog.Text = "Ingresar al programa";
            this.botingprog.UseVisualStyleBackColor = false;
            this.botingprog.Click += new System.EventHandler(this.botingprog_Click);
            // 
            // botcrearus
            // 
            this.botcrearus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botcrearus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botcrearus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botcrearus.ForeColor = System.Drawing.Color.White;
            this.botcrearus.Location = new System.Drawing.Point(160, 159);
            this.botcrearus.Name = "botcrearus";
            this.botcrearus.Size = new System.Drawing.Size(245, 41);
            this.botcrearus.TabIndex = 2;
            this.botcrearus.Text = "Editar Discipulos";
            this.botcrearus.UseVisualStyleBackColor = false;
            this.botcrearus.Click += new System.EventHandler(this.botcrearus_Click);
            // 
            // cmbalumnosexistentes
            // 
            this.cmbalumnosexistentes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbalumnosexistentes.FormattingEnabled = true;
            this.cmbalumnosexistentes.Location = new System.Drawing.Point(160, 115);
            this.cmbalumnosexistentes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbalumnosexistentes.Name = "cmbalumnosexistentes";
            this.cmbalumnosexistentes.Size = new System.Drawing.Size(247, 31);
            this.cmbalumnosexistentes.TabIndex = 5;
            this.cmbalumnosexistentes.Text = "Discipulos:";
            this.cmbalumnosexistentes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(158, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar Discipulos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfiltrar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrar.ForeColor = System.Drawing.Color.White;
            this.btnfiltrar.Location = new System.Drawing.Point(424, 159);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(245, 41);
            this.btnfiltrar.TabIndex = 7;
            this.btnfiltrar.Text = "Filtrar Discipulos";
            this.btnfiltrar.UseVisualStyleBackColor = false;
            // 
            // txbapellidofiltrar
            // 
            this.txbapellidofiltrar.Location = new System.Drawing.Point(424, 123);
            this.txbapellidofiltrar.Name = "txbapellidofiltrar";
            this.txbapellidofiltrar.Size = new System.Drawing.Size(245, 20);
            this.txbapellidofiltrar.TabIndex = 8;
            // 
            // formadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 503);
            this.Controls.Add(this.txbapellidofiltrar);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbalumnosexistentes);
            this.Controls.Add(this.botcrearus);
            this.Controls.Add(this.botingprog);
            this.Controls.Add(this.lblxd);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ComboBox cmbalumnosexistentes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.TextBox txbapellidofiltrar;
    }
}