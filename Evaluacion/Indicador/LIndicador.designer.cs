namespace Evaluacion
{
    partial class LIndicador
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
            this.lbbusqueda = new System.Windows.Forms.Label();
            this.tbbusqueda = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboTabla = new System.Windows.Forms.ComboBox();
            this.dtgvIndicador = new System.Windows.Forms.DataGridView();
            this.IdIndicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLYPrincipal.SuspendLayout();
            this.pCriterio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIndicador)).BeginInit();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pCriterio);
            this.FLYPrincipal.Controls.Add(this.cboTabla);
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(544, 59);
            this.FLYPrincipal.TabIndex = 0;
            // 
            // pCriterio
            // 
            this.pCriterio.Controls.Add(this.btnGuardar);
            this.pCriterio.Controls.Add(this.lbbusqueda);
            this.pCriterio.Controls.Add(this.tbbusqueda);
            this.pCriterio.Controls.Add(this.cboCriterio);
            this.pCriterio.Location = new System.Drawing.Point(3, 3);
            this.pCriterio.Name = "pCriterio";
            this.pCriterio.Size = new System.Drawing.Size(541, 52);
            this.pCriterio.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(453, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 30);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "buscar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // tbbusqueda
            // 
            this.tbbusqueda.Location = new System.Drawing.Point(155, 24);
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(292, 20);
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
            "IdIndicador",
            "Indicador",
            "Grado",
            "IdMateria",
            "Materia"});
            this.cboCriterio.Location = new System.Drawing.Point(3, 23);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(146, 21);
            this.cboCriterio.TabIndex = 1;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // cboTabla
            // 
            this.cboTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabla.FormattingEnabled = true;
            this.cboTabla.Items.AddRange(new object[] {
            "Indicador"});
            this.cboTabla.Location = new System.Drawing.Point(3, 61);
            this.cboTabla.Name = "cboTabla";
            this.cboTabla.Size = new System.Drawing.Size(121, 21);
            this.cboTabla.TabIndex = 1;
            this.cboTabla.Visible = false;
            // 
            // dtgvIndicador
            // 
            this.dtgvIndicador.AllowUserToAddRows = false;
            this.dtgvIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvIndicador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIndicador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIndicador,
            this.Indicador,
            this.Grado,
            this.IdMateria,
            this.Materia});
            this.dtgvIndicador.Location = new System.Drawing.Point(0, 65);
            this.dtgvIndicador.Name = "dtgvIndicador";
            this.dtgvIndicador.ReadOnly = true;
            this.dtgvIndicador.Size = new System.Drawing.Size(544, 245);
            this.dtgvIndicador.TabIndex = 3;
            this.dtgvIndicador.DoubleClick += new System.EventHandler(this.dtgvIndicador_DoubleClick);
            // 
            // IdIndicador
            // 
            this.IdIndicador.DataPropertyName = "IdIndicador";
            this.IdIndicador.Name = "IdIndicador";
            this.IdIndicador.ReadOnly = true;
            // 
            // Indicador
            // 
            this.Indicador.DataPropertyName = "Indicador";
            this.Indicador.Name = "Indicador";
            this.Indicador.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
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
            // LIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 313);
            this.Controls.Add(this.FLYPrincipal);
            this.Controls.Add(this.dtgvIndicador);
            this.Name = "LIndicador";
            this.Text = "LIndicador";
            this.FLYPrincipal.ResumeLayout(false);
            this.pCriterio.ResumeLayout(false);
            this.pCriterio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIndicador)).EndInit();
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


        private System.Windows.Forms.DataGridView dtgvIndicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIndicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;


    }
}
