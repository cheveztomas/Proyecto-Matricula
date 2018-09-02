namespace ProyectoMatriculas
{
    partial class frm_Estudiantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdLista = new System.Windows.Forms.DataGridView();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.txtBuscarCarnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarIdentificación = new System.Windows.Forms.TextBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAAFechaIngreso = new System.Windows.Forms.TextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.txtAAFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtAATel = new System.Windows.Forms.TextBox();
            this.txtAAOtrasSenias = new System.Windows.Forms.RichTextBox();
            this.txtAANacionalidad = new System.Windows.Forms.TextBox();
            this.txtAACorreo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CmbAAProvincia = new System.Windows.Forms.ComboBox();
            this.txtAACanton = new System.Windows.Forms.TextBox();
            this.txtAADistrito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAASegundoApellido = new System.Windows.Forms.TextBox();
            this.txtAAPrimerApellido = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAANombre = new System.Windows.Forms.TextBox();
            this.txtAAIdentificacion = new System.Windows.Forms.TextBox();
            this.txtAACarnet = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdLista);
            this.groupBox1.Controls.Add(this.btnBuscarEstudiante);
            this.groupBox1.Controls.Add(this.txtBuscarCarnet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBuscarIdentificación);
            this.groupBox1.Controls.Add(this.txtBuscarNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(799, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Estudiante";
            // 
            // grdLista
            // 
            this.grdLista.AllowUserToAddRows = false;
            this.grdLista.AllowUserToDeleteRows = false;
            this.grdLista.AllowUserToResizeColumns = false;
            this.grdLista.AllowUserToResizeRows = false;
            this.grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carnet,
            this.Identificacion,
            this.Nombre,
            this.Estado});
            this.grdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdLista.Location = new System.Drawing.Point(8, 78);
            this.grdLista.MultiSelect = false;
            this.grdLista.Name = "grdLista";
            this.grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLista.Size = new System.Drawing.Size(782, 135);
            this.grdLista.TabIndex = 7;
            this.grdLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLista_CellDoubleClick);
            // 
            // Carnet
            // 
            this.Carnet.DataPropertyName = "CARNET";
            this.Carnet.FillWeight = 200F;
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            this.Carnet.Width = 72;
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "ID_ESTUDIANTE";
            this.Identificacion.HeaderText = "Indentificación";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Width = 170;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NOMBRECONCATENADO";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 400;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "ESTADO";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 76;
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(691, 43);
            this.btnBuscarEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarEstudiante.TabIndex = 6;
            this.btnBuscarEstudiante.Text = "&Buscar";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // txtBuscarCarnet
            // 
            this.txtBuscarCarnet.Location = new System.Drawing.Point(8, 47);
            this.txtBuscarCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarCarnet.Name = "txtBuscarCarnet";
            this.txtBuscarCarnet.Size = new System.Drawing.Size(99, 22);
            this.txtBuscarCarnet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // txtBuscarIdentificación
            // 
            this.txtBuscarIdentificación.Location = new System.Drawing.Point(116, 47);
            this.txtBuscarIdentificación.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarIdentificación.Name = "txtBuscarIdentificación";
            this.txtBuscarIdentificación.Size = new System.Drawing.Size(132, 22);
            this.txtBuscarIdentificación.TabIndex = 2;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(257, 47);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(422, 22);
            this.txtBuscarNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Identificación:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.txtAAFechaIngreso);
            this.groupBox2.Controls.Add(this.CmbEstado);
            this.groupBox2.Controls.Add(this.txtAAFechaNacimiento);
            this.groupBox2.Controls.Add(this.txtAATel);
            this.groupBox2.Controls.Add(this.txtAAOtrasSenias);
            this.groupBox2.Controls.Add(this.txtAANacionalidad);
            this.groupBox2.Controls.Add(this.txtAACorreo);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.CmbAAProvincia);
            this.groupBox2.Controls.Add(this.txtAACanton);
            this.groupBox2.Controls.Add(this.txtAADistrito);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAASegundoApellido);
            this.groupBox2.Controls.Add(this.txtAAPrimerApellido);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtAANombre);
            this.groupBox2.Controls.Add(this.txtAAIdentificacion);
            this.groupBox2.Controls.Add(this.txtAACarnet);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 241);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(799, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estudiante";
            // 
            // txtAAFechaIngreso
            // 
            this.txtAAFechaIngreso.Enabled = false;
            this.txtAAFechaIngreso.Location = new System.Drawing.Point(627, 212);
            this.txtAAFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtAAFechaIngreso.Name = "txtAAFechaIngreso";
            this.txtAAFechaIngreso.Size = new System.Drawing.Size(163, 22);
            this.txtAAFechaIngreso.TabIndex = 22;
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "ACT",
            "INA"});
            this.CmbEstado.Location = new System.Drawing.Point(488, 209);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(125, 24);
            this.CmbEstado.TabIndex = 21;
            // 
            // txtAAFechaNacimiento
            // 
            this.txtAAFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtAAFechaNacimiento.Location = new System.Drawing.Point(12, 103);
            this.txtAAFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAAFechaNacimiento.Name = "txtAAFechaNacimiento";
            this.txtAAFechaNacimiento.Size = new System.Drawing.Size(147, 22);
            this.txtAAFechaNacimiento.TabIndex = 13;
            // 
            // txtAATel
            // 
            this.txtAATel.Location = new System.Drawing.Point(8, 209);
            this.txtAATel.Margin = new System.Windows.Forms.Padding(4);
            this.txtAATel.MaxLength = 8;
            this.txtAATel.Name = "txtAATel";
            this.txtAATel.Size = new System.Drawing.Size(132, 22);
            this.txtAATel.TabIndex = 19;
            this.txtAATel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAATel_KeyPress);
            // 
            // txtAAOtrasSenias
            // 
            this.txtAAOtrasSenias.Location = new System.Drawing.Point(107, 135);
            this.txtAAOtrasSenias.Margin = new System.Windows.Forms.Padding(4);
            this.txtAAOtrasSenias.MaxLength = 80;
            this.txtAAOtrasSenias.Name = "txtAAOtrasSenias";
            this.txtAAOtrasSenias.Size = new System.Drawing.Size(683, 46);
            this.txtAAOtrasSenias.TabIndex = 18;
            this.txtAAOtrasSenias.Text = "";
            // 
            // txtAANacionalidad
            // 
            this.txtAANacionalidad.Location = new System.Drawing.Point(168, 103);
            this.txtAANacionalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAANacionalidad.Name = "txtAANacionalidad";
            this.txtAANacionalidad.Size = new System.Drawing.Size(147, 22);
            this.txtAANacionalidad.TabIndex = 14;
            this.txtAANacionalidad.Text = "Costa Rica";
            // 
            // txtAACorreo
            // 
            this.txtAACorreo.Location = new System.Drawing.Point(149, 212);
            this.txtAACorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAACorreo.MaxLength = 20;
            this.txtAACorreo.Name = "txtAACorreo";
            this.txtAACorreo.Size = new System.Drawing.Size(329, 22);
            this.txtAACorreo.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 139);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 16);
            this.label20.TabIndex = 14;
            this.label20.Text = "Otras Señas:";
            // 
            // CmbAAProvincia
            // 
            this.CmbAAProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAAProvincia.FormattingEnabled = true;
            this.CmbAAProvincia.Items.AddRange(new object[] {
            "ALAJUELA",
            "SAN JOSE",
            "HEREDIA",
            "GUANACASTE",
            "CARTAGO",
            "PUNTARENAS",
            "LIMON"});
            this.CmbAAProvincia.Location = new System.Drawing.Point(324, 102);
            this.CmbAAProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.CmbAAProvincia.Name = "CmbAAProvincia";
            this.CmbAAProvincia.Size = new System.Drawing.Size(121, 24);
            this.CmbAAProvincia.TabIndex = 15;
            // 
            // txtAACanton
            // 
            this.txtAACanton.Location = new System.Drawing.Point(452, 103);
            this.txtAACanton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAACanton.MaxLength = 20;
            this.txtAACanton.Name = "txtAACanton";
            this.txtAACanton.Size = new System.Drawing.Size(165, 22);
            this.txtAACanton.TabIndex = 16;
            // 
            // txtAADistrito
            // 
            this.txtAADistrito.Location = new System.Drawing.Point(627, 103);
            this.txtAADistrito.Margin = new System.Windows.Forms.Padding(4);
            this.txtAADistrito.MaxLength = 25;
            this.txtAADistrito.Name = "txtAADistrito";
            this.txtAADistrito.Size = new System.Drawing.Size(163, 22);
            this.txtAADistrito.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Distrito:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cantón:";
            // 
            // txtAASegundoApellido
            // 
            this.txtAASegundoApellido.Location = new System.Drawing.Point(627, 47);
            this.txtAASegundoApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtAASegundoApellido.MaxLength = 20;
            this.txtAASegundoApellido.Name = "txtAASegundoApellido";
            this.txtAASegundoApellido.Size = new System.Drawing.Size(163, 22);
            this.txtAASegundoApellido.TabIndex = 12;
            // 
            // txtAAPrimerApellido
            // 
            this.txtAAPrimerApellido.Location = new System.Drawing.Point(455, 47);
            this.txtAAPrimerApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtAAPrimerApellido.MaxLength = 20;
            this.txtAAPrimerApellido.Name = "txtAAPrimerApellido";
            this.txtAAPrimerApellido.Size = new System.Drawing.Size(163, 22);
            this.txtAAPrimerApellido.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(623, 27);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 16);
            this.label19.TabIndex = 13;
            this.label19.Text = "Segundo Apellido:";
            // 
            // txtAANombre
            // 
            this.txtAANombre.Location = new System.Drawing.Point(257, 47);
            this.txtAANombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtAANombre.MaxLength = 25;
            this.txtAANombre.Name = "txtAANombre";
            this.txtAANombre.Size = new System.Drawing.Size(188, 22);
            this.txtAANombre.TabIndex = 10;
            // 
            // txtAAIdentificacion
            // 
            this.txtAAIdentificacion.Location = new System.Drawing.Point(116, 47);
            this.txtAAIdentificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtAAIdentificacion.MaxLength = 20;
            this.txtAAIdentificacion.Name = "txtAAIdentificacion";
            this.txtAAIdentificacion.Size = new System.Drawing.Size(132, 22);
            this.txtAAIdentificacion.TabIndex = 9;
            // 
            // txtAACarnet
            // 
            this.txtAACarnet.Enabled = false;
            this.txtAACarnet.Location = new System.Drawing.Point(8, 47);
            this.txtAACarnet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAACarnet.Name = "txtAACarnet";
            this.txtAACarnet.Size = new System.Drawing.Size(99, 22);
            this.txtAACarnet.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 84);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "Fecha de Nacimiento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Nombre:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 193);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 16);
            this.label17.TabIndex = 11;
            this.label17.Text = "Teléfono:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(484, 193);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Estado:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(145, 193);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "Correo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Primer Apellido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(623, 193);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Fecha de Ingreso:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nacionalidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Provincia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Identificación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Carnet:";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Location = new System.Drawing.Point(715, 506);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AllowDrop = true;
            this.btnGuardar.Location = new System.Drawing.Point(607, 506);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Location = new System.Drawing.Point(499, 506);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(417, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "&Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Estudiantes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.frm_Estudiantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.TextBox txtBuscarCarnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarIdentificación;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAASegundoApellido;
        private System.Windows.Forms.TextBox txtAAPrimerApellido;
        private System.Windows.Forms.TextBox txtAANombre;
        private System.Windows.Forms.TextBox txtAAIdentificacion;
        private System.Windows.Forms.TextBox txtAACarnet;
        private System.Windows.Forms.ComboBox CmbAAProvincia;
        private System.Windows.Forms.TextBox txtAACanton;
        private System.Windows.Forms.TextBox txtAADistrito;
        private System.Windows.Forms.TextBox txtAACorreo;
        private System.Windows.Forms.TextBox txtAANacionalidad;
        private System.Windows.Forms.TextBox txtAATel;
        private System.Windows.Forms.RichTextBox txtAAOtrasSenias;
        private System.Windows.Forms.DateTimePicker txtAAFechaNacimiento;
        private System.Windows.Forms.TextBox txtAAFechaIngreso;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}