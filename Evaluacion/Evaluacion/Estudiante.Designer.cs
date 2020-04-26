namespace Evaluacion.Evaluacion
{
    partial class Estudiante
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pIdEvaluacion = new System.Windows.Forms.Panel();
            this.tbEstudiante = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.RadioButton();
            this.De = new System.Windows.Forms.RadioButton();
            this.bi = new System.Windows.Forms.RadioButton();
            this.ex = new System.Windows.Forms.RadioButton();
            this.tbnota = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pIdEvaluacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pIdEvaluacion
            // 
            this.pIdEvaluacion.Controls.Add(this.tbEstudiante);
            this.pIdEvaluacion.Location = new System.Drawing.Point(0, 0);
            this.pIdEvaluacion.Name = "pIdEvaluacion";
            this.pIdEvaluacion.Size = new System.Drawing.Size(203, 27);
            this.pIdEvaluacion.TabIndex = 1;
            // 
            // tbEstudiante
            // 
            this.tbEstudiante.AutoSize = true;
            this.tbEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstudiante.ForeColor = System.Drawing.Color.DarkOrange;
            this.tbEstudiante.Location = new System.Drawing.Point(-2, 7);
            this.tbEstudiante.Name = "tbEstudiante";
            this.tbEstudiante.Size = new System.Drawing.Size(34, 16);
            this.tbEstudiante.TabIndex = 0;
            this.tbEstudiante.Text = "Est:";
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(206, 8);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(51, 17);
            this.No.TabIndex = 2;
            this.No.TabStop = true;
            this.No.Text = "Nada";
            this.No.UseVisualStyleBackColor = true;
            this.No.CheckedChanged += new System.EventHandler(this.radios_CheckedChanged);
            // 
            // De
            // 
            this.De.AutoSize = true;
            this.De.Location = new System.Drawing.Point(261, 8);
            this.De.Name = "De";
            this.De.Size = new System.Drawing.Size(42, 17);
            this.De.TabIndex = 2;
            this.De.TabStop = true;
            this.De.Text = "Mal";
            this.De.UseVisualStyleBackColor = true;
            this.De.CheckedChanged += new System.EventHandler(this.radios_CheckedChanged);
            // 
            // bi
            // 
            this.bi.AutoSize = true;
            this.bi.Location = new System.Drawing.Point(308, 8);
            this.bi.Name = "bi";
            this.bi.Size = new System.Drawing.Size(46, 17);
            this.bi.TabIndex = 2;
            this.bi.TabStop = true;
            this.bi.Text = "Bien";
            this.bi.UseVisualStyleBackColor = true;
            this.bi.CheckedChanged += new System.EventHandler(this.radios_CheckedChanged);
            // 
            // ex
            // 
            this.ex.AutoSize = true;
            this.ex.Location = new System.Drawing.Point(360, 8);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(51, 17);
            this.ex.TabIndex = 2;
            this.ex.TabStop = true;
            this.ex.Text = "Excel";
            this.ex.UseVisualStyleBackColor = true;
            this.ex.CheckedChanged += new System.EventHandler(this.radios_CheckedChanged);
            // 
            // tbnota
            // 
            this.tbnota.Location = new System.Drawing.Point(417, 7);
            this.tbnota.Name = "tbnota";
            this.tbnota.Size = new System.Drawing.Size(46, 20);
            this.tbnota.TabIndex = 3;
            this.tbnota.TextChanged += new System.EventHandler(this.tbnota_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(596, 3);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(528, 7);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(62, 20);
            this.tbdescripcion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descr:";
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tbdescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tbnota);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.bi);
            this.Controls.Add(this.De);
            this.Controls.Add(this.No);
            this.Controls.Add(this.pIdEvaluacion);
            this.Name = "Estudiante";
            this.Size = new System.Drawing.Size(672, 28);
            this.pIdEvaluacion.ResumeLayout(false);
            this.pIdEvaluacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pIdEvaluacion;
        private System.Windows.Forms.Label tbEstudiante;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.RadioButton De;
        private System.Windows.Forms.RadioButton bi;
        private System.Windows.Forms.RadioButton ex;
        private System.Windows.Forms.TextBox tbnota;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbdescripcion;
    }
}
