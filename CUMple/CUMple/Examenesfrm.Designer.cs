
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.restau = new System.Windows.Forms.PictureBox();
            this.cerrarclic = new System.Windows.Forms.PictureBox();
            this.minim = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvexamenes
            // 
            this.dgvexamenes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvexamenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvexamenes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvexamenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvexamenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvexamenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvexamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexamenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colexaminadores,
            this.colfecha,
            this.coldisciplina,
            this.colhora,
            this.colidexamen});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvexamenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvexamenes.EnableHeadersVisualStyles = false;
            this.dgvexamenes.GridColor = System.Drawing.Color.White;
            this.dgvexamenes.Location = new System.Drawing.Point(489, 209);
            this.dgvexamenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvexamenes.MultiSelect = false;
            this.dgvexamenes.Name = "dgvexamenes";
            this.dgvexamenes.ReadOnly = true;
            this.dgvexamenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvexamenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvexamenes.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvexamenes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvexamenes.Size = new System.Drawing.Size(1074, 657);
            this.dgvexamenes.TabIndex = 0;
            this.dgvexamenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexamenes_CellClick);
            this.dgvexamenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexamenes_CellContentClick);
            this.dgvexamenes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvexamenes_MouseDoubleClick);
            this.dgvexamenes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvexamenes_MouseDown);
            // 
            // colexaminadores
            // 
            this.colexaminadores.DataPropertyName = "examinadores";
            this.colexaminadores.HeaderText = "Examinadores";
            this.colexaminadores.MinimumWidth = 8;
            this.colexaminadores.Name = "colexaminadores";
            this.colexaminadores.ReadOnly = true;
            this.colexaminadores.Width = 215;
            // 
            // colfecha
            // 
            this.colfecha.DataPropertyName = "fecha";
            this.colfecha.HeaderText = "Fecha";
            this.colfecha.MinimumWidth = 8;
            this.colfecha.Name = "colfecha";
            this.colfecha.ReadOnly = true;
            this.colfecha.Width = 116;
            // 
            // coldisciplina
            // 
            this.coldisciplina.DataPropertyName = "disciplina";
            this.coldisciplina.HeaderText = "Disciplina";
            this.coldisciplina.MinimumWidth = 8;
            this.coldisciplina.Name = "coldisciplina";
            this.coldisciplina.ReadOnly = true;
            this.coldisciplina.Width = 160;
            // 
            // colhora
            // 
            this.colhora.DataPropertyName = "hora";
            this.colhora.HeaderText = "Hora";
            this.colhora.MinimumWidth = 8;
            this.colhora.Name = "colhora";
            this.colhora.ReadOnly = true;
            this.colhora.Width = 104;
            // 
            // colidexamen
            // 
            this.colidexamen.DataPropertyName = "idexamen";
            this.colidexamen.HeaderText = "ID del exámen";
            this.colidexamen.MinimumWidth = 8;
            this.colidexamen.Name = "colidexamen";
            this.colidexamen.ReadOnly = true;
            this.colidexamen.Width = 202;
            // 
            // btneditar
            // 
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(9, 170);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(252, 60);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txbexaminadores
            // 
            this.txbexaminadores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbexaminadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txbexaminadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbexaminadores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbexaminadores.ForeColor = System.Drawing.Color.White;
            this.txbexaminadores.Location = new System.Drawing.Point(688, 91);
            this.txbexaminadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbexaminadores.Name = "txbexaminadores";
            this.txbexaminadores.Size = new System.Drawing.Size(208, 30);
            this.txbexaminadores.TabIndex = 1;
            this.txbexaminadores.TextChanged += new System.EventHandler(this.txbexaminadores_TextChanged);
            this.txbexaminadores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbexaminadores_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(484, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Examinadores:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(958, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(484, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Disciplina:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(958, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora:";
            // 
            // btnagregar
            // 
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(8, 48);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(256, 60);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnvolverexamenes
            // 
            this.btnvolverexamenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnvolverexamenes.FlatAppearance.BorderSize = 0;
            this.btnvolverexamenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnvolverexamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolverexamenes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverexamenes.ForeColor = System.Drawing.Color.Transparent;
            this.btnvolverexamenes.Location = new System.Drawing.Point(0, 705);
            this.btnvolverexamenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnvolverexamenes.Name = "btnvolverexamenes";
            this.btnvolverexamenes.Size = new System.Drawing.Size(264, 60);
            this.btnvolverexamenes.TabIndex = 12;
            this.btnvolverexamenes.Text = "Volver";
            this.btnvolverexamenes.UseVisualStyleBackColor = false;
            this.btnvolverexamenes.Click += new System.EventHandler(this.btnvolverexamenes_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(4, 565);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(260, 60);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(4, 433);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(260, 60);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // cbdisciplina
            // 
            this.cbdisciplina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbdisciplina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbdisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdisciplina.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdisciplina.ForeColor = System.Drawing.Color.White;
            this.cbdisciplina.FormattingEnabled = true;
            this.cbdisciplina.Items.AddRange(new object[] {
            "Taekwondo",
            "Krav Maga"});
            this.cbdisciplina.Location = new System.Drawing.Point(687, 143);
            this.cbdisciplina.Name = "cbdisciplina";
            this.cbdisciplina.Size = new System.Drawing.Size(206, 37);
            this.cbdisciplina.TabIndex = 2;
            this.cbdisciplina.SelectedIndexChanged += new System.EventHandler(this.cbdisciplina_SelectedIndexChanged);
            // 
            // Fechadatatimer
            // 
            this.Fechadatatimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fechadatatimer.CustomFormat = "yyyy-MM-dd";
            this.Fechadatatimer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechadatatimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fechadatatimer.Location = new System.Drawing.Point(1132, 135);
            this.Fechadatatimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fechadatatimer.Name = "Fechadatatimer";
            this.Fechadatatimer.Size = new System.Drawing.Size(188, 37);
            this.Fechadatatimer.TabIndex = 4;
            // 
            // horadatatimer
            // 
            this.horadatatimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.horadatatimer.CalendarForeColor = System.Drawing.Color.Transparent;
            this.horadatatimer.CustomFormat = "H:mm";
            this.horadatatimer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horadatatimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horadatatimer.Location = new System.Drawing.Point(1132, 77);
            this.horadatatimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.horadatatimer.Name = "horadatatimer";
            this.horadatatimer.Size = new System.Drawing.Size(109, 37);
            this.horadatatimer.TabIndex = 3;
            this.horadatatimer.ValueChanged += new System.EventHandler(this.horadatatimer_ValueChanged);
            // 
            // cbhabfe
            // 
            this.cbhabfe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbhabfe.AutoSize = true;
            this.cbhabfe.BackColor = System.Drawing.Color.Transparent;
            this.cbhabfe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhabfe.ForeColor = System.Drawing.Color.White;
            this.cbhabfe.Location = new System.Drawing.Point(1348, 143);
            this.cbhabfe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbhabfe.Name = "cbhabfe";
            this.cbhabfe.Size = new System.Drawing.Size(209, 33);
            this.cbhabfe.TabIndex = 6;
            this.cbhabfe.Text = "Habilitar fecha";
            this.cbhabfe.UseVisualStyleBackColor = false;
            this.cbhabfe.CheckedChanged += new System.EventHandler(this.cbhabfe_CheckedChanged);
            // 
            // cbhabhora
            // 
            this.cbhabhora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbhabhora.AutoSize = true;
            this.cbhabhora.BackColor = System.Drawing.Color.Transparent;
            this.cbhabhora.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhabhora.ForeColor = System.Drawing.Color.White;
            this.cbhabhora.Location = new System.Drawing.Point(1348, 83);
            this.cbhabhora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbhabhora.Name = "cbhabhora";
            this.cbhabhora.Size = new System.Drawing.Size(199, 33);
            this.cbhabhora.TabIndex = 5;
            this.cbhabhora.Text = "Habilitar hora";
            this.cbhabhora.UseVisualStyleBackColor = false;
            this.cbhabhora.CheckedChanged += new System.EventHandler(this.cbhabhora_CheckedChanged);
            // 
            // txbbuscar
            // 
            this.txbbuscar.FlatAppearance.BorderSize = 0;
            this.txbbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.txbbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txbbuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbbuscar.ForeColor = System.Drawing.Color.White;
            this.txbbuscar.Location = new System.Drawing.Point(4, 302);
            this.txbbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(260, 60);
            this.txbbuscar.TabIndex = 9;
            this.txbbuscar.Text = "Buscar";
            this.txbbuscar.UseVisualStyleBackColor = true;
            this.txbbuscar.Click += new System.EventHandler(this.txbbuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.restau);
            this.panel1.Controls.Add(this.cerrarclic);
            this.panel1.Controls.Add(this.minim);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1824, 54);
            this.panel1.TabIndex = 47;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // restau
            // 
            this.restau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restau.Image = ((System.Drawing.Image)(resources.GetObject("restau.Image")));
            this.restau.Location = new System.Drawing.Point(1630, 0);
            this.restau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.restau.Name = "restau";
            this.restau.Size = new System.Drawing.Size(56, 46);
            this.restau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restau.TabIndex = 18;
            this.restau.TabStop = false;
            this.restau.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrarclic
            // 
            this.cerrarclic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarclic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cerrarclic.Image = ((System.Drawing.Image)(resources.GetObject("cerrarclic.Image")));
            this.cerrarclic.Location = new System.Drawing.Point(1766, 0);
            this.cerrarclic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cerrarclic.Name = "cerrarclic";
            this.cerrarclic.Size = new System.Drawing.Size(56, 46);
            this.cerrarclic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarclic.TabIndex = 17;
            this.cerrarclic.TabStop = false;
            this.cerrarclic.Click += new System.EventHandler(this.cerrarclic_Click);
            // 
            // minim
            // 
            this.minim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minim.Image = ((System.Drawing.Image)(resources.GetObject("minim.Image")));
            this.minim.Location = new System.Drawing.Point(1695, 0);
            this.minim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minim.Name = "minim";
            this.minim.Size = new System.Drawing.Size(56, 46);
            this.minim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minim.TabIndex = 19;
            this.minim.TabStop = false;
            this.minim.Visible = false;
            this.minim.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1695, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(56, 46);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 16;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panelapoyo5);
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Controls.Add(this.panelapoyo4);
            this.panel2.Controls.Add(this.btneditar);
            this.panel2.Controls.Add(this.panelapoyo3);
            this.panel2.Controls.Add(this.txbbuscar);
            this.panel2.Controls.Add(this.panelapoyo2);
            this.panel2.Controls.Add(this.btnlimpiar);
            this.panel2.Controls.Add(this.panelapoyo1);
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.btnvolverexamenes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 826);
            this.panel2.TabIndex = 48;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 705);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 60);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // panelapoyo5
            // 
            this.panelapoyo5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo5.Location = new System.Drawing.Point(0, 565);
            this.panelapoyo5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelapoyo5.Name = "panelapoyo5";
            this.panelapoyo5.Size = new System.Drawing.Size(8, 60);
            this.panelapoyo5.TabIndex = 50;
            // 
            // panelapoyo4
            // 
            this.panelapoyo4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo4.Location = new System.Drawing.Point(0, 433);
            this.panelapoyo4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelapoyo4.Name = "panelapoyo4";
            this.panelapoyo4.Size = new System.Drawing.Size(8, 60);
            this.panelapoyo4.TabIndex = 51;
            // 
            // panelapoyo3
            // 
            this.panelapoyo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo3.Location = new System.Drawing.Point(0, 302);
            this.panelapoyo3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelapoyo3.Name = "panelapoyo3";
            this.panelapoyo3.Size = new System.Drawing.Size(8, 60);
            this.panelapoyo3.TabIndex = 52;
            // 
            // panelapoyo2
            // 
            this.panelapoyo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo2.Location = new System.Drawing.Point(0, 170);
            this.panelapoyo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelapoyo2.Name = "panelapoyo2";
            this.panelapoyo2.Size = new System.Drawing.Size(8, 60);
            this.panelapoyo2.TabIndex = 53;
            // 
            // panelapoyo1
            // 
            this.panelapoyo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo1.Location = new System.Drawing.Point(0, 48);
            this.panelapoyo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelapoyo1.Name = "panelapoyo1";
            this.panelapoyo1.Size = new System.Drawing.Size(8, 60);
            this.panelapoyo1.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(687, 125);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 2);
            this.panel3.TabIndex = 49;
            // 
            // Examenesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1824, 880);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbhabhora);
            this.Controls.Add(this.cbhabfe);
            this.Controls.Add(this.horadatatimer);
            this.Controls.Add(this.Fechadatatimer);
            this.Controls.Add(this.cbdisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbexaminadores);
            this.Controls.Add(this.dgvexamenes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Examenesfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examenes";
            this.Load += new System.EventHandler(this.Examenesfrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Examenesfrm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Examenesfrm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox minim;
        private System.Windows.Forms.PictureBox restau;
        private System.Windows.Forms.PictureBox cerrarclic;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo4;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo3;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo2;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo1;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colexaminadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidexamen;
    }
}