namespace Evaluacion
{
    partial class GMateria
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
            this.tbMateria = new System.Windows.Forms.TextBox();
            this.lbMateria = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgvMateria = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLYPrincipal.SuspendLayout();
            this.pGrado.SuspendLayout();
            this.pMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pGrado);
            this.FLYPrincipal.Controls.Add(this.pMateria);
            this.FLYPrincipal.Controls.Add(this.btnGuardar);
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(467, 64);
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
            // pMateria
            // 
            this.pMateria.Controls.Add(this.tbMateria);
            this.pMateria.Controls.Add(this.lbMateria);
            this.pMateria.Location = new System.Drawing.Point(189, 3);
            this.pMateria.Name = "pMateria";
            this.pMateria.Size = new System.Drawing.Size(195, 52);
            this.pMateria.TabIndex = 1;
            // 
            // tbMateria
            // 
            this.tbMateria.Location = new System.Drawing.Point(3, 25);
            this.tbMateria.Name = "tbMateria";
            this.tbMateria.Size = new System.Drawing.Size(189, 20);
            this.tbMateria.TabIndex = 1;
            this.tbMateria.Tag = "Materia";
            this.tbMateria.TextChanged += new System.EventHandler(this.tbMateria_TextChanged);
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
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(390, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 30);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "buscar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgvMateria
            // 
            this.dtgvMateria.AllowUserToAddRows = false;
            this.dtgvMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMateria,
            this.Materia,
            this.Grado,
            this.IdUsuario});
            this.dtgvMateria.Location = new System.Drawing.Point(1, 69);
            this.dtgvMateria.Name = "dtgvMateria";
            this.dtgvMateria.ReadOnly = true;
            this.dtgvMateria.Size = new System.Drawing.Size(464, 181);
            this.dtgvMateria.TabIndex = 3;
            this.dtgvMateria.SelectionChanged += new System.EventHandler(this.dtgvMateria_SelectionChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(81, 256);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 30);
            this.btnNuevo.TabIndex = 203;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1, 256);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 30);
            this.btnEditar.TabIndex = 204;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Materia.DataPropertyName = "Materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // GMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 292);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.FLYPrincipal);
            this.Controls.Add(this.dtgvMateria);
            this.Name = "GMateria";
            this.Text = "GMateria";
            this.FLYPrincipal.ResumeLayout(false);
            this.FLYPrincipal.PerformLayout();
            this.pGrado.ResumeLayout(false);
            this.pGrado.PerformLayout();
            this.pMateria.ResumeLayout(false);
            this.pMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLYPrincipal;
        private System.Windows.Forms.Button btnGuardar;

        private System.Windows.Forms.Panel pMateria;
        private System.Windows.Forms.TextBox tbMateria;
        private System.Windows.Forms.Label lbMateria;

        private System.Windows.Forms.Panel pGrado;
        private System.Windows.Forms.Label lbGrado;

        private System.Windows.Forms.DataGridView dtgvMateria;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
    }
}
