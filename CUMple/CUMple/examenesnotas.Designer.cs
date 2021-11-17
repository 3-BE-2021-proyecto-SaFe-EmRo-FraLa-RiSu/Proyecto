
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examenesnotas));
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
            this.txbnota = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbrango = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcedula = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.restaurarr = new System.Windows.Forms.PictureBox();
            this.cerrarclic = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnvolverexamenes = new System.Windows.Forms.Button();
            this.panelapoyo4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.panelapoyo2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelapoyo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurarr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).BeginInit();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvexamenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvexamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexamenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.idexamen,
            this.notas,
            this.nuevo_rango});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvexamenes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvexamenes.EnableHeadersVisualStyles = false;
            this.dgvexamenes.GridColor = System.Drawing.Color.White;
            this.dgvexamenes.Location = new System.Drawing.Point(315, 152);
            this.dgvexamenes.Name = "dgvexamenes";
            this.dgvexamenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvexamenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvexamenes.RowHeadersWidth = 62;
            this.dgvexamenes.Size = new System.Drawing.Size(670, 406);
            this.dgvexamenes.TabIndex = 0;
            this.dgvexamenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexamenes_CellClick);
            this.dgvexamenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cedula
            // 
            this.cedula.DataPropertyName = "cedula";
            this.cedula.HeaderText = "Cédula";
            this.cedula.MinimumWidth = 8;
            this.cedula.Name = "cedula";
            this.cedula.Width = 87;
            // 
            // idexamen
            // 
            this.idexamen.DataPropertyName = "idexamen";
            this.idexamen.HeaderText = "ID del exámen";
            this.idexamen.MinimumWidth = 8;
            this.idexamen.Name = "idexamen";
            this.idexamen.Width = 138;
            // 
            // notas
            // 
            this.notas.DataPropertyName = "notas";
            this.notas.HeaderText = "Nota";
            this.notas.MinimumWidth = 8;
            this.notas.Name = "notas";
            this.notas.Width = 70;
            // 
            // nuevo_rango
            // 
            this.nuevo_rango.DataPropertyName = "nuevo_rango";
            this.nuevo_rango.HeaderText = "Rango nuevo";
            this.nuevo_rango.MinimumWidth = 8;
            this.nuevo_rango.Name = "nuevo_rango";
            this.nuevo_rango.Width = 125;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(4, 328);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(172, 35);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(4, 117);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(170, 35);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(5, 43);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(170, 35);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneditar
            // 
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(3, 187);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(173, 35);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // cbidexamen
            // 
            this.cbidexamen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbidexamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbidexamen.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbidexamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidexamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbidexamen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbidexamen.ForeColor = System.Drawing.Color.White;
            this.cbidexamen.FormattingEnabled = true;
            this.cbidexamen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbidexamen.Location = new System.Drawing.Point(676, 110);
            this.cbidexamen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbidexamen.Name = "cbidexamen";
            this.cbidexamen.Size = new System.Drawing.Size(76, 26);
            this.cbidexamen.TabIndex = 4;
            this.cbidexamen.SelectedIndexChanged += new System.EventHandler(this.cbidexamen_SelectedIndexChanged);
            // 
            // txbnota
            // 
            this.txbnota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbnota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txbnota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbnota.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnota.ForeColor = System.Drawing.Color.White;
            this.txbnota.Location = new System.Drawing.Point(422, 113);
            this.txbnota.Name = "txbnota";
            this.txbnota.Size = new System.Drawing.Size(84, 20);
            this.txbnota.TabIndex = 2;
            this.txbnota.TextChanged += new System.EventHandler(this.txbnota_TextChanged);
            this.txbnota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbnota_KeyPress);
            // 
            // lblid
            // 
            this.lblid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(340, 118);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(54, 18);
            this.lblid.TabIndex = 36;
            this.lblid.Text = "Nota:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(614, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID:";
            // 
            // cbrango
            // 
            this.cbrango.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbrango.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbrango.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbrango.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrango.ForeColor = System.Drawing.Color.White;
            this.cbrango.FormattingEnabled = true;
            this.cbrango.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbrango.Items.AddRange(new object[] {
            "Blanco",
            "Blanco confirmado",
            "Naranja",
            "Naranja confirmado",
            "Amarillo",
            "Amarillo confirmado",
            "Camuflado",
            "Camuflado confirmado",
            "Verde",
            "Verde confirmado",
            "Violeta",
            "Violeta confirmado",
            "Marrón",
            "Marrón cornfirmado",
            "Rojo ",
            "Rojo confirmado",
            "Rojo negro",
            "Rojo negro confirmado",
            "Negro",
            "Negro confirmado",
            "1mer DAN",
            "2ndo DAN",
            "3er DAN",
            "4to DAN"});
            this.cbrango.Location = new System.Drawing.Point(676, 47);
            this.cbrango.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbrango.Name = "cbrango";
            this.cbrango.Size = new System.Drawing.Size(169, 26);
            this.cbrango.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(603, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Rango:";
            // 
            // cbcedula
            // 
            this.cbcedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbcedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbcedula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcedula.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcedula.ForeColor = System.Drawing.Color.White;
            this.cbcedula.FormattingEnabled = true;
            this.cbcedula.Location = new System.Drawing.Point(421, 48);
            this.cbcedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcedula.Name = "cbcedula";
            this.cbcedula.Size = new System.Drawing.Size(160, 26);
            this.cbcedula.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(323, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cédula:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.restaurarr);
            this.panel1.Controls.Add(this.cerrarclic);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1004, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(37, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 19;
            this.minimizar.TabStop = false;
            this.minimizar.Visible = false;
            this.minimizar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // restaurarr
            // 
            this.restaurarr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restaurarr.Image = ((System.Drawing.Image)(resources.GetObject("restaurarr.Image")));
            this.restaurarr.Location = new System.Drawing.Point(957, 3);
            this.restaurarr.Name = "restaurarr";
            this.restaurarr.Size = new System.Drawing.Size(37, 30);
            this.restaurarr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurarr.TabIndex = 18;
            this.restaurarr.TabStop = false;
            this.restaurarr.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrarclic
            // 
            this.cerrarclic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarclic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cerrarclic.Image = ((System.Drawing.Image)(resources.GetObject("cerrarclic.Image")));
            this.cerrarclic.Location = new System.Drawing.Point(1051, 3);
            this.cerrarclic.Name = "cerrarclic";
            this.cerrarclic.Size = new System.Drawing.Size(37, 30);
            this.cerrarclic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarclic.TabIndex = 17;
            this.cerrarclic.TabStop = false;
            this.cerrarclic.Click += new System.EventHandler(this.cerrarclic_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1004, 3);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(37, 30);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 16;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Controls.Add(this.btnvolverexamenes);
            this.panel2.Controls.Add(this.panelapoyo4);
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.panelapoyo3);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.btneditar);
            this.panel2.Controls.Add(this.panelapoyo2);
            this.panel2.Controls.Add(this.btnlimpiar);
            this.panel2.Controls.Add(this.panelapoyo1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 523);
            this.panel2.TabIndex = 47;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 402);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(5, 39);
            this.flowLayoutPanel1.TabIndex = 53;
            // 
            // btnvolverexamenes
            // 
            this.btnvolverexamenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnvolverexamenes.FlatAppearance.BorderSize = 0;
            this.btnvolverexamenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnvolverexamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolverexamenes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolverexamenes.ForeColor = System.Drawing.Color.Transparent;
            this.btnvolverexamenes.Location = new System.Drawing.Point(3, 402);
            this.btnvolverexamenes.Name = "btnvolverexamenes";
            this.btnvolverexamenes.Size = new System.Drawing.Size(173, 39);
            this.btnvolverexamenes.TabIndex = 10;
            this.btnvolverexamenes.Text = "Volver";
            this.btnvolverexamenes.UseVisualStyleBackColor = false;
            this.btnvolverexamenes.Click += new System.EventHandler(this.btnvolverexamenes_Click);
            // 
            // panelapoyo4
            // 
            this.panelapoyo4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo4.Location = new System.Drawing.Point(0, 328);
            this.panelapoyo4.Name = "panelapoyo4";
            this.panelapoyo4.Size = new System.Drawing.Size(5, 35);
            this.panelapoyo4.TabIndex = 56;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-1, 261);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(5, 35);
            this.flowLayoutPanel2.TabIndex = 57;
            // 
            // panelapoyo3
            // 
            this.panelapoyo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo3.Location = new System.Drawing.Point(0, 187);
            this.panelapoyo3.Name = "panelapoyo3";
            this.panelapoyo3.Size = new System.Drawing.Size(5, 35);
            this.panelapoyo3.TabIndex = 57;
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(2, 261);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(173, 35);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscarr_Click);
            // 
            // panelapoyo2
            // 
            this.panelapoyo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo2.Location = new System.Drawing.Point(0, 117);
            this.panelapoyo2.Name = "panelapoyo2";
            this.panelapoyo2.Size = new System.Drawing.Size(5, 35);
            this.panelapoyo2.TabIndex = 58;
            // 
            // panelapoyo1
            // 
            this.panelapoyo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo1.Location = new System.Drawing.Point(0, 43);
            this.panelapoyo1.Name = "panelapoyo1";
            this.panelapoyo1.Size = new System.Drawing.Size(5, 35);
            this.panelapoyo1.TabIndex = 54;
            // 
            // panelapoyo
            // 
            this.panelapoyo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelapoyo.BackColor = System.Drawing.Color.Gray;
            this.panelapoyo.Location = new System.Drawing.Point(421, 136);
            this.panelapoyo.Name = "panelapoyo";
            this.panelapoyo.Size = new System.Drawing.Size(87, 1);
            this.panelapoyo.TabIndex = 48;
            // 
            // examenesnotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 558);
            this.Controls.Add(this.panelapoyo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbcedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbrango);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbnota);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.cbidexamen);
            this.Controls.Add(this.dgvexamenes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "examenesnotas";
            this.Text = "examenesnotas";
            this.Load += new System.EventHandler(this.examenesnotas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.examenesnotas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexamenes)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurarr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarclic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvexamenes;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.ComboBox cbidexamen;
        private System.Windows.Forms.TextBox txbnota;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbrango;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn idexamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuevo_rango;
        private System.Windows.Forms.ComboBox cbcedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox restaurarr;
        private System.Windows.Forms.PictureBox cerrarclic;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo4;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo3;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo2;
        private System.Windows.Forms.FlowLayoutPanel panelapoyo1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnvolverexamenes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Panel panelapoyo;
    }
}