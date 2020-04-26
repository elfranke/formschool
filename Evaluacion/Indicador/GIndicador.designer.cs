namespace Evaluacion
{
    partial class GIndicador
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
            this.pGrado = new System.Windows.Forms.Panel();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.lbGrado = new System.Windows.Forms.Label();
            this.pMateria = new System.Windows.Forms.Panel();
            this.lbMateria = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.pIndicador = new System.Windows.Forms.Panel();
            this.tbIndicador = new System.Windows.Forms.TextBox();
            this.lbIndicador = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgvIndicador = new System.Windows.Forms.DataGridView();
            this.IdIndicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.FLYPrincipal.SuspendLayout();
            this.pGrado.SuspendLayout();
            this.pMateria.SuspendLayout();
            this.pIndicador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIndicador)).BeginInit();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pGrado);
            this.FLYPrincipal.Controls.Add(this.pMateria);
            this.FLYPrincipal.Controls.Add(this.pIndicador);
            this.FLYPrincipal.Controls.Add(this.btnGuardar);
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(560, 119);
            this.FLYPrincipal.TabIndex = 0;
            // 
            // pGrado
            // 
            this.pGrado.Controls.Add(this.cboGrado);
            this.pGrado.Controls.Add(this.lbGrado);
            this.pGrado.Location = new System.Drawing.Point(3, 3);
            this.pGrado.Name = "pGrado";
            this.pGrado.Size = new System.Drawing.Size(180, 52);
            this.pGrado.TabIndex = 2;
            // 
            // cboGrado
            // 
            this.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(4, 28);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(173, 21);
            this.cboGrado.TabIndex = 3;
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
            // pMateria
            // 
            this.pMateria.Controls.Add(this.lbMateria);
            this.pMateria.Controls.Add(this.cboMateria);
            this.pMateria.Location = new System.Drawing.Point(189, 3);
            this.pMateria.Name = "pMateria";
            this.pMateria.Size = new System.Drawing.Size(364, 52);
            this.pMateria.TabIndex = 4;
            // 
            // lbMateria
            // 
            this.lbMateria.AutoSize = true;
            this.lbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMateria.Location = new System.Drawing.Point(3, 4);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(60, 16);
            this.lbMateria.TabIndex = 0;
            this.lbMateria.Text = "Materia";
            // 
            // cboMateria
            // 
            this.cboMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(3, 28);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(358, 21);
            this.cboMateria.TabIndex = 2;
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged);
            // 
            // pIndicador
            // 
            this.pIndicador.Controls.Add(this.tbIndicador);
            this.pIndicador.Controls.Add(this.lbIndicador);
            this.pIndicador.Location = new System.Drawing.Point(3, 61);
            this.pIndicador.Name = "pIndicador";
            this.pIndicador.Size = new System.Drawing.Size(366, 49);
            this.pIndicador.TabIndex = 1;
            // 
            // tbIndicador
            // 
            this.tbIndicador.Location = new System.Drawing.Point(3, 23);
            this.tbIndicador.Name = "tbIndicador";
            this.tbIndicador.Size = new System.Drawing.Size(360, 20);
            this.tbIndicador.TabIndex = 1;
            this.tbIndicador.TextChanged += new System.EventHandler(this.tbIndicador_TextChanged);
            // 
            // lbIndicador
            // 
            this.lbIndicador.AutoSize = true;
            this.lbIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndicador.Location = new System.Drawing.Point(3, 4);
            this.lbIndicador.Name = "lbIndicador";
            this.lbIndicador.Size = new System.Drawing.Size(73, 16);
            this.lbIndicador.TabIndex = 0;
            this.lbIndicador.Text = "Indicador";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(375, 61);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 30);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgvIndicador
            // 
            this.dtgvIndicador.AllowUserToAddRows = false;
            this.dtgvIndicador.AllowUserToDeleteRows = false;
            this.dtgvIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvIndicador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIndicador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIndicador,
            this.Indicador,
            this.Grado,
            this.IdMateria,
            this.Materia});
            this.dtgvIndicador.Location = new System.Drawing.Point(2, 125);
            this.dtgvIndicador.Name = "dtgvIndicador";
            this.dtgvIndicador.ReadOnly = true;
            this.dtgvIndicador.Size = new System.Drawing.Size(560, 165);
            this.dtgvIndicador.TabIndex = 3;
            this.dtgvIndicador.SelectionChanged += new System.EventHandler(this.dtgvIndicador_SelectionChanged);
            // 
            // IdIndicador
            // 
            this.IdIndicador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdIndicador.DataPropertyName = "IdIndicador";
            this.IdIndicador.HeaderText = "IdIndicador";
            this.IdIndicador.Name = "IdIndicador";
            this.IdIndicador.ReadOnly = true;
            // 
            // Indicador
            // 
            this.Indicador.DataPropertyName = "Indicador";
            this.Indicador.HeaderText = "Indicador";
            this.Indicador.Name = "Indicador";
            this.Indicador.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // IdMateria
            // 
            this.IdMateria.DataPropertyName = "IdMateria";
            this.IdMateria.HeaderText = "IdMateria";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "Materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(83, 296);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 30);
            this.btnNuevo.TabIndex = 205;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(3, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 30);
            this.btnEditar.TabIndex = 206;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // GIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 333);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.FLYPrincipal);
            this.Controls.Add(this.dtgvIndicador);
            this.Name = "GIndicador";
            this.Text = "GIndicador";
            this.FLYPrincipal.ResumeLayout(false);
            this.FLYPrincipal.PerformLayout();
            this.pGrado.ResumeLayout(false);
            this.pGrado.PerformLayout();
            this.pMateria.ResumeLayout(false);
            this.pMateria.PerformLayout();
            this.pIndicador.ResumeLayout(false);
            this.pIndicador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIndicador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLYPrincipal;
        private System.Windows.Forms.Button btnGuardar;

        private System.Windows.Forms.Panel pIndicador;
        private System.Windows.Forms.TextBox tbIndicador;
        private System.Windows.Forms.Label lbIndicador;

        private System.Windows.Forms.Panel pGrado;
        private System.Windows.Forms.Label lbGrado;

        private System.Windows.Forms.Panel pMateria;
        private System.Windows.Forms.Label lbMateria;

        private System.Windows.Forms.DataGridView dtgvIndicador;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIndicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
    }
}
