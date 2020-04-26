namespace Evaluacion.Evaluacion
{
    partial class Individual
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
            this.dtgvEvaluacion = new System.Windows.Forms.DataGridView();
            this.btnSetDescripcion = new System.Windows.Forms.Button();
            this.pIdIndicador = new System.Windows.Forms.Panel();
            this.cboIndicador = new System.Windows.Forms.ComboBox();
            this.lbIdIndicador = new System.Windows.Forms.Label();
            this.pIdMateria = new System.Windows.Forms.Panel();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lbIdMateria = new System.Windows.Forms.Label();
            this.pIdSeccion = new System.Windows.Forms.Panel();
            this.cboSeccion = new System.Windows.Forms.ComboBox();
            this.lbIdSeccion = new System.Windows.Forms.Label();
            this.pGrado = new System.Windows.Forms.Panel();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.lbGrado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboEstudiante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtotal = new System.Windows.Forms.Label();
            this.IdEvaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdIndicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEvaluacion)).BeginInit();
            this.pIdIndicador.SuspendLayout();
            this.pIdMateria.SuspendLayout();
            this.pIdSeccion.SuspendLayout();
            this.pGrado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvEvaluacion
            // 
            this.dtgvEvaluacion.AllowUserToAddRows = false;
            this.dtgvEvaluacion.AllowUserToDeleteRows = false;
            this.dtgvEvaluacion.AllowUserToOrderColumns = true;
            this.dtgvEvaluacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEvaluacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEvaluacion,
            this.IdEstudiante,
            this.IdSeccion,
            this.IdIndicador,
            this.IdMateria,
            this.IdPeriodo,
            this.IdUsuario,
            this.Estudiante,
            this.Indicador,
            this.Materia,
            this.Grado,
            this.Periodo,
            this.Descripcion,
            this.Fecha,
            this.Evaluacion});
            this.dtgvEvaluacion.Location = new System.Drawing.Point(4, 156);
            this.dtgvEvaluacion.Name = "dtgvEvaluacion";
            this.dtgvEvaluacion.ReadOnly = true;
            this.dtgvEvaluacion.Size = new System.Drawing.Size(597, 258);
            this.dtgvEvaluacion.TabIndex = 26;
            // 
            // btnSetDescripcion
            // 
            this.btnSetDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDescripcion.Location = new System.Drawing.Point(531, 78);
            this.btnSetDescripcion.Name = "btnSetDescripcion";
            this.btnSetDescripcion.Size = new System.Drawing.Size(69, 23);
            this.btnSetDescripcion.TabIndex = 23;
            this.btnSetDescripcion.Text = "...";
            this.btnSetDescripcion.UseVisualStyleBackColor = true;
            this.btnSetDescripcion.Click += new System.EventHandler(this.btnSetDescripcion_Click);
            // 
            // pIdIndicador
            // 
            this.pIdIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pIdIndicador.Controls.Add(this.cboIndicador);
            this.pIdIndicador.Controls.Add(this.lbIdIndicador);
            this.pIdIndicador.Location = new System.Drawing.Point(3, 108);
            this.pIdIndicador.Name = "pIdIndicador";
            this.pIdIndicador.Size = new System.Drawing.Size(597, 28);
            this.pIdIndicador.TabIndex = 18;
            // 
            // cboIndicador
            // 
            this.cboIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIndicador.FormattingEnabled = true;
            this.cboIndicador.Location = new System.Drawing.Point(77, 3);
            this.cboIndicador.Name = "cboIndicador";
            this.cboIndicador.Size = new System.Drawing.Size(520, 21);
            this.cboIndicador.TabIndex = 1;
            this.cboIndicador.DropDownClosed += new System.EventHandler(this.cboIndicador_DropDownClosed);
            // 
            // lbIdIndicador
            // 
            this.lbIdIndicador.AutoSize = true;
            this.lbIdIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdIndicador.Location = new System.Drawing.Point(3, 4);
            this.lbIdIndicador.Name = "lbIdIndicador";
            this.lbIdIndicador.Size = new System.Drawing.Size(73, 16);
            this.lbIdIndicador.TabIndex = 0;
            this.lbIdIndicador.Text = "Indicador";
            // 
            // pIdMateria
            // 
            this.pIdMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pIdMateria.Controls.Add(this.cboMateria);
            this.pIdMateria.Controls.Add(this.lbIdMateria);
            this.pIdMateria.Location = new System.Drawing.Point(238, 5);
            this.pIdMateria.Name = "pIdMateria";
            this.pIdMateria.Size = new System.Drawing.Size(363, 27);
            this.pIdMateria.TabIndex = 19;
            // 
            // cboMateria
            // 
            this.cboMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(66, 3);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(297, 21);
            this.cboMateria.TabIndex = 1;
            // 
            // lbIdMateria
            // 
            this.lbIdMateria.AutoSize = true;
            this.lbIdMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdMateria.Location = new System.Drawing.Point(4, 6);
            this.lbIdMateria.Name = "lbIdMateria";
            this.lbIdMateria.Size = new System.Drawing.Size(60, 16);
            this.lbIdMateria.TabIndex = 0;
            this.lbIdMateria.Text = "Materia";
            // 
            // pIdSeccion
            // 
            this.pIdSeccion.Controls.Add(this.cboSeccion);
            this.pIdSeccion.Controls.Add(this.lbIdSeccion);
            this.pIdSeccion.Location = new System.Drawing.Point(3, 37);
            this.pIdSeccion.Name = "pIdSeccion";
            this.pIdSeccion.Size = new System.Drawing.Size(233, 29);
            this.pIdSeccion.TabIndex = 17;
            // 
            // cboSeccion
            // 
            this.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeccion.FormattingEnabled = true;
            this.cboSeccion.Location = new System.Drawing.Point(69, 4);
            this.cboSeccion.Name = "cboSeccion";
            this.cboSeccion.Size = new System.Drawing.Size(160, 21);
            this.cboSeccion.TabIndex = 1;
            this.cboSeccion.DropDownClosed += new System.EventHandler(this.cboSeccion_DropDownClosed);
            // 
            // lbIdSeccion
            // 
            this.lbIdSeccion.AutoSize = true;
            this.lbIdSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdSeccion.Location = new System.Drawing.Point(3, 4);
            this.lbIdSeccion.Name = "lbIdSeccion";
            this.lbIdSeccion.Size = new System.Drawing.Size(64, 16);
            this.lbIdSeccion.TabIndex = 0;
            this.lbIdSeccion.Text = "Seccion";
            // 
            // pGrado
            // 
            this.pGrado.Controls.Add(this.cboGrado);
            this.pGrado.Controls.Add(this.lbGrado);
            this.pGrado.Location = new System.Drawing.Point(3, 5);
            this.pGrado.Name = "pGrado";
            this.pGrado.Size = new System.Drawing.Size(233, 27);
            this.pGrado.TabIndex = 21;
            // 
            // cboGrado
            // 
            this.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(56, 3);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(173, 21);
            this.cboGrado.TabIndex = 1;
            this.cboGrado.DropDownClosed += new System.EventHandler(this.cboGrado_DropDownClosed);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cboEstudiante);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 28);
            this.panel1.TabIndex = 18;
            // 
            // cboEstudiante
            // 
            this.cboEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstudiante.FormattingEnabled = true;
            this.cboEstudiante.Location = new System.Drawing.Point(84, 3);
            this.cboEstudiante.Name = "cboEstudiante";
            this.cboEstudiante.Size = new System.Drawing.Size(432, 21);
            this.cboEstudiante.TabIndex = 1;
            this.cboEstudiante.SelectedIndexChanged += new System.EventHandler(this.cboEstudiante_SelectedIndexChanged);
            this.cboEstudiante.DropDownClosed += new System.EventHandler(this.cboEstudiante_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total:";
            // 
            // tbtotal
            // 
            this.tbtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtotal.AutoSize = true;
            this.tbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.ForeColor = System.Drawing.Color.Blue;
            this.tbtotal.Location = new System.Drawing.Point(517, 430);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(40, 13);
            this.tbtotal.TabIndex = 25;
            this.tbtotal.Text = "Total:";
            // 
            // IdEvaluacion
            // 
            this.IdEvaluacion.DataPropertyName = "IdEvaluacion";
            this.IdEvaluacion.HeaderText = "IdEvaluacion";
            this.IdEvaluacion.Name = "IdEvaluacion";
            this.IdEvaluacion.ReadOnly = true;
            this.IdEvaluacion.Visible = false;
            // 
            // IdEstudiante
            // 
            this.IdEstudiante.DataPropertyName = "IdEstudiante";
            this.IdEstudiante.HeaderText = "IdEstudiante";
            this.IdEstudiante.Name = "IdEstudiante";
            this.IdEstudiante.ReadOnly = true;
            this.IdEstudiante.Visible = false;
            // 
            // IdSeccion
            // 
            this.IdSeccion.DataPropertyName = "IdSeccion";
            this.IdSeccion.HeaderText = "IdSeccion";
            this.IdSeccion.Name = "IdSeccion";
            this.IdSeccion.ReadOnly = true;
            this.IdSeccion.Visible = false;
            // 
            // IdIndicador
            // 
            this.IdIndicador.DataPropertyName = "IdIndicador";
            this.IdIndicador.HeaderText = "IdIndicador";
            this.IdIndicador.Name = "IdIndicador";
            this.IdIndicador.ReadOnly = true;
            this.IdIndicador.Visible = false;
            // 
            // IdMateria
            // 
            this.IdMateria.DataPropertyName = "IdMateria";
            this.IdMateria.HeaderText = "IdMateria";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            this.IdMateria.Visible = false;
            // 
            // IdPeriodo
            // 
            this.IdPeriodo.DataPropertyName = "IdPeriodo";
            this.IdPeriodo.HeaderText = "IdPeriodo";
            this.IdPeriodo.Name = "IdPeriodo";
            this.IdPeriodo.ReadOnly = true;
            this.IdPeriodo.Visible = false;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // Estudiante
            // 
            this.Estudiante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estudiante.DataPropertyName = "Estudiante";
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            // 
            // Indicador
            // 
            this.Indicador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indicador.DataPropertyName = "Indicador";
            this.Indicador.HeaderText = "Indicador";
            this.Indicador.Name = "Indicador";
            this.Indicador.ReadOnly = true;
            this.Indicador.Visible = false;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "Materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Visible = false;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            this.Grado.Visible = false;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Evaluacion
            // 
            this.Evaluacion.DataPropertyName = "Evaluacion";
            this.Evaluacion.HeaderText = "Evaluacion";
            this.Evaluacion.Name = "Evaluacion";
            this.Evaluacion.ReadOnly = true;
            // 
            // Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 448);
            this.Controls.Add(this.dtgvEvaluacion);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetDescripcion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pIdIndicador);
            this.Controls.Add(this.pIdMateria);
            this.Controls.Add(this.pIdSeccion);
            this.Controls.Add(this.pGrado);
            this.Name = "Individual";
            this.Text = "Individual";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEvaluacion)).EndInit();
            this.pIdIndicador.ResumeLayout(false);
            this.pIdIndicador.PerformLayout();
            this.pIdMateria.ResumeLayout(false);
            this.pIdMateria.PerformLayout();
            this.pIdSeccion.ResumeLayout(false);
            this.pIdSeccion.PerformLayout();
            this.pGrado.ResumeLayout(false);
            this.pGrado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSetDescripcion;
        private System.Windows.Forms.Panel pIdIndicador;
        private System.Windows.Forms.ComboBox cboIndicador;
        private System.Windows.Forms.Label lbIdIndicador;
        private System.Windows.Forms.Panel pIdMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lbIdMateria;
        private System.Windows.Forms.Panel pIdSeccion;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.Label lbIdSeccion;
        private System.Windows.Forms.Panel pGrado;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.Label lbGrado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tbtotal;
        private System.Windows.Forms.DataGridView dtgvEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIndicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion;
    }
}