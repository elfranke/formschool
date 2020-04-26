namespace Evaluacion
{
    partial class MUsuario
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pIdUsuario = new System.Windows.Forms.Panel();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.lbIdUsuario = new System.Windows.Forms.Label();
            this.pUsuario = new System.Windows.Forms.Panel();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.pNombre = new System.Windows.Forms.Panel();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pPass = new System.Windows.Forms.Panel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.pActivo = new System.Windows.Forms.Panel();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lbActivo = new System.Windows.Forms.Label();
            this.tbIdEmpresa = new System.Windows.Forms.TextBox();
            this.pIdUsuario.SuspendLayout();
            this.pUsuario.SuspendLayout();
            this.pNombre.SuspendLayout();
            this.pPass.SuspendLayout();
            this.pActivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(3, 176);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(452, 39);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pIdUsuario
            // 
            this.pIdUsuario.Controls.Add(this.tbIdUsuario);
            this.pIdUsuario.Controls.Add(this.lbIdUsuario);
            this.pIdUsuario.Location = new System.Drawing.Point(111, 2);
            this.pIdUsuario.Name = "pIdUsuario";
            this.pIdUsuario.Size = new System.Drawing.Size(344, 52);
            this.pIdUsuario.TabIndex = 0;
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Enabled = false;
            this.tbIdUsuario.Location = new System.Drawing.Point(3, 23);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(338, 20);
            this.tbIdUsuario.TabIndex = 1;
            this.tbIdUsuario.Text = "0";
            // 
            // lbIdUsuario
            // 
            this.lbIdUsuario.AutoSize = true;
            this.lbIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdUsuario.Location = new System.Drawing.Point(3, 4);
            this.lbIdUsuario.Name = "lbIdUsuario";
            this.lbIdUsuario.Size = new System.Drawing.Size(75, 16);
            this.lbIdUsuario.TabIndex = 0;
            this.lbIdUsuario.Text = "IdUsuario";
            // 
            // pUsuario
            // 
            this.pUsuario.Controls.Add(this.tbUsuario);
            this.pUsuario.Controls.Add(this.lbUsuario);
            this.pUsuario.Location = new System.Drawing.Point(3, 60);
            this.pUsuario.Name = "pUsuario";
            this.pUsuario.Size = new System.Drawing.Size(452, 52);
            this.pUsuario.TabIndex = 1;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(3, 23);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(446, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(3, 4);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(62, 16);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            // 
            // pNombre
            // 
            this.pNombre.Controls.Add(this.tbNombre);
            this.pNombre.Controls.Add(this.lbNombre);
            this.pNombre.Location = new System.Drawing.Point(3, 118);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(216, 52);
            this.pNombre.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(3, 23);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(210, 20);
            this.tbNombre.TabIndex = 1;
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
            // pPass
            // 
            this.pPass.Controls.Add(this.tbPass);
            this.pPass.Controls.Add(this.lbPass);
            this.pPass.Location = new System.Drawing.Point(222, 118);
            this.pPass.Name = "pPass";
            this.pPass.Size = new System.Drawing.Size(233, 52);
            this.pPass.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(3, 23);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(227, 20);
            this.tbPass.TabIndex = 1;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(3, 4);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(43, 16);
            this.lbPass.TabIndex = 0;
            this.lbPass.Text = "Pass";
            // 
            // pActivo
            // 
            this.pActivo.Controls.Add(this.chkActivo);
            this.pActivo.Controls.Add(this.lbActivo);
            this.pActivo.Location = new System.Drawing.Point(3, 2);
            this.pActivo.Name = "pActivo";
            this.pActivo.Size = new System.Drawing.Size(102, 52);
            this.pActivo.TabIndex = 4;
            // 
            // chkActivo
            // 
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(3, 23);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(85, 24);
            this.chkActivo.TabIndex = 1;
            // 
            // lbActivo
            // 
            this.lbActivo.AutoSize = true;
            this.lbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivo.Location = new System.Drawing.Point(3, 4);
            this.lbActivo.Name = "lbActivo";
            this.lbActivo.Size = new System.Drawing.Size(51, 16);
            this.lbActivo.TabIndex = 0;
            this.lbActivo.Text = "Activo";
            // 
            // tbIdEmpresa
            // 
            this.tbIdEmpresa.Location = new System.Drawing.Point(3, 176);
            this.tbIdEmpresa.Name = "tbIdEmpresa";
            this.tbIdEmpresa.Size = new System.Drawing.Size(210, 20);
            this.tbIdEmpresa.TabIndex = 201;
            this.tbIdEmpresa.Text = "1";
            this.tbIdEmpresa.Visible = false;
            // 
            // MUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 222);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbIdEmpresa);
            this.Controls.Add(this.pPass);
            this.Controls.Add(this.pNombre);
            this.Controls.Add(this.pUsuario);
            this.Controls.Add(this.pIdUsuario);
            this.Controls.Add(this.pActivo);
            this.Name = "MUsuario";
            this.Text = "MUsuario";
            this.pIdUsuario.ResumeLayout(false);
            this.pIdUsuario.PerformLayout();
            this.pUsuario.ResumeLayout(false);
            this.pUsuario.PerformLayout();
            this.pNombre.ResumeLayout(false);
            this.pNombre.PerformLayout();
            this.pPass.ResumeLayout(false);
            this.pPass.PerformLayout();
            this.pActivo.ResumeLayout(false);
            this.pActivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button btnGuardar;

        private System.Windows.Forms.Panel pIdUsuario;
        private System.Windows.Forms.TextBox tbIdUsuario;
        private System.Windows.Forms.Label lbIdUsuario;

        private System.Windows.Forms.Panel pUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbUsuario;

        private System.Windows.Forms.Panel pNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;

        private System.Windows.Forms.Panel pPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbPass;

        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lbActivo;
        private System.Windows.Forms.Panel pActivo;
        private System.Windows.Forms.TextBox tbIdEmpresa;
    }
}
