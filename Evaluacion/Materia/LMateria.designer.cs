namespace Evaluacion
{
    partial class LMateria
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
            this.tbbusqueda = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lbbusqueda = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboTabla = new System.Windows.Forms.ComboBox();
            this.dtgvMateria = new System.Windows.Forms.DataGridView();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLYPrincipal.SuspendLayout();
            this.pCriterio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pCriterio);
            this.FLYPrincipal.Controls.Add(this.cboTabla);
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(467, 58);
            this.FLYPrincipal.TabIndex = 0;
            // 
            // pCriterio
            // 
            this.pCriterio.Controls.Add(this.tbbusqueda);
            this.pCriterio.Controls.Add(this.cboCriterio);
            this.pCriterio.Controls.Add(this.lbbusqueda);
            this.pCriterio.Controls.Add(this.btnGuardar);
            this.pCriterio.Location = new System.Drawing.Point(3, 3);
            this.pCriterio.Name = "pCriterio";
            this.pCriterio.Size = new System.Drawing.Size(464, 52);
            this.pCriterio.TabIndex = 1;
            // 
            // tbbusqueda
            // 
            this.tbbusqueda.Location = new System.Drawing.Point(144, 24);
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(223, 20);
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
            "IdMateria",
            "Materia",
            "Grado",
            "IdUsuario"});
            this.cboCriterio.Location = new System.Drawing.Point(3, 23);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(135, 21);
            this.cboCriterio.TabIndex = 1;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // lbbusqueda
            // 
            this.lbbusqueda.AutoSize = true;
            this.lbbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbusqueda.Location = new System.Drawing.Point(3, 4);
            this.lbbusqueda.Name = "lbbusqueda";
            this.lbbusqueda.Size = new System.Drawing.Size(157, 16);
            this.lbbusqueda.TabIndex = 0;
            this.lbbusqueda.Text = "Criterio de busqueda ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(373, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 30);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "buscar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboTabla
            // 
            this.cboTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabla.FormattingEnabled = true;
            this.cboTabla.Items.AddRange(new object[] {
            "Materia"});
            this.cboTabla.Location = new System.Drawing.Point(3, 61);
            this.cboTabla.Name = "cboTabla";
            this.cboTabla.Size = new System.Drawing.Size(121, 21);
            this.cboTabla.TabIndex = 1;
            this.cboTabla.Visible = false;
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
            this.dtgvMateria.Location = new System.Drawing.Point(1, 64);
            this.dtgvMateria.Name = "dtgvMateria";
            this.dtgvMateria.ReadOnly = true;
            this.dtgvMateria.Size = new System.Drawing.Size(464, 205);
            this.dtgvMateria.TabIndex = 3;
            this.dtgvMateria.DoubleClick += new System.EventHandler(this.dtgvMateria_DoubleClick);
            // 
            // IdMateria
            // 
            this.IdMateria.DataPropertyName = "IdMateria";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // LMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 274);
            this.Controls.Add(this.FLYPrincipal);
            this.Controls.Add(this.dtgvMateria);
            this.Name = "LMateria";
            this.Text = "LMateria";
            this.FLYPrincipal.ResumeLayout(false);
            this.pCriterio.ResumeLayout(false);
            this.pCriterio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMateria)).EndInit();
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


        private System.Windows.Forms.DataGridView dtgvMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;


    }
}
