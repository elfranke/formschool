namespace Evaluacion
{
partial class MMateria
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pIdMateria = new System.Windows.Forms.Panel();
            this.tbIdMateria = new System.Windows.Forms.TextBox();
            this.lbIdMateria = new System.Windows.Forms.Label();
            this.pMateria = new System.Windows.Forms.Panel();
            this.tbMateria = new System.Windows.Forms.TextBox();
            this.lbMateria = new System.Windows.Forms.Label();
            this.pGrado = new System.Windows.Forms.Panel();
            this.lbGrado = new System.Windows.Forms.Label();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.FLYPrincipal.SuspendLayout();
            this.pIdMateria.SuspendLayout();
            this.pMateria.SuspendLayout();
            this.pGrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLYPrincipal
            // 
            this.FLYPrincipal.Controls.Add(this.pIdMateria);
            this.FLYPrincipal.Controls.Add(this.pMateria);
            this.FLYPrincipal.Controls.Add(this.pGrado);
            this.FLYPrincipal.Controls.Add(this.btnGuardar);
            this.FLYPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);
            this.FLYPrincipal.Name = "FLYPrincipal";
            this.FLYPrincipal.Size = new System.Drawing.Size(273, 193);
            this.FLYPrincipal.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(182, 119);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 30);
            this.btnGuardar.TabIndex = 200;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pIdMateria
            // 
            this.pIdMateria.Controls.Add(this.tbIdMateria);
            this.pIdMateria.Controls.Add(this.lbIdMateria);
            this.pIdMateria.Location = new System.Drawing.Point(3, 3);
            this.pIdMateria.Name = "pIdMateria";
            this.pIdMateria.Size = new System.Drawing.Size(173, 52);
            this.pIdMateria.TabIndex = 0;
            this.pIdMateria.Visible = false;
            // 
            // tbIdMateria
            // 
            this.tbIdMateria.Location = new System.Drawing.Point(3, 23);
            this.tbIdMateria.Name = "tbIdMateria";
            this.tbIdMateria.Size = new System.Drawing.Size(164, 20);
            this.tbIdMateria.TabIndex = 1;
            this.tbIdMateria.Text = "0";
            // 
            // lbIdMateria
            // 
            this.lbIdMateria.AutoSize = true;
            this.lbIdMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdMateria.Location = new System.Drawing.Point(3, 4);
            this.lbIdMateria.Name = "lbIdMateria";
            this.lbIdMateria.Size = new System.Drawing.Size(73, 16);
            this.lbIdMateria.TabIndex = 0;
            this.lbIdMateria.Text = "IdMateria";
            // 
            // pMateria
            // 
            this.pMateria.Controls.Add(this.tbMateria);
            this.pMateria.Controls.Add(this.lbMateria);
            this.pMateria.Location = new System.Drawing.Point(3, 61);
            this.pMateria.Name = "pMateria";
            this.pMateria.Size = new System.Drawing.Size(266, 52);
            this.pMateria.TabIndex = 1;
            // 
            // tbMateria
            // 
            this.tbMateria.Location = new System.Drawing.Point(3, 23);
            this.tbMateria.Name = "tbMateria";
            this.tbMateria.Size = new System.Drawing.Size(260, 20);
            this.tbMateria.TabIndex = 1;
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
            // pGrado
            // 
            this.pGrado.Controls.Add(this.cboGrado);
            this.pGrado.Controls.Add(this.lbGrado);
            this.pGrado.Location = new System.Drawing.Point(3, 119);
            this.pGrado.Name = "pGrado";
            this.pGrado.Size = new System.Drawing.Size(173, 52);
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
            // cboGrado
            // 
            this.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(4, 24);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(163, 21);
            this.cboGrado.TabIndex = 3;
            // 
            // MMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 193);
            this.Controls.Add(this.FLYPrincipal);
            this.Name = "MMateria";
            this.Text = "MMateria";
            this.FLYPrincipal.ResumeLayout(false);
            this.FLYPrincipal.PerformLayout();
            this.pIdMateria.ResumeLayout(false);
            this.pIdMateria.PerformLayout();
            this.pMateria.ResumeLayout(false);
            this.pMateria.PerformLayout();
            this.pGrado.ResumeLayout(false);
            this.pGrado.PerformLayout();
            this.ResumeLayout(false);

}
#endregion
private System.Windows.Forms.FlowLayoutPanel FLYPrincipal;
private System.Windows.Forms.Button btnGuardar;

private System.Windows.Forms.Panel pIdMateria;
private System.Windows.Forms.TextBox tbIdMateria;
private System.Windows.Forms.Label lbIdMateria;

private System.Windows.Forms.Panel pMateria;
private System.Windows.Forms.TextBox tbMateria;
private System.Windows.Forms.Label lbMateria;

private System.Windows.Forms.Panel pGrado;
private System.Windows.Forms.Label lbGrado;
        private System.Windows.Forms.ComboBox cboGrado;
    }
}
