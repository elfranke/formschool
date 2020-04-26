namespace Evaluacion
{
partial class MLogin
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
            this.pUsuario = new System.Windows.Forms.Panel();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.pContrasena = new System.Windows.Forms.Panel();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.lbContrasena = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pUsuario.SuspendLayout();
            this.pContrasena.SuspendLayout();
            this.SuspendLayout();
            // 
            // pUsuario
            // 
            this.pUsuario.Controls.Add(this.tbUsuario);
            this.pUsuario.Controls.Add(this.lbUsuario);
            this.pUsuario.Location = new System.Drawing.Point(12, 58);
            this.pUsuario.Name = "pUsuario";
            this.pUsuario.Size = new System.Drawing.Size(193, 52);
            this.pUsuario.TabIndex = 0;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(3, 23);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(187, 20);
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
            // pContrasena
            // 
            this.pContrasena.Controls.Add(this.tbContrasena);
            this.pContrasena.Controls.Add(this.lbContrasena);
            this.pContrasena.Location = new System.Drawing.Point(12, 117);
            this.pContrasena.Name = "pContrasena";
            this.pContrasena.Size = new System.Drawing.Size(193, 52);
            this.pContrasena.TabIndex = 1;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(3, 23);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '8';
            this.tbContrasena.Size = new System.Drawing.Size(187, 20);
            this.tbContrasena.TabIndex = 1;
            this.tbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContrasena_KeyPress);
            // 
            // lbContrasena
            // 
            this.lbContrasena.AutoSize = true;
            this.lbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasena.Location = new System.Drawing.Point(3, 4);
            this.lbContrasena.Name = "lbContrasena";
            this.lbContrasena.Size = new System.Drawing.Size(87, 16);
            this.lbContrasena.TabIndex = 0;
            this.lbContrasena.Text = "Contrasena";
            // 
            // btnAcceder
            // 
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Location = new System.Drawing.Point(12, 180);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(190, 39);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio de Seccion";
            // 
            // MLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.pUsuario);
            this.Controls.Add(this.pContrasena);
            this.Name = "MLogin";
            this.Text = "MLogin";
            this.pUsuario.ResumeLayout(false);
            this.pUsuario.PerformLayout();
            this.pContrasena.ResumeLayout(false);
            this.pContrasena.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

}
#endregion

private System.Windows.Forms.Panel pUsuario;
private System.Windows.Forms.TextBox tbUsuario;
private System.Windows.Forms.Label lbUsuario;

private System.Windows.Forms.Panel pContrasena;
private System.Windows.Forms.TextBox tbContrasena;
private System.Windows.Forms.Label lbContrasena;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label1;
    }
}
