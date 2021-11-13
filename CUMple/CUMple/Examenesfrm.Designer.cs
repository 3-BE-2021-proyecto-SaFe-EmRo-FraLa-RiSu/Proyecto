
namespace CUMple
{
    partial class Examenesfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examenesfrm));
            this.dgvexamenes = new System.Windows.Forms.DataGridView();
            this.colexaminadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colidexamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneditar = new System.Windows.Forms.Button();
            this.txbexaminadores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnvolverexamenes = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.cbdisciplina = new System.Windows.Forms.ComboBox();
            this.Fechadatatimer = new System.Windows.Forms.DateTimePicker();
            this.horadatatimer = new System.Windows.Forms.DateTimePicker();
            this.cbhabfe = new System.Windows.Forms.CheckBox();
            this.cbhabhora = new System.Windows.Forms.CheckBox();
            this.txbbuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.cerrarclic = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvexamenes
            // 
            this.dgvexamenes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvexamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexamenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colexaminadores,
            this.colfecha,
            this.coldisciplina,
            this.colhora,
            this.colidexamen});
            this.dgvexamenes.Location = new System.Drawing.Point(84, 223);
            this.dgvexamenes.MultiSelect = false;
            this.dgvexamenes.Name = "dgvexamenes";
            this.dgvexamenes.ReadOnly = true;
            this.dgvexamenes.RowHeadersWidth = 62;
            this.dgvexamenes.Size = new System.Drawing.Size(814, 284);
            this.dgvexamenes.TabIndex = 0;
            this.dgvexamenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexamenes_CellClick);
            this.dgvexamenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexamenes_CellContentClick);
            // 
            // colexaminadores
            // 
            this.colexaminadores.DataPropertyName = "examinadores";
            this.colexaminadores.HeaderText = "Examinadores";
            this.colexaminadores.MinimumWidth = 8;
            this.colexaminadores.Name = "colexaminadores";
            this.colexaminadores.ReadOnly = true;
            this.colexaminadores.Width = 150;
            // 
            // colfecha
            // 
            this.colfecha.DataPropertyName = "fecha";
            this.colfecha.HeaderText = "Fecha";
            this.colfecha.MinimumWidth = 8;
            this.colfecha.Name = "colfecha";
            this.colfecha.ReadOnly = true;
            this.colfecha.Width = 150;
            // 
            // coldisciplina
            // 
            this.coldisciplina.DataPropertyName = "disciplina";
            this.coldisciplina.HeaderText = "Disciplina";
            this.coldisciplina.MinimumWidth = 8;
            this.coldisciplina.Name = "coldisciplina";
            this.coldisciplina.ReadOnly = true;
            this.coldisciplina.Width = 150;
            // 
            // colhora
            // 
            this.colhora.DataPropertyName = "hora";
            this.colhora.HeaderText = "Hora";
            this.colhora.MinimumWidth = 8;
            this.colhora.Name = "colhora";
            this.colhora.ReadOnly = true;
            this.colhora.Width = 150;
            // 
            // colidexamen
            // 
            this.colidexamen.DataPropertyName = "idexamen";
            this.colidexamen.HeaderText = "ID del exámen";
            this.colidexamen.MinimumWidth = 8;
            this.colidexamen.Name = "colidexamen";
            this.colidexamen.ReadOnly = true;
            this.colidexamen.Width = 150;
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(366, 517);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(72, 30);
            this.btneditar.TabIndex = 1;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txbexaminadores
            // 
            this.txbexaminadores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbexaminadores.Location = new System.Drawing.Point(153, 90);
            this.txbexaminadores.Name = "txbexaminadores";
            this.txbexaminadores.Size = new System.Drawing.Size(127, 27);
            this.txbexaminadores.TabIndex = 2;
            this.txbexaminadores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbexaminadores_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Examinadores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Disciplina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora:";
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(246, 517);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(83, 30);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnvolverexamenes
            // 
            this.btnvolverexamenes.BackColor = System.Drawing.Color.DarkRed;
            this.btnvolverexamenes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvolverexamenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverexamenes.ForeColor = System.Drawing.Color.Transparent;
            this.btnvolverexamenes.Location = new System.Drawing.Point(12, 505);
            this.btnvolverexamenes.Name = "btnvolverexamenes";
            this.btnvolverexamenes.Size = new System.Drawing.Size(43, 42);
            this.btnvolverexamenes.TabIndex = 14;
            this.btnvolverexamenes.Text = "⮎";
            this.btnvolverexamenes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnvolverexamenes.UseVisualStyleBackColor = false;
            this.btnvolverexamenes.Click += new System.EventHandler(this.btnvolverexamenes_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(583, 517);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 30);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(473, 517);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(80, 30);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // cbdisciplina
            // 
            this.cbdisciplina.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdisciplina.FormattingEnabled = true;
            this.cbdisciplina.Items.AddRange(new object[] {
            "Taekwondo",
            "Krav Maga"});
            this.cbdisciplina.Location = new System.Drawing.Point(429, 93);
            this.cbdisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbdisciplina.Name = "cbdisciplina";
            this.cbdisciplina.Size = new System.Drawing.Size(124, 26);
            this.cbdisciplina.TabIndex = 17;
            this.cbdisciplina.SelectedIndexChanged += new System.EventHandler(this.cbdisciplina_SelectedIndexChanged);
            // 
            // Fechadatatimer
            // 
            this.Fechadatatimer.CustomFormat = "yyyy-MM-dd";
            this.Fechadatatimer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechadatatimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fechadatatimer.Location = new System.Drawing.Point(153, 129);
            this.Fechadatatimer.Name = "Fechadatatimer";
            this.Fechadatatimer.Size = new System.Drawing.Size(127, 27);
            this.Fechadatatimer.TabIndex = 18;
            // 
            // horadatatimer
            // 
            this.horadatatimer.CalendarForeColor = System.Drawing.Color.Transparent;
            this.horadatatimer.CustomFormat = "H:mm";
            this.horadatatimer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horadatatimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horadatatimer.Location = new System.Drawing.Point(429, 138);
            this.horadatatimer.Name = "horadatatimer";
            this.horadatatimer.Size = new System.Drawing.Size(80, 27);
            this.horadatatimer.TabIndex = 19;
            this.horadatatimer.ValueChanged += new System.EventHandler(this.horadatatimer_ValueChanged);
            // 
            // cbhabfe
            // 
            this.cbhabfe.AutoSize = true;
            this.cbhabfe.BackColor = System.Drawing.Color.Transparent;
            this.cbhabfe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhabfe.Location = new System.Drawing.Point(153, 170);
            this.cbhabfe.Name = "cbhabfe";
            this.cbhabfe.Size = new System.Drawing.Size(147, 22);
            this.cbhabfe.TabIndex = 20;
            this.cbhabfe.Text = "Habilitar fecha";
            this.cbhabfe.UseVisualStyleBackColor = false;
            this.cbhabfe.CheckedChanged += new System.EventHandler(this.cbhabfe_CheckedChanged);
            // 
            // cbhabhora
            // 
            this.cbhabhora.AutoSize = true;
            this.cbhabhora.BackColor = System.Drawing.Color.Transparent;
            this.cbhabhora.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhabhora.Location = new System.Drawing.Point(429, 171);
            this.cbhabhora.Name = "cbhabhora";
            this.cbhabhora.Size = new System.Drawing.Size(139, 22);
            this.cbhabhora.TabIndex = 21;
            this.cbhabhora.Text = "Habilitar hora";
            this.cbhabhora.UseVisualStyleBackColor = false;
            this.cbhabhora.CheckedChanged += new System.EventHandler(this.cbhabhora_CheckedChanged);
            // 
            // txbbuscar
            // 
            this.txbbuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbbuscar.Location = new System.Drawing.Point(659, 96);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(72, 30);
            this.txbbuscar.TabIndex = 23;
            this.txbbuscar.Text = "Buscar";
            this.txbbuscar.UseVisualStyleBackColor = true;
            this.txbbuscar.Click += new System.EventHandler(this.txbbuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.restaurar);
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.cerrarclic);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 50);
            this.panel1.TabIndex = 47;
            // 
            // restaurar
            // 
            this.restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restaurar.Image = ((System.Drawing.Image)(resources.GetObject("restaurar.Image")));
            this.restaurar.Location = new System.Drawing.Point(895, 5);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(41, 42);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restaurar.TabIndex = 19;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            // 
            // minimizar
            // 
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(848, 5);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(41, 42);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 18;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrarclic
            // 
            this.cerrarclic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cerrarclic.Image = ((System.Drawing.Image)(resources.GetObject("cerrarclic.Image")));
            this.cerrarclic.Location = new System.Drawing.Point(942, 5);
            this.cerrarclic.Name = "cerrarclic";
            this.cerrarclic.Size = new System.Drawing.Size(41, 42);
            this.cerrarclic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrarclic.TabIndex = 17;
            this.cerrarclic.TabStop = false;
            this.cerrarclic.Click += new System.EventHandler(this.cerrarclic_Click);
            // 
            // maximizar
            // 
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(895, 5);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(41, 42);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizar.TabIndex = 16;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // Examenesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(995, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbbuscar);
            this.Controls.Add(this.cbhabhora);
            this.Controls.Add(this.cbhabfe);
            this.Controls.Add(this.horadatatimer);
            this.Controls.Add(this.Fechadatatimer);
            this.Controls.Add(this.cbdisciplina);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnvolverexamenes);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbexaminadores);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dgvexamenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Examenesfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examenes";
            this.Load += new System.EventHandler(this.Examenesfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvexamenes;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TextBox txbexaminadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colexaminadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidexamen;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnvolverexamenes;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ComboBox cbdisciplina;
        private System.Windows.Forms.DateTimePicker Fechadatatimer;
        private System.Windows.Forms.DateTimePicker horadatatimer;
        private System.Windows.Forms.CheckBox cbhabfe;
        private System.Windows.Forms.CheckBox cbhabhora;
        private System.Windows.Forms.Button txbbuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox cerrarclic;
        private System.Windows.Forms.PictureBox maximizar;
    }
}