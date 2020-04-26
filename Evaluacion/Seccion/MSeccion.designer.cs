namespace Evaluacion
{
    partial class MSeccion
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
            this.pIdSeccion = new System.Windows.Forms.Panel();
            this.tbIdSeccion = new System.Windows.Forms.TextBox();
            this.lbIdSeccion = new System.Windows.Forms.Label();
            this.pSeccion = new System.Windows.Forms.Panel();
            this.tbSeccion = new System.Windows.Forms.TextBox();
            this.lbSeccion = new System.Windows.Forms.Label();
            this.pGrado = new System.Windows.Forms.Panel();
            this.lbGrado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbgrado = new System.Windows.Forms.TextBox();
            this.FLYPrincipal.SuspendLayout();
            this.pIdSeccion.SuspendLayout();
            this.pSeccion.SuspendLayout();
            this.pGrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pIdSeccion);
            this.FLYPrincipal.Controls.Add(this.pSeccion);
            this.FLYPrincipal.Controls.Add(this.pGrado);
            this.FLYPrincipal.Controls.Add(this.btnGuardar);
            this.FLYPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(384, 123);
            this.FLYPrincipal.TabIndex = 0;
            // 
            // pIdSeccion
            // 
            this.pIdSeccion.Controls.Add(this.tbIdSeccion);
            this.pIdSeccion.Controls.Add(this.lbIdSeccion);
            this.pIdSeccion.Location = new System.Drawing.Point(3, 3);
            this.pIdSeccion.Name = "pIdSeccion";
            this.pIdSeccion.Size = new System.Drawing.Size(180, 52);
            this.pIdSeccion.TabIndex = 0;
            this.pIdSeccion.Visible = false;
            // 
            // tbIdSeccion
            // 
            this.tbIdSeccion.Location = new System.Drawing.Point(3, 23);
            this.tbIdSeccion.Name = "tbIdSeccion";
            this.tbIdSeccion.Size = new System.Drawing.Size(164, 20);
            this.tbIdSeccion.TabIndex = 1;
            this.tbIdSeccion.Text = "0";
            // 
            // lbIdSeccion
            // 
            this.lbIdSeccion.AutoSize = true;
            this.lbIdSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdSeccion.Location = new System.Drawing.Point(3, 4);
            this.lbIdSeccion.Name = "lbIdSeccion";
            this.lbIdSeccion.Size = new System.Drawing.Size(77, 16);
            this.lbIdSeccion.TabIndex = 0;
            this.lbIdSeccion.Text = "IdSeccion";
            // 
            // pSeccion
            // 
            this.pSeccion.Controls.Add(this.tbSeccion);
            this.pSeccion.Controls.Add(this.lbSeccion);
            this.pSeccion.Location = new System.Drawing.Point(189, 3);
            this.pSeccion.Name = "pSeccion";
            this.pSeccion.Size = new System.Drawing.Size(180, 52);
            this.pSeccion.TabIndex = 1;
            // 
            // tbSeccion
            // 
            this.tbSeccion.Location = new System.Drawing.Point(3, 23);
            this.tbSeccion.Name = "tbSeccion";
            this.tbSeccion.Size = new System.Drawing.Size(164, 20);
            this.tbSeccion.TabIndex = 1;
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
            this.pGrado.Controls.Add(this.tbgrado);
            this.pGrado.Controls.Add(this.lbGrado);
            this.pGrado.Location = new System.Drawing.Point(3, 61);
            this.pGrado.Name = "pGrado";
            this.pGrado.Size = new System.Drawing.Size(180, 52);
            this.pGrado.TabIndex = 2;
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
            this.btnGuardar.Location = new System.Drawing.Point(189, 61);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 30);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbgrado
            // 
            this.tbgrado.Location = new System.Drawing.Point(3, 29);
            this.tbgrado.Name = "tbgrado";
            this.tbgrado.Size = new System.Drawing.Size(164, 20);
            this.tbgrado.TabIndex = 1;
            // 
            // MSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 123);
            this.Controls.Add(this.FLYPrincipal);
            this.Name = "MSeccion";
            this.Text = "MSeccion";
            this.FLYPrincipal.ResumeLayout(false);
            this.FLYPrincipal.PerformLayout();
            this.pIdSeccion.ResumeLayout(false);
            this.pIdSeccion.PerformLayout();
            this.pSeccion.ResumeLayout(false);
            this.pSeccion.PerformLayout();
            this.pGrado.ResumeLayout(false);
            this.pGrado.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLYPrincipal;
        private System.Windows.Forms.Button btnGuardar;

        private System.Windows.Forms.Panel pIdSeccion;
        private System.Windows.Forms.TextBox tbIdSeccion;
        private System.Windows.Forms.Label lbIdSeccion;

        private System.Windows.Forms.Panel pSeccion;
        private System.Windows.Forms.TextBox tbSeccion;
        private System.Windows.Forms.Label lbSeccion;

        private System.Windows.Forms.Panel pGrado;
        private System.Windows.Forms.Label lbGrado;
        private System.Windows.Forms.TextBox tbgrado;
    }
}
