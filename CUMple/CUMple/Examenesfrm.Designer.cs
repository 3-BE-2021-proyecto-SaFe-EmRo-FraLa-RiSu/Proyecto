
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
            this.cbidexamen = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnvolverexamenes = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.cbdisciplina = new System.Windows.Forms.ComboBox();
            this.Fechadatatimer = new System.Windows.Forms.DateTimePicker();
            this.horadatatimer = new System.Windows.Forms.DateTimePicker();
            this.cbhabfe = new System.Windows.Forms.CheckBox();
            this.cbhabhora = new System.Windows.Forms.CheckBox();
            this.rata = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).BeginInit();
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
            this.dgvexamenes.Location = new System.Drawing.Point(8, 142);
            this.dgvexamenes.MultiSelect = false;
            this.dgvexamenes.Name = "dgvexamenes";
            this.dgvexamenes.ReadOnly = true;
            this.dgvexamenes.RowHeadersWidth = 62;
            this.dgvexamenes.Size = new System.Drawing.Size(814, 346);
            this.dgvexamenes.TabIndex = 0;
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
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(438, 36);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(61, 30);
            this.btneditar.TabIndex = 1;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txbexaminadores
            // 
            this.txbexaminadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbexaminadores.Location = new System.Drawing.Point(106, 36);
            this.txbexaminadores.Name = "txbexaminadores";
            this.txbexaminadores.Size = new System.Drawing.Size(100, 26);
            this.txbexaminadores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Examinadores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Disciplina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora:";
            // 
            // cbidexamen
            // 
            this.cbidexamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbidexamen.FormattingEnabled = true;
            this.cbidexamen.Location = new System.Drawing.Point(614, 50);
            this.cbidexamen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbidexamen.Name = "cbidexamen";
            this.cbidexamen.Size = new System.Drawing.Size(100, 28);
            this.cbidexamen.TabIndex = 11;
            this.cbidexamen.SelectedIndexChanged += new System.EventHandler(this.cbidexamen_SelectedIndexChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(528, 56);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(72, 16);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "ID exámen";
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(438, 70);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(72, 30);
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
            this.btnvolverexamenes.Location = new System.Drawing.Point(764, 41);
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
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(438, 106);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(72, 30);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(516, 106);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(72, 30);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // cbdisciplina
            // 
            this.cbdisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdisciplina.FormattingEnabled = true;
            this.cbdisciplina.Items.AddRange(new object[] {
            "Taekwondo",
            "Krav Maga"});
            this.cbdisciplina.Location = new System.Drawing.Point(309, 36);
            this.cbdisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbdisciplina.Name = "cbdisciplina";
            this.cbdisciplina.Size = new System.Drawing.Size(100, 28);
            this.cbdisciplina.TabIndex = 17;
            this.cbdisciplina.SelectedIndexChanged += new System.EventHandler(this.cbdisciplina_SelectedIndexChanged);
            // 
            // Fechadatatimer
            // 
            this.Fechadatatimer.CustomFormat = "yyyy-MM-dd";
            this.Fechadatatimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechadatatimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fechadatatimer.Location = new System.Drawing.Point(106, 78);
            this.Fechadatatimer.Name = "Fechadatatimer";
            this.Fechadatatimer.Size = new System.Drawing.Size(100, 26);
            this.Fechadatatimer.TabIndex = 18;
            // 
            // horadatatimer
            // 
            this.horadatatimer.CustomFormat = "H:mm";
            this.horadatatimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horadatatimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horadatatimer.Location = new System.Drawing.Point(309, 78);
            this.horadatatimer.Name = "horadatatimer";
            this.horadatatimer.Size = new System.Drawing.Size(66, 26);
            this.horadatatimer.TabIndex = 19;
            this.horadatatimer.ValueChanged += new System.EventHandler(this.horadatatimer_ValueChanged);
            // 
            // cbhabfe
            // 
            this.cbhabfe.AutoSize = true;
            this.cbhabfe.Location = new System.Drawing.Point(106, 119);
            this.cbhabfe.Name = "cbhabfe";
            this.cbhabfe.Size = new System.Drawing.Size(94, 17);
            this.cbhabfe.TabIndex = 20;
            this.cbhabfe.Text = "Habilitar fecha";
            this.cbhabfe.UseVisualStyleBackColor = true;
            this.cbhabfe.CheckedChanged += new System.EventHandler(this.cbhabfe_CheckedChanged);
            // 
            // cbhabhora
            // 
            this.cbhabhora.AutoSize = true;
            this.cbhabhora.Location = new System.Drawing.Point(309, 119);
            this.cbhabhora.Name = "cbhabhora";
            this.cbhabhora.Size = new System.Drawing.Size(88, 17);
            this.cbhabhora.TabIndex = 21;
            this.cbhabhora.Text = "Habilitar hora";
            this.cbhabhora.UseVisualStyleBackColor = true;
            this.cbhabhora.CheckedChanged += new System.EventHandler(this.cbhabhora_CheckedChanged);
            // 
            // rata
            // 
            this.rata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rata.Location = new System.Drawing.Point(614, 108);
            this.rata.Name = "rata";
            this.rata.Size = new System.Drawing.Size(100, 26);
            this.rata.TabIndex = 22;
            this.rata.TextChanged += new System.EventHandler(this.rata_TextChanged);
            // 
            // Examenesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.rata);
            this.Controls.Add(this.cbhabhora);
            this.Controls.Add(this.cbhabfe);
            this.Controls.Add(this.horadatatimer);
            this.Controls.Add(this.Fechadatatimer);
            this.Controls.Add(this.cbdisciplina);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnvolverexamenes);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.cbidexamen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbexaminadores);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dgvexamenes);
            this.Name = "Examenesfrm";
            this.Text = "Examenes";
            this.Load += new System.EventHandler(this.Examenesfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).EndInit();
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
        private System.Windows.Forms.ComboBox cbidexamen;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnvolverexamenes;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ComboBox cbdisciplina;
        private System.Windows.Forms.DateTimePicker Fechadatatimer;
        private System.Windows.Forms.DateTimePicker horadatatimer;
        private System.Windows.Forms.CheckBox cbhabfe;
        private System.Windows.Forms.CheckBox cbhabhora;
        private System.Windows.Forms.TextBox rata;
    }
}