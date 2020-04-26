namespace Evaluacion
{
    partial class LEstudiante
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
            this.pCriterio = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbbusqueda = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lbbusqueda = new System.Windows.Forms.Label();
            this.cboTabla = new System.Windows.Forms.ComboBox();
            this.dtgvEstudiante = new System.Windows.Forms.DataGridView();
            this.IdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProgreso = new System.Windows.Forms.Button();
            this.FLYPrincipal.SuspendLayout();
            this.pCriterio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pCriterio);
            this.FLYPrincipal.Controls.Add(this.cboTabla);
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(870, 60);
            this.FLYPrincipal.TabIndex = 0;
            // 
            // pCriterio
            // 
            this.pCriterio.Controls.Add(this.btnGuardar);
            this.pCriterio.Controls.Add(this.tbbusqueda);
            this.pCriterio.Controls.Add(this.cboCriterio);
            this.pCriterio.Controls.Add(this.lbbusqueda);
            this.pCriterio.Location = new System.Drawing.Point(3, 3);
            this.pCriterio.Name = "pCriterio";
            this.pCriterio.Size = new System.Drawing.Size(847, 52);
            this.pCriterio.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(765, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 30);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "Buscar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbbusqueda
            // 
            this.tbbusqueda.Location = new System.Drawing.Point(270, 25);
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(489, 20);
            this.tbbusqueda.TabIndex = 1;
            this.tbbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbusqueda_KeyPress);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Items.AddRange(new object[] {
            "IdEstudiante",
            "Nombre",
            "Apellidos",
            "Grado",
            "Direccion",
            "Seccion"});
            this.cboCriterio.Location = new System.Drawing.Point(3, 25);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(261, 21);
            this.cboCriterio.TabIndex = 1;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // lbbusqueda
            // 
            this.lbbusqueda.AutoSize = true;
            this.lbbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbusqueda.Location = new System.Drawing.Point(3, 5);
            this.lbbusqueda.Name = "lbbusqueda";
            this.lbbusqueda.Size = new System.Drawing.Size(157, 16);
            this.lbbusqueda.TabIndex = 0;
            this.lbbusqueda.Text = "Criterio de busqueda ";
            // 
            // cboTabla
            // 
            this.cboTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabla.FormattingEnabled = true;
            this.cboTabla.Items.AddRange(new object[] {
            "Estudiante"});
            this.cboTabla.Location = new System.Drawing.Point(3, 61);
            this.cboTabla.Name = "cboTabla";
            this.cboTabla.Size = new System.Drawing.Size(121, 21);
            this.cboTabla.TabIndex = 1;
            this.cboTabla.Visible = false;
            // 
            // dtgvEstudiante
            // 
            this.dtgvEstudiante.AllowUserToAddRows = false;
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
            this.Direccion,
            this.Seccion});
            this.dtgvEstudiante.Location = new System.Drawing.Point(3, 66);
            this.dtgvEstudiante.Name = "dtgvEstudiante";
            this.dtgvEstudiante.ReadOnly = true;
            this.dtgvEstudiante.Size = new System.Drawing.Size(844, 216);
            this.dtgvEstudiante.TabIndex = 3;
            this.dtgvEstudiante.SelectionChanged += new System.EventHandler(this.dtgvEstudiante_SelectionChanged);
            this.dtgvEstudiante.DoubleClick += new System.EventHandler(this.dtgvEstudiante_DoubleClick);
            // 
            // IdEstudiante
            // 
            this.IdEstudiante.DataPropertyName = "IdEstudiante";
            this.IdEstudiante.Name = "IdEstudiante";
            this.IdEstudiante.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Nacimiento
            // 
            this.Nacimiento.DataPropertyName = "Nacimiento";
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // IdSeccion
            // 
            this.IdSeccion.DataPropertyName = "IdSeccion";
            this.IdSeccion.Name = "IdSeccion";
            this.IdSeccion.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Seccion
            // 
            this.Seccion.DataPropertyName = "Seccion";
            this.Seccion.Name = "Seccion";
            this.Seccion.ReadOnly = true;
            // 
            // btnProgreso
            // 
            this.btnProgreso.Location = new System.Drawing.Point(752, 288);
            this.btnProgreso.Name = "btnProgreso";
            this.btnProgreso.Size = new System.Drawing.Size(95, 24);
            this.btnProgreso.TabIndex = 4;
            this.btnProgreso.Text = "Progreso";
            this.btnProgreso.UseVisualStyleBackColor = true;
            this.btnProgreso.Click += new System.EventHandler(this.btnProgreso_Click);
            // 
            // LEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 314);
            this.Controls.Add(this.btnProgreso);
            this.Controls.Add(this.FLYPrincipal);
            this.Controls.Add(this.dtgvEstudiante);
            this.Name = "LEstudiante";
            this.Text = "LEstudiante";
            this.FLYPrincipal.ResumeLayout(false);
            this.pCriterio.ResumeLayout(false);
            this.pCriterio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiante)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLYPrincipal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pCriterio;
        private System.Windows.Forms.TextBox tbbusqueda;
        private System.Windows.Forms.Label lbbusqueda;
        private System.Windows.Forms.ComboBox cboTabla;
        private System.Windows.Forms.ComboBox cboCriterio;


        private System.Windows.Forms.DataGridView dtgvEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.Button btnProgreso;
    }
}
