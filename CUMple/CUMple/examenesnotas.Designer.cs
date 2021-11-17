
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cedula,
            this.idexamen,
            this.notas,
            this.nuevo_rango});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvexamenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvexamenes.EnableHeadersVisualStyles = false;
            this.dgvexamenes.GridColor = System.Drawing.Color.White;
            this.dgvexamenes.Location = new System.Drawing.Point(489, 234);
            this.dgvexamenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvexamenes.Name = "dgvexamenes";
            this.dgvexamenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvexamenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvexamenes.RowHeadersWidth = 62;
            this.dgvexamenes.Size = new System.Drawing.Size(1005, 625);
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
            this.cedula.Width = 128;
            // 
            // idexamen
            // 
            this.idexamen.DataPropertyName = "idexamen";
            this.idexamen.HeaderText = "ID del exámen";
            this.idexamen.MinimumWidth = 8;
            this.idexamen.Name = "idexamen";
            this.idexamen.Width = 202;
            // 
            // notas
            // 
            this.notas.DataPropertyName = "notas";
            this.notas.HeaderText = "Nota";
            this.notas.MinimumWidth = 8;
            this.notas.Name = "notas";
            this.notas.Width = 103;
            // 
            // nuevo_rango
            // 
            this.nuevo_rango.DataPropertyName = "nuevo_rango";
            this.nuevo_rango.HeaderText = "Rango nuevo";
            this.nuevo_rango.MinimumWidth = 8;
            this.nuevo_rango.Name = "nuevo_rango";
            this.nuevo_rango.Width = 186;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(6, 505);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(258, 54);
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
            this.btneliminar.Location = new System.Drawing.Point(6, 180);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(255, 54);
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
            this.btnagregar.Location = new System.Drawing.Point(8, 66);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(255, 54);
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
            this.btneditar.Location = new System.Drawing.Point(4, 288);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(260, 54);
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
            this.cbidexamen.Location = new System.Drawing.Point(1014, 169);
            this.cbidexamen.Name = "cbidexamen";
            this.cbidexamen.Size = new System.Drawing.Size(112, 37);
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
            this.txbnota.Location = new System.Drawing.Point(632, 183);
            this.txbnota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbnota.Name = "txbnota";
            this.txbnota.Size = new System.Drawing.Size(194, 30);
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
            this.lblid.Location = new System.Drawing.Point(484, 183);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(80, 29);
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
            this.label1.Location = new System.Drawing.Point(921, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
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
            this.cbrango.Location = new System.Drawing.Point(1014, 72);
            this.cbrango.Name = "cbrango";
            this.cbrango.Size = new System.Drawing.Size(252, 37);
            this.cbrango.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(904, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
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
            this.cbcedula.Location = new System.Drawing.Point(632, 74);
            this.cbcedula.Name = "cbcedula";
            this.cbcedula.Size = new System.Drawing.Size(238, 37);
            this.cbcedula.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(484, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 54);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1506, 5);
            this.minimizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(56, 46);
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
            this.restaurarr.Location = new System.Drawing.Point(1436, 5);
            this.restaurarr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.restaurarr.Name = "restaurarr";
            this.restaurarr.Size = new System.Drawing.Size(56, 46);
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
            this.cerrarclic.Location = new System.Drawing.Point(1576, 5);
            this.cerrarclic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cerrarclic.Name = "cerrarclic";
            this.cerrarclic.Size = new System.Drawing.Size(56, 46);
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
            this.maximizar.Location = new System.Drawing.Point(1506, 5);
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
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 804);
            this.panel2.TabIndex = 47;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 618);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 60);
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
            this.btnvolverexamenes.Location = new System.Drawing.Point(4, 618);
            this.btnvolverexamenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnvolverexamenes.Name = "btnvolverexamenes";
            this.btnvolverexamenes.Size = new System.Drawing.Size(260, 60);
            this.btnvolverexamenes.TabIndex = 10;
            this.btnvolverexamenes.Text = "Volver";
            this.btnvolverexamenes.UseVisualStyleBackColor = false;
            this.btnvolverexamenes.Click += new System.EventHandler(this.btnvolverexamenes_Click);
            // 
            // panelapoyo4
            // 
            this.panelapoyo4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo4.Location = new System.Drawing.Point(0, 505);
            this.panelapoyo4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelapoyo4.Name = "panelapoyo4";
            this.panelapoyo4.Size = new System.Drawing.Size(8, 54);
            this.panelapoyo4.TabIndex = 56;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-2, 402);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 54);
            this.flowLayoutPanel2.TabIndex = 57;
            // 
            // panelapoyo3
            // 
            this.panelapoyo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo3.Location = new System.Drawing.Point(0, 288);
            this.panelapoyo3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelapoyo3.Name = "panelapoyo3";
            this.panelapoyo3.Size = new System.Drawing.Size(8, 54);
            this.panelapoyo3.TabIndex = 57;
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(3, 402);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(260, 54);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscarr_Click);
            // 
            // panelapoyo2
            // 
            this.panelapoyo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo2.Location = new System.Drawing.Point(0, 180);
            this.panelapoyo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelapoyo2.Name = "panelapoyo2";
            this.panelapoyo2.Size = new System.Drawing.Size(8, 54);
            this.panelapoyo2.TabIndex = 58;
            // 
            // panelapoyo1
            // 
            this.panelapoyo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panelapoyo1.Location = new System.Drawing.Point(0, 66);
            this.panelapoyo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelapoyo1.Name = "panelapoyo1";
            this.panelapoyo1.Size = new System.Drawing.Size(8, 54);
            this.panelapoyo1.TabIndex = 54;
            // 
            // examenesnotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1650, 858);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}