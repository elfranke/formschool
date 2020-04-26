namespace Evaluacion
{
    partial class GSeccion
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
            this.pSeccion = new System.Windows.Forms.Panel();
            this.tbSeccion = new System.Windows.Forms.TextBox();
            this.lbSeccion = new System.Windows.Forms.Label();
            this.pGrado = new System.Windows.Forms.Panel();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.lbGrado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgvSeccion = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.IdSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLYPrincipal.SuspendLayout();
            this.pSeccion.SuspendLayout();
            this.pGrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pSeccion);
            this.FLYPrincipal.Controls.Add(this.pGrado);
            this.FLYPrincipal.Controls.Add(this.btnGuardar);
            this.FLYPrincipal.Controls.Add(this.btnLimpiar);
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(467, 101);
            this.FLYPrincipal.TabIndex = 0;
            // 
            // pSeccion
            // 
            this.pSeccion.Controls.Add(this.tbSeccion);
            this.pSeccion.Controls.Add(this.lbSeccion);
            this.pSeccion.Location = new System.Drawing.Point(3, 3);
            this.pSeccion.Name = "pSeccion";
            this.pSeccion.Size = new System.Drawing.Size(217, 52);
            this.pSeccion.TabIndex = 1;
            // 
            // tbSeccion
            // 
            this.tbSeccion.Location = new System.Drawing.Point(3, 23);
            this.tbSeccion.Name = "tbSeccion";
            this.tbSeccion.Size = new System.Drawing.Size(204, 20);
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
            // pGrado
            // 
            this.pGrado.Controls.Add(this.cboGrado);
            this.pGrado.Controls.Add(this.lbGrado);
            this.pGrado.Location = new System.Drawing.Point(226, 3);
            this.pGrado.Name = "pGrado";
            this.pGrado.Size = new System.Drawing.Size(229, 52);
            this.pGrado.TabIndex = 2;
            // 
            // cboGrado
            // 
            this.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(3, 25);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(223, 21);
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
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(3, 61);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "Buscar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgvSeccion
            // 
            this.dtgvSeccion.AllowUserToAddRows = false;
            this.dtgvSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSeccion,
            this.Seccion,
            this.Grado});
            this.dtgvSeccion.Location = new System.Drawing.Point(2, 109);
            this.dtgvSeccion.Name = "dtgvSeccion";
            this.dtgvSeccion.ReadOnly = true;
            this.dtgvSeccion.Size = new System.Drawing.Size(464, 233);
            this.dtgvSeccion.TabIndex = 3;
            this.dtgvSeccion.SelectionChanged += new System.EventHandler(this.dtgvSeccion_SelectionChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(83, 350);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 30);
            this.btnNuevo.TabIndex = 201;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(2, 350);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 30);
            this.btnEditar.TabIndex = 202;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(84, 61);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 30);
            this.btnLimpiar.TabIndex = 201;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // IdSeccion
            // 
            this.IdSeccion.DataPropertyName = "IdSeccion";
            this.IdSeccion.HeaderText = "IdSeccion";
            this.IdSeccion.Name = "IdSeccion";
            this.IdSeccion.ReadOnly = true;
            // 
            // Seccion
            // 
            this.Seccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seccion.DataPropertyName = "Seccion";
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
            this.Seccion.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // GSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 386);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.FLYPrincipal);
            this.Controls.Add(this.dtgvSeccion);
            this.Name = "GSeccion";
            this.Text = "GSeccion";
            this.FLYPrincipal.ResumeLayout(false);
            this.FLYPrincipal.PerformLayout();
            this.pSeccion.ResumeLayout(false);
            this.pSeccion.PerformLayout();
            this.pGrado.ResumeLayout(false);
            this.pGrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLYPrincipal;
        private System.Windows.Forms.Button btnGuardar;

        private System.Windows.Forms.Panel pSeccion;
        private System.Windows.Forms.TextBox tbSeccion;
        private System.Windows.Forms.Label lbSeccion;

        private System.Windows.Forms.Panel pGrado;
        private System.Windows.Forms.Label lbGrado;

        private System.Windows.Forms.DataGridView dtgvSeccion;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
    }
}
