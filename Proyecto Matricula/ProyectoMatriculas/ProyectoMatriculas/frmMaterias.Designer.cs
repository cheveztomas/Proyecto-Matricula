namespace ProyectoMatriculas
{
    partial class frmMaterias
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
            this.txtBuscarCarrera = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAAMATERIACreditos = new System.Windows.Forms.TextBox();
            this.TxtAAMATERIANombre = new System.Windows.Forms.TextBox();
            this.txtAAMATERIACodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.Label();
            this.grdListaCarreras = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCreditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarCarrera = new System.Windows.Forms.Button();
            this.txtBusCARRERA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdListaMaterias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAABuscarMateriaNombre = new System.Windows.Forms.TextBox();
            this.txtBuscarMateriaCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarMateria = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBuscarCarrera.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCarreras)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCarrera
            // 
            this.txtBuscarCarrera.BackColor = System.Drawing.SystemColors.Info;
            this.txtBuscarCarrera.Controls.Add(this.label4);
            this.txtBuscarCarrera.Controls.Add(this.button3);
            this.txtBuscarCarrera.Controls.Add(this.groupBox1);
            this.txtBuscarCarrera.Controls.Add(this.txtCarrera);
            this.txtBuscarCarrera.Controls.Add(this.C);
            this.txtBuscarCarrera.Controls.Add(this.grdListaCarreras);
            this.txtBuscarCarrera.Controls.Add(this.btnBuscarCarrera);
            this.txtBuscarCarrera.Controls.Add(this.txtBusCARRERA);
            this.txtBuscarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCarrera.Location = new System.Drawing.Point(12, 12);
            this.txtBuscarCarrera.Name = "txtBuscarCarrera";
            this.txtBuscarCarrera.Size = new System.Drawing.Size(779, 325);
            this.txtBuscarCarrera.TabIndex = 0;
            this.txtBuscarCarrera.TabStop = false;
            this.txtBuscarCarrera.Text = "Materias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleccionar Carrera:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtAAMATERIACreditos);
            this.groupBox1.Controls.Add(this.TxtAAMATERIANombre);
            this.groupBox1.Controls.Add(this.txtAAMATERIACodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Créditos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Guarda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAAMATERIACreditos
            // 
            this.txtAAMATERIACreditos.Location = new System.Drawing.Point(580, 38);
            this.txtAAMATERIACreditos.MaxLength = 1;
            this.txtAAMATERIACreditos.Name = "txtAAMATERIACreditos";
            this.txtAAMATERIACreditos.Size = new System.Drawing.Size(100, 20);
            this.txtAAMATERIACreditos.TabIndex = 3;
            // 
            // TxtAAMATERIANombre
            // 
            this.TxtAAMATERIANombre.Location = new System.Drawing.Point(123, 38);
            this.TxtAAMATERIANombre.MaxLength = 120;
            this.TxtAAMATERIANombre.Name = "TxtAAMATERIANombre";
            this.TxtAAMATERIANombre.Size = new System.Drawing.Size(451, 20);
            this.TxtAAMATERIANombre.TabIndex = 2;
            // 
            // txtAAMATERIACodigo
            // 
            this.txtAAMATERIACodigo.Location = new System.Drawing.Point(6, 38);
            this.txtAAMATERIACodigo.MaxLength = 10;
            this.txtAAMATERIACodigo.Name = "txtAAMATERIACodigo";
            this.txtAAMATERIACodigo.Size = new System.Drawing.Size(111, 20);
            this.txtAAMATERIACodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Materia:";
            // 
            // txtCarrera
            // 
            this.txtCarrera.BackColor = System.Drawing.SystemColors.Control;
            this.txtCarrera.Enabled = false;
            this.txtCarrera.Location = new System.Drawing.Point(149, 190);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(366, 20);
            this.txtCarrera.TabIndex = 5;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(6, 193);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(133, 13);
            this.C.TabIndex = 4;
            this.C.Text = "Carrera Seleccionada:";
            // 
            // grdListaCarreras
            // 
            this.grdListaCarreras.AllowUserToAddRows = false;
            this.grdListaCarreras.AllowUserToDeleteRows = false;
            this.grdListaCarreras.AllowUserToResizeColumns = false;
            this.grdListaCarreras.AllowUserToResizeRows = false;
            this.grdListaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreCarrera,
            this.TotalCreditos,
            this.GRADO});
            this.grdListaCarreras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaCarreras.Location = new System.Drawing.Point(6, 67);
            this.grdListaCarreras.MultiSelect = false;
            this.grdListaCarreras.Name = "grdListaCarreras";
            this.grdListaCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaCarreras.Size = new System.Drawing.Size(767, 117);
            this.grdListaCarreras.TabIndex = 3;
            this.grdListaCarreras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaCarreras_CellDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "COD_CARRERA";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // NombreCarrera
            // 
            this.NombreCarrera.DataPropertyName = "NOMBRE_CARRERA";
            this.NombreCarrera.HeaderText = "Nombre Carrera";
            this.NombreCarrera.Name = "NombreCarrera";
            this.NombreCarrera.Width = 350;
            // 
            // TotalCreditos
            // 
            this.TotalCreditos.DataPropertyName = "TOTAL_CREDITOS";
            this.TotalCreditos.HeaderText = "Total Créditos";
            this.TotalCreditos.Name = "TotalCreditos";
            this.TotalCreditos.Width = 150;
            // 
            // GRADO
            // 
            this.GRADO.DataPropertyName = "GRADO";
            this.GRADO.HeaderText = "Grado";
            this.GRADO.Name = "GRADO";
            // 
            // btnBuscarCarrera
            // 
            this.btnBuscarCarrera.Location = new System.Drawing.Point(205, 19);
            this.btnBuscarCarrera.Name = "btnBuscarCarrera";
            this.btnBuscarCarrera.Size = new System.Drawing.Size(124, 23);
            this.btnBuscarCarrera.TabIndex = 5;
            this.btnBuscarCarrera.Text = "Buscar Carrera";
            this.btnBuscarCarrera.UseVisualStyleBackColor = true;
            this.btnBuscarCarrera.Click += new System.EventHandler(this.btnBuscarCarrera_Click);
            // 
            // txtBusCARRERA
            // 
            this.txtBusCARRERA.Location = new System.Drawing.Point(6, 19);
            this.txtBusCARRERA.Name = "txtBusCARRERA";
            this.txtBusCARRERA.Size = new System.Drawing.Size(193, 20);
            this.txtBusCARRERA.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdListaMaterias);
            this.groupBox2.Controls.Add(this.txtAABuscarMateriaNombre);
            this.groupBox2.Controls.Add(this.txtBuscarMateriaCodigo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnBuscarMateria);
            this.groupBox2.Location = new System.Drawing.Point(12, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Materia";
            // 
            // grdListaMaterias
            // 
            this.grdListaMaterias.AllowUserToAddRows = false;
            this.grdListaMaterias.AllowUserToDeleteRows = false;
            this.grdListaMaterias.AllowUserToResizeColumns = false;
            this.grdListaMaterias.AllowUserToResizeRows = false;
            this.grdListaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NombreMateria,
            this.Creditos});
            this.grdListaMaterias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaMaterias.Location = new System.Drawing.Point(6, 45);
            this.grdListaMaterias.MultiSelect = false;
            this.grdListaMaterias.Name = "grdListaMaterias";
            this.grdListaMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaMaterias.Size = new System.Drawing.Size(767, 132);
            this.grdListaMaterias.TabIndex = 5;
            this.grdListaMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaMaterias_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_MATERIA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // NombreMateria
            // 
            this.NombreMateria.DataPropertyName = "NOMBRE_MATERIA";
            this.NombreMateria.HeaderText = "Nombre Materia";
            this.NombreMateria.Name = "NombreMateria";
            this.NombreMateria.Width = 400;
            // 
            // Creditos
            // 
            this.Creditos.DataPropertyName = "CREDITOS";
            this.Creditos.HeaderText = "Créditos";
            this.Creditos.Name = "Creditos";
            this.Creditos.Width = 175;
            // 
            // txtAABuscarMateriaNombre
            // 
            this.txtAABuscarMateriaNombre.Location = new System.Drawing.Point(277, 19);
            this.txtAABuscarMateriaNombre.Name = "txtAABuscarMateriaNombre";
            this.txtAABuscarMateriaNombre.Size = new System.Drawing.Size(380, 20);
            this.txtAABuscarMateriaNombre.TabIndex = 8;
            // 
            // txtBuscarMateriaCodigo
            // 
            this.txtBuscarMateriaCodigo.Location = new System.Drawing.Point(93, 19);
            this.txtBuscarMateriaCodigo.Name = "txtBuscarMateriaCodigo";
            this.txtBuscarMateriaCodigo.Size = new System.Drawing.Size(87, 20);
            this.txtBuscarMateriaCodigo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre Materia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código Materia:";
            // 
            // btnBuscarMateria
            // 
            this.btnBuscarMateria.Location = new System.Drawing.Point(663, 17);
            this.btnBuscarMateria.Name = "btnBuscarMateria";
            this.btnBuscarMateria.Size = new System.Drawing.Size(104, 23);
            this.btnBuscarMateria.TabIndex = 9;
            this.btnBuscarMateria.Text = "Buscar Materia";
            this.btnBuscarMateria.UseVisualStyleBackColor = true;
            this.btnBuscarMateria.Click += new System.EventHandler(this.btnBuscarMateria_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(716, 532);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(635, 532);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 567);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBuscarCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaterias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            this.txtBuscarCarrera.ResumeLayout(false);
            this.txtBuscarCarrera.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCarreras)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtBuscarCarrera;
        private System.Windows.Forms.Button btnBuscarCarrera;
        private System.Windows.Forms.TextBox txtBusCARRERA;
        private System.Windows.Forms.DataGridView grdListaCarreras;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAAMATERIACreditos;
        private System.Windows.Forms.TextBox TxtAAMATERIANombre;
        private System.Windows.Forms.TextBox txtAAMATERIACodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscarMateria;
        private System.Windows.Forms.DataGridView grdListaMaterias;
        private System.Windows.Forms.TextBox txtAABuscarMateriaNombre;
        private System.Windows.Forms.TextBox txtBuscarMateriaCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
    }
}