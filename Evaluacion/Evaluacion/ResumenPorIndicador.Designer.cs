namespace Evaluacion
{
    partial class ResumenPorIndicador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.pnGrupo = new System.Windows.Forms.Panel();
            this.lbestudiante = new System.Windows.Forms.Label();
            this.lbgrado = new System.Windows.Forms.Label();
            this.flpMateria = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnGrupo
            // 
            this.pnGrupo.AutoScroll = true;
            this.pnGrupo.Location = new System.Drawing.Point(70, 49);
            this.pnGrupo.Name = "pnGrupo";
            this.pnGrupo.Size = new System.Drawing.Size(848, 20);
            this.pnGrupo.TabIndex = 0;
            this.pnGrupo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGrupo_Paint);
            // 
            // lbestudiante
            // 
            this.lbestudiante.AutoSize = true;
            this.lbestudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestudiante.Location = new System.Drawing.Point(5, 13);
            this.lbestudiante.Name = "lbestudiante";
            this.lbestudiante.Size = new System.Drawing.Size(96, 20);
            this.lbestudiante.TabIndex = 1;
            this.lbestudiante.Text = "Estudiante";
            // 
            // lbgrado
            // 
            this.lbgrado.AutoSize = true;
            this.lbgrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgrado.Location = new System.Drawing.Point(340, 13);
            this.lbgrado.Name = "lbgrado";
            this.lbgrado.Size = new System.Drawing.Size(59, 20);
            this.lbgrado.TabIndex = 1;
            this.lbgrado.Text = "Grado";
            // 
            // flpMateria
            // 
            this.flpMateria.Location = new System.Drawing.Point(441, 13);
            this.flpMateria.Name = "flpMateria";
            this.flpMateria.Size = new System.Drawing.Size(477, 20);
            this.flpMateria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupo";
            // 
            // ResumenPorIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 500);
            this.Controls.Add(this.flpMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbgrado);
            this.Controls.Add(this.lbestudiante);
            this.Controls.Add(this.pnGrupo);
            this.Name = "ResumenPorIndicador";
            this.Text = "Resumen Por Indicador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnGrupo;
        private System.Windows.Forms.Label lbestudiante;
        private System.Windows.Forms.Label lbgrado;
        private System.Windows.Forms.FlowLayoutPanel flpMateria;
        private System.Windows.Forms.Label label1;
    }
}