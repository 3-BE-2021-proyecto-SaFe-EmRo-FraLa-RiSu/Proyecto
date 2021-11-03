
namespace CUMple
{
    partial class examenesnotas
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
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idexamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuevo_rango = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.cbidexamen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvexamenes
            // 
            this.dgvexamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexamenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.idexamen,
            this.notas,
            this.nuevo_rango});
            this.dgvexamenes.Location = new System.Drawing.Point(12, 145);
            this.dgvexamenes.Name = "dgvexamenes";
            this.dgvexamenes.Size = new System.Drawing.Size(443, 192);
            this.dgvexamenes.TabIndex = 0;
            this.dgvexamenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cedula
            // 
            this.cedula.DataPropertyName = "cedula";
            this.cedula.HeaderText = "Cédula";
            this.cedula.Name = "cedula";
            // 
            // idexamen
            // 
            this.idexamen.DataPropertyName = "idexamen";
            this.idexamen.HeaderText = "ID del exámen";
            this.idexamen.Name = "idexamen";
            // 
            // notas
            // 
            this.notas.DataPropertyName = "notas";
            this.notas.HeaderText = "Nota";
            this.notas.Name = "notas";
            // 
            // nuevo_rango
            // 
            this.nuevo_rango.DataPropertyName = "nuevo_rango";
            this.nuevo_rango.HeaderText = "Rango nuevo";
            this.nuevo_rango.Name = "nuevo_rango";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(630, 82);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(72, 30);
            this.btnlimpiar.TabIndex = 20;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(552, 82);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(72, 30);
            this.btneliminar.TabIndex = 19;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(552, 46);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(72, 30);
            this.btnagregar.TabIndex = 18;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(552, 12);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(61, 30);
            this.btneditar.TabIndex = 17;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // cbidexamen
            // 
            this.cbidexamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbidexamen.FormattingEnabled = true;
            this.cbidexamen.Location = new System.Drawing.Point(355, 48);
            this.cbidexamen.Margin = new System.Windows.Forms.Padding(2);
            this.cbidexamen.Name = "cbidexamen";
            this.cbidexamen.Size = new System.Drawing.Size(100, 28);
            this.cbidexamen.TabIndex = 21;
            this.cbidexamen.SelectedIndexChanged += new System.EventHandler(this.cbidexamen_SelectedIndexChanged);
            // 
            // examenesnotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbidexamen);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dgvexamenes);
            this.Name = "examenesnotas";
            this.Text = "examenesnotas";
            this.Load += new System.EventHandler(this.examenesnotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvexamenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn idexamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuevo_rango;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.ComboBox cbidexamen;
    }
}