
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
            this.txbdisciplina = new System.Windows.Forms.TextBox();
            this.txbfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbhora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dgvexamenes.Location = new System.Drawing.Point(8, 122);
            this.dgvexamenes.Name = "dgvexamenes";
            this.dgvexamenes.Size = new System.Drawing.Size(543, 316);
            this.dgvexamenes.TabIndex = 0;
            this.dgvexamenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexamenes_CellContentClick);
            // 
            // colexaminadores
            // 
            this.colexaminadores.HeaderText = "Examinadores";
            this.colexaminadores.Name = "colexaminadores";
            // 
            // colfecha
            // 
            this.colfecha.HeaderText = "Fecha";
            this.colfecha.Name = "colfecha";
            // 
            // coldisciplina
            // 
            this.coldisciplina.HeaderText = "Disciplina";
            this.coldisciplina.Name = "coldisciplina";
            // 
            // colhora
            // 
            this.colhora.HeaderText = "Hora";
            this.colhora.Name = "colhora";
            // 
            // colidexamen
            // 
            this.colidexamen.HeaderText = "ID del exámen";
            this.colidexamen.Name = "colidexamen";
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(438, 49);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(61, 30);
            this.btneditar.TabIndex = 1;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // txbexaminadores
            // 
            this.txbexaminadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbexaminadores.Location = new System.Drawing.Point(106, 30);
            this.txbexaminadores.Name = "txbexaminadores";
            this.txbexaminadores.Size = new System.Drawing.Size(100, 26);
            this.txbexaminadores.TabIndex = 2;
            // 
            // txbdisciplina
            // 
            this.txbdisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdisciplina.Location = new System.Drawing.Point(310, 30);
            this.txbdisciplina.Name = "txbdisciplina";
            this.txbdisciplina.Size = new System.Drawing.Size(100, 26);
            this.txbdisciplina.TabIndex = 3;
            // 
            // txbfecha
            // 
            this.txbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbfecha.Location = new System.Drawing.Point(106, 76);
            this.txbfecha.Name = "txbfecha";
            this.txbfecha.Size = new System.Drawing.Size(100, 26);
            this.txbfecha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Examinadores:";
            // 
            // txbhora
            // 
            this.txbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbhora.Location = new System.Drawing.Point(310, 72);
            this.txbhora.Name = "txbhora";
            this.txbhora.Size = new System.Drawing.Size(100, 26);
            this.txbhora.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 82);
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
            this.label4.Location = new System.Drawing.Point(247, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora:";
            // 
            // Examenesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbfecha);
            this.Controls.Add(this.txbdisciplina);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colexaminadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidexamen;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TextBox txbexaminadores;
        private System.Windows.Forms.TextBox txbdisciplina;
        private System.Windows.Forms.TextBox txbfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbhora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}