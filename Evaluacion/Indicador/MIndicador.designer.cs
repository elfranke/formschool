namespace Evaluacion
{
    partial class MIndicador
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
            this.pIdIndicador = new System.Windows.Forms.Panel();
            this.tbIdIndicador = new System.Windows.Forms.TextBox();
            this.lbIdIndicador = new System.Windows.Forms.Label();
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
            this.FLYPrincipal.SuspendLayout();
            this.pIdIndicador.SuspendLayout();
            this.pGrado.SuspendLayout();
            this.pMateria.SuspendLayout();
            this.pIndicador.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pIdIndicador);
            this.FLYPrincipal.Controls.Add(this.pGrado);
            this.FLYPrincipal.Controls.Add(this.pMateria);
            this.FLYPrincipal.Controls.Add(this.pIndicador);
            this.FLYPrincipal.Controls.Add(this.btnGuardar);
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(467, 264);
            this.FLYPrincipal.TabIndex = 0;
            // 
            // pIdIndicador
            // 
            this.pIdIndicador.Controls.Add(this.tbIdIndicador);
            this.pIdIndicador.Controls.Add(this.lbIdIndicador);
            this.pIdIndicador.Location = new System.Drawing.Point(3, 3);
            this.pIdIndicador.Name = "pIdIndicador";
            this.pIdIndicador.Size = new System.Drawing.Size(457, 52);
            this.pIdIndicador.TabIndex = 0;
            this.pIdIndicador.Visible = false;
            // 
            // tbIdIndicador
            // 
            this.tbIdIndicador.Location = new System.Drawing.Point(3, 23);
            this.tbIdIndicador.Name = "tbIdIndicador";
            this.tbIdIndicador.Size = new System.Drawing.Size(164, 20);
            this.tbIdIndicador.TabIndex = 1;
            this.tbIdIndicador.Text = "0";
            // 
            // lbIdIndicador
            // 
            this.lbIdIndicador.AutoSize = true;
            this.lbIdIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdIndicador.Location = new System.Drawing.Point(3, 4);
            this.lbIdIndicador.Name = "lbIdIndicador";
            this.lbIdIndicador.Size = new System.Drawing.Size(86, 16);
            this.lbIdIndicador.TabIndex = 0;
            this.lbIdIndicador.Text = "IdIndicador";
            // 
            // pGrado
            // 
            this.pGrado.Controls.Add(this.cboGrado);
            this.pGrado.Controls.Add(this.lbGrado);
            this.pGrado.Location = new System.Drawing.Point(3, 61);
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
            this.cboGrado.TabIndex = 2;
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
            this.pMateria.Location = new System.Drawing.Point(189, 61);
            this.pMateria.Name = "pMateria";
            this.pMateria.Size = new System.Drawing.Size(274, 52);
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
            this.cboMateria.Location = new System.Drawing.Point(3, 25);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(265, 21);
            this.cboMateria.TabIndex = 201;
            // 
            // pIndicador
            // 
            this.pIndicador.Controls.Add(this.tbIndicador);
            this.pIndicador.Controls.Add(this.lbIndicador);
            this.pIndicador.Location = new System.Drawing.Point(3, 119);
            this.pIndicador.Name = "pIndicador";
            this.pIndicador.Size = new System.Drawing.Size(460, 101);
            this.pIndicador.TabIndex = 1;
            // 
            // tbIndicador
            // 
            this.tbIndicador.Location = new System.Drawing.Point(3, 23);
            this.tbIndicador.Multiline = true;
            this.tbIndicador.Name = "tbIndicador";
            this.tbIndicador.Size = new System.Drawing.Size(454, 75);
            this.tbIndicador.TabIndex = 1;
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
            this.btnGuardar.Location = new System.Drawing.Point(3, 226);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 30);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // MIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 265);
            this.Controls.Add(this.FLYPrincipal);
            this.Name = "MIndicador";
            this.Text = "MIndicador";
            this.FLYPrincipal.ResumeLayout(false);
            this.FLYPrincipal.PerformLayout();
            this.pIdIndicador.ResumeLayout(false);
            this.pIdIndicador.PerformLayout();
            this.pGrado.ResumeLayout(false);
            this.pGrado.PerformLayout();
            this.pMateria.ResumeLayout(false);
            this.pMateria.PerformLayout();
            this.pIndicador.ResumeLayout(false);
            this.pIndicador.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLYPrincipal;
        private System.Windows.Forms.Button btnGuardar;

        private System.Windows.Forms.Panel pIdIndicador;
        private System.Windows.Forms.TextBox tbIdIndicador;
        private System.Windows.Forms.Label lbIdIndicador;

        private System.Windows.Forms.Panel pIndicador;
        private System.Windows.Forms.TextBox tbIndicador;
        private System.Windows.Forms.Label lbIndicador;

        private System.Windows.Forms.Panel pGrado;
        private System.Windows.Forms.Label lbGrado;

        private System.Windows.Forms.Panel pMateria;
        private System.Windows.Forms.Label lbMateria;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.ComboBox cboMateria;
    }
}
