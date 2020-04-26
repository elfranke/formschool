namespace Evaluacion
{
    partial class GEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.FLYPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pNombre = new System.Windows.Forms.Panel();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pApellidos = new System.Windows.Forms.Panel();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.pNacimiento = new System.Windows.Forms.Panel();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbNacimiento = new System.Windows.Forms.Label();
            this.pGrado = new System.Windows.Forms.Panel();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.lbGrado = new System.Windows.Forms.Label();
            this.pDireccion = new System.Windows.Forms.Panel();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.pSeccion = new System.Windows.Forms.Panel();
            this.tbSeccion = new System.Windows.Forms.TextBox();
            this.lbSeccion = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtgvEstudiante = new System.Windows.Forms.DataGridView();
            this.IdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.FLYPrincipal.SuspendLayout();
            this.pNombre.SuspendLayout();
            this.pApellidos.SuspendLayout();
            this.pNacimiento.SuspendLayout();
            this.pGrado.SuspendLayout();
            this.pDireccion.SuspendLayout();
            this.pSeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pNombre);
            this.FLYPrincipal.Controls.Add(this.pApellidos);
            this.FLYPrincipal.Controls.Add(this.pNacimiento);
            this.FLYPrincipal.Controls.Add(this.pGrado);
            this.FLYPrincipal.Controls.Add(this.pDireccion);
            this.FLYPrincipal.Controls.Add(this.pSeccion);
            this.FLYPrincipal.Controls.Add(this.btnBuscar);
            this.FLYPrincipal.Controls.Add(this.btnLimpiar);
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(745, 118);
            this.FLYPrincipal.TabIndex = 0;
            // 
            // pNombre
            // 
            this.pNombre.Controls.Add(this.tbNombre);
            this.pNombre.Controls.Add(this.lbNombre);
            this.pNombre.Location = new System.Drawing.Point(3, 3);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(180, 52);
            this.pNombre.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(3, 23);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(164, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.Tag = "Nombre";
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged_1);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(3, 4);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(63, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // pApellidos
            // 
            this.pApellidos.Controls.Add(this.tbApellidos);
            this.pApellidos.Controls.Add(this.lbApellidos);
            this.pApellidos.Location = new System.Drawing.Point(189, 3);
            this.pApellidos.Name = "pApellidos";
            this.pApellidos.Size = new System.Drawing.Size(180, 52);
            this.pApellidos.TabIndex = 2;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(3, 23);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(164, 20);
            this.tbApellidos.TabIndex = 1;
            this.tbApellidos.Tag = "Apellidos";
            this.tbApellidos.TextChanged += new System.EventHandler(this.tbApellidos_TextChanged);
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(3, 4);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(74, 16);
            this.lbApellidos.TabIndex = 0;
            this.lbApellidos.Text = "Apellidos";
            // 
            // pNacimiento
            // 
            this.pNacimiento.Controls.Add(this.dtpnacimiento);
            this.pNacimiento.Controls.Add(this.lbNacimiento);
            this.pNacimiento.Location = new System.Drawing.Point(375, 3);
            this.pNacimiento.Name = "pNacimiento";
            this.pNacimiento.Size = new System.Drawing.Size(180, 52);
            this.pNacimiento.TabIndex = 3;
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnacimiento.Location = new System.Drawing.Point(6, 22);
            this.dtpnacimiento.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.Size = new System.Drawing.Size(171, 20);
            this.dtpnacimiento.TabIndex = 1;
            this.dtpnacimiento.Tag = "nacimiento";
            this.dtpnacimiento.ValueChanged += new System.EventHandler(this.dtpnacimiento_ValueChanged);
            // 
            // lbNacimiento
            // 
            this.lbNacimiento.AutoSize = true;
            this.lbNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNacimiento.Location = new System.Drawing.Point(3, 4);
            this.lbNacimiento.Name = "lbNacimiento";
            this.lbNacimiento.Size = new System.Drawing.Size(86, 16);
            this.lbNacimiento.TabIndex = 0;
            this.lbNacimiento.Text = "Nacimiento";
            // 
            // pGrado
            // 
            this.pGrado.Controls.Add(this.cboGrado);
            this.pGrado.Controls.Add(this.lbGrado);
            this.pGrado.Location = new System.Drawing.Point(561, 3);
            this.pGrado.Name = "pGrado";
            this.pGrado.Size = new System.Drawing.Size(180, 52);
            this.pGrado.TabIndex = 4;
            // 
            // cboGrado
            // 
            this.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(4, 25);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(173, 21);
            this.cboGrado.TabIndex = 3;
            this.cboGrado.Tag = "Grado";
            this.cboGrado.SelectedIndexChanged += new System.EventHandler(this.cboGrado_SelectedIndexChanged);
            // 
            // lbGrado
            // 
            this.lbGrado.AutoSize = true;
            this.lbGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrado.Location = new System.Drawing.Point(3, 4);
            this.lbGrado.Name = "lbGrado";
            this.lbGrado.Size = new System.Drawing.Size(51, 16);
            this.lbGrado.TabIndex = 0;
            this.lbGrado.Text = "Grado";
            // 
            // pDireccion
            // 
            this.pDireccion.Controls.Add(this.tbDireccion);
            this.pDireccion.Controls.Add(this.lbDireccion);
            this.pDireccion.Location = new System.Drawing.Point(3, 61);
            this.pDireccion.Name = "pDireccion";
            this.pDireccion.Size = new System.Drawing.Size(366, 52);
            this.pDireccion.TabIndex = 6;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(3, 23);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(350, 20);
            this.tbDireccion.TabIndex = 1;
            this.tbDireccion.Tag = "Direccion";
            this.tbDireccion.TextChanged += new System.EventHandler(this.tbDireccion_TextChanged);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(3, 4);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(74, 16);
            this.lbDireccion.TabIndex = 0;
            this.lbDireccion.Text = "Direccion";
            // 
            // pSeccion
            // 
            this.pSeccion.Controls.Add(this.tbSeccion);
            this.pSeccion.Controls.Add(this.lbSeccion);
            this.pSeccion.Location = new System.Drawing.Point(375, 61);
            this.pSeccion.Name = "pSeccion";
            this.pSeccion.Size = new System.Drawing.Size(180, 52);
            this.pSeccion.TabIndex = 7;
            // 
            // tbSeccion
            // 
            this.tbSeccion.Location = new System.Drawing.Point(3, 23);
            this.tbSeccion.MaxLength = 1;
            this.tbSeccion.Name = "tbSeccion";
            this.tbSeccion.Size = new System.Drawing.Size(164, 20);
            this.tbSeccion.TabIndex = 1;
            this.tbSeccion.Tag = "Seccion";
            this.tbSeccion.TextChanged += new System.EventHandler(this.tbSeccion_TextChanged);
            // 
            // lbSeccion
            // 
            this.lbSeccion.AutoSize = true;
            this.lbSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeccion.Location = new System.Drawing.Point(3, 4);
            this.lbSeccion.Name = "lbSeccion";
            this.lbSeccion.Size = new System.Drawing.Size(64, 16);
            this.lbSeccion.TabIndex = 0;
            this.lbSeccion.Text = "Seccion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(561, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 200;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(642, 61);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 30);
            this.btnLimpiar.TabIndex = 200;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtgvEstudiante
            // 
            this.dtgvEstudiante.AllowUserToAddRows = false;
            this.dtgvEstudiante.AllowUserToDeleteRows = false;
            this.dtgvEstudiante.AllowUserToOrderColumns = true;
            this.dtgvEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEstudiante,
            this.Nombre,
            this.Apellidos,
            this.Nacimiento,
            this.Grado,
            this.IdSeccion,
            this.Seccion,
            this.Direccion});
            this.dtgvEstudiante.Location = new System.Drawing.Point(3, 131);
            this.dtgvEstudiante.Name = "dtgvEstudiante";
            this.dtgvEstudiante.ReadOnly = true;
            this.dtgvEstudiante.Size = new System.Drawing.Size(856, 276);
            this.dtgvEstudiante.TabIndex = 3;
            this.dtgvEstudiante.SelectionChanged += new System.EventHandler(this.dtgvEstudiante_SelectionChanged);
            // 
            // IdEstudiante
            // 
            this.IdEstudiante.DataPropertyName = "IdEstudiante";
            this.IdEstudiante.HeaderText = "IdEstudiante";
            this.IdEstudiante.Name = "IdEstudiante";
            this.IdEstudiante.ReadOnly = true;
            this.IdEstudiante.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Nacimiento
            // 
            this.Nacimiento.DataPropertyName = "Nacimiento";
            this.Nacimiento.HeaderText = "Nacimiento";
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // IdSeccion
            // 
            this.IdSeccion.DataPropertyName = "IdSeccion";
            this.IdSeccion.HeaderText = "IdSeccion";
            this.IdSeccion.Name = "IdSeccion";
            this.IdSeccion.ReadOnly = true;
            this.IdSeccion.Visible = false;
            // 
            // Seccion
            // 
            this.Seccion.DataPropertyName = "Seccion";
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
            this.Seccion.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(3, 413);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 30);
            this.btnEditar.TabIndex = 200;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(84, 413);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 30);
            this.btnNuevo.TabIndex = 200;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // GEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.FLYPrincipal);
            this.Controls.Add(this.dtgvEstudiante);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Name = "GEstudiante";
            this.Text = "GEstudiante";
            this.FLYPrincipal.ResumeLayout(false);
            this.FLYPrincipal.PerformLayout();
            this.pNombre.ResumeLayout(false);
            this.pNombre.PerformLayout();
            this.pApellidos.ResumeLayout(false);
            this.pApellidos.PerformLayout();
            this.pNacimiento.ResumeLayout(false);
            this.pNacimiento.PerformLayout();
            this.pGrado.ResumeLayout(false);
            this.pGrado.PerformLayout();
            this.pDireccion.ResumeLayout(false);
            this.pDireccion.PerformLayout();
            this.pSeccion.ResumeLayout(false);
            this.pSeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLYPrincipal;
        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.Panel pNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;

        private System.Windows.Forms.Panel pApellidos;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lbApellidos;

        private System.Windows.Forms.Panel pNacimiento;
        private System.Windows.Forms.Label lbNacimiento;

        private System.Windows.Forms.Panel pGrado;
        private System.Windows.Forms.Label lbGrado;

        private System.Windows.Forms.Panel pDireccion;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lbDireccion;

        private System.Windows.Forms.Panel pSeccion;
        private System.Windows.Forms.TextBox tbSeccion;
        private System.Windows.Forms.Label lbSeccion;

        private System.Windows.Forms.DataGridView dtgvEstudiante;
        private System.Windows.Forms.DateTimePicker dtpnacimiento;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
