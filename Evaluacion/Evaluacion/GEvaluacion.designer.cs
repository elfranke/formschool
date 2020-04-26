namespace Evaluacion
{
    partial class GEvaluacion
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
            this.pIdSeccion = new System.Windows.Forms.Panel();
            this.cboSeccion = new System.Windows.Forms.ComboBox();
            this.lbIdSeccion = new System.Windows.Forms.Label();
            this.pIdIndicador = new System.Windows.Forms.Panel();
            this.cboIndicador = new System.Windows.Forms.ComboBox();
            this.lbIdIndicador = new System.Windows.Forms.Label();
            this.pIdMateria = new System.Windows.Forms.Panel();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lbIdMateria = new System.Windows.Forms.Label();
            this.pIdPeriodo = new System.Windows.Forms.Panel();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.lbIdPeriodo = new System.Windows.Forms.Label();
            this.pGrado = new System.Windows.Forms.Panel();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.lbGrado = new System.Windows.Forms.Label();
            this.flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetDescripcion = new System.Windows.Forms.Button();
            this.tbfiltro = new System.Windows.Forms.TextBox();
            this.btnfiltro = new System.Windows.Forms.Button();
            this.pIdSeccion.SuspendLayout();
            this.pIdIndicador.SuspendLayout();
            this.pIdMateria.SuspendLayout();
            this.pIdPeriodo.SuspendLayout();
            this.pGrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pIdSeccion
            // 
            this.pIdSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pIdSeccion.Controls.Add(this.cboSeccion);
            this.pIdSeccion.Controls.Add(this.lbIdSeccion);
            this.pIdSeccion.Location = new System.Drawing.Point(474, 9);
            this.pIdSeccion.Name = "pIdSeccion";
            this.pIdSeccion.Size = new System.Drawing.Size(180, 52);
            this.pIdSeccion.TabIndex = 3;
            // 
            // cboSeccion
            // 
            this.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeccion.FormattingEnabled = true;
            this.cboSeccion.Location = new System.Drawing.Point(6, 28);
            this.cboSeccion.Name = "cboSeccion";
            this.cboSeccion.Size = new System.Drawing.Size(171, 21);
            this.cboSeccion.TabIndex = 1;
            // 
            // lbIdSeccion
            // 
            this.lbIdSeccion.AutoSize = true;
            this.lbIdSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdSeccion.Location = new System.Drawing.Point(3, 4);
            this.lbIdSeccion.Name = "lbIdSeccion";
            this.lbIdSeccion.Size = new System.Drawing.Size(64, 16);
            this.lbIdSeccion.TabIndex = 0;
            this.lbIdSeccion.Text = "Seccion";
            // 
            // pIdIndicador
            // 
            this.pIdIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pIdIndicador.Controls.Add(this.cboIndicador);
            this.pIdIndicador.Controls.Add(this.lbIdIndicador);
            this.pIdIndicador.Location = new System.Drawing.Point(140, 125);
            this.pIdIndicador.Name = "pIdIndicador";
            this.pIdIndicador.Size = new System.Drawing.Size(542, 52);
            this.pIdIndicador.TabIndex = 4;
            // 
            // cboIndicador
            // 
            this.cboIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIndicador.FormattingEnabled = true;
            this.cboIndicador.Location = new System.Drawing.Point(4, 28);
            this.cboIndicador.Name = "cboIndicador";
            this.cboIndicador.Size = new System.Drawing.Size(538, 21);
            this.cboIndicador.TabIndex = 1;
            this.cboIndicador.SelectedIndexChanged += new System.EventHandler(this.cboIndicador_SelectedIndexChanged);
            // 
            // lbIdIndicador
            // 
            this.lbIdIndicador.AutoSize = true;
            this.lbIdIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdIndicador.Location = new System.Drawing.Point(3, 4);
            this.lbIdIndicador.Name = "lbIdIndicador";
            this.lbIdIndicador.Size = new System.Drawing.Size(73, 16);
            this.lbIdIndicador.TabIndex = 0;
            this.lbIdIndicador.Text = "Indicador";
            // 
            // pIdMateria
            // 
            this.pIdMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pIdMateria.Controls.Add(this.cboMateria);
            this.pIdMateria.Controls.Add(this.lbIdMateria);
            this.pIdMateria.Location = new System.Drawing.Point(1, 67);
            this.pIdMateria.Name = "pIdMateria";
            this.pIdMateria.Size = new System.Drawing.Size(681, 52);
            this.pIdMateria.TabIndex = 6;
            // 
            // cboMateria
            // 
            this.cboMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(3, 28);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(675, 21);
            this.cboMateria.TabIndex = 1;
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged);
            // 
            // lbIdMateria
            // 
            this.lbIdMateria.AutoSize = true;
            this.lbIdMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdMateria.Location = new System.Drawing.Point(3, 4);
            this.lbIdMateria.Name = "lbIdMateria";
            this.lbIdMateria.Size = new System.Drawing.Size(60, 16);
            this.lbIdMateria.TabIndex = 0;
            this.lbIdMateria.Text = "Materia";
            // 
            // pIdPeriodo
            // 
            this.pIdPeriodo.Controls.Add(this.cboPeriodo);
            this.pIdPeriodo.Controls.Add(this.lbIdPeriodo);
            this.pIdPeriodo.Location = new System.Drawing.Point(1, 9);
            this.pIdPeriodo.Name = "pIdPeriodo";
            this.pIdPeriodo.Size = new System.Drawing.Size(180, 52);
            this.pIdPeriodo.TabIndex = 8;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(1, 27);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(176, 21);
            this.cboPeriodo.TabIndex = 1;
            // 
            // lbIdPeriodo
            // 
            this.lbIdPeriodo.AutoSize = true;
            this.lbIdPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPeriodo.Location = new System.Drawing.Point(3, 4);
            this.lbIdPeriodo.Name = "lbIdPeriodo";
            this.lbIdPeriodo.Size = new System.Drawing.Size(63, 16);
            this.lbIdPeriodo.TabIndex = 0;
            this.lbIdPeriodo.Text = "Periodo";
            // 
            // pGrado
            // 
            this.pGrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pGrado.Controls.Add(this.cboGrado);
            this.pGrado.Controls.Add(this.lbGrado);
            this.pGrado.Location = new System.Drawing.Point(235, 9);
            this.pGrado.Name = "pGrado";
            this.pGrado.Size = new System.Drawing.Size(180, 52);
            this.pGrado.TabIndex = 10;
            // 
            // cboGrado
            // 
            this.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(1, 27);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(173, 21);
            this.cboGrado.TabIndex = 1;
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
            // flpControls
            // 
            this.flpControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpControls.AutoScroll = true;
            this.flpControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpControls.Location = new System.Drawing.Point(2, 235);
            this.flpControls.Name = "flpControls";
            this.flpControls.Size = new System.Drawing.Size(680, 223);
            this.flpControls.TabIndex = 11;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcion.Location = new System.Drawing.Point(2, 201);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(595, 20);
            this.tbDescripcion.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descricion";
            // 
            // btnSetDescripcion
            // 
            this.btnSetDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDescripcion.Location = new System.Drawing.Point(613, 198);
            this.btnSetDescripcion.Name = "btnSetDescripcion";
            this.btnSetDescripcion.Size = new System.Drawing.Size(69, 23);
            this.btnSetDescripcion.TabIndex = 13;
            this.btnSetDescripcion.Text = "...";
            this.btnSetDescripcion.UseVisualStyleBackColor = true;
            this.btnSetDescripcion.Click += new System.EventHandler(this.btnSetDescripcion_Click);
            // 
            // tbfiltro
            // 
            this.tbfiltro.Location = new System.Drawing.Point(2, 153);
            this.tbfiltro.Name = "tbfiltro";
            this.tbfiltro.Size = new System.Drawing.Size(92, 20);
            this.tbfiltro.TabIndex = 14;
            // 
            // btnfiltro
            // 
            this.btnfiltro.Location = new System.Drawing.Point(100, 151);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(34, 23);
            this.btnfiltro.TabIndex = 15;
            this.btnfiltro.Text = "filtrar";
            this.btnfiltro.UseVisualStyleBackColor = true;
            this.btnfiltro.Click += new System.EventHandler(this.btnfiltro_Click);
            // 
            // GEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnfiltro);
            this.Controls.Add(this.tbfiltro);
            this.Controls.Add(this.btnSetDescripcion);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpControls);
            this.Controls.Add(this.pIdIndicador);
            this.Controls.Add(this.pIdMateria);
            this.Controls.Add(this.pIdPeriodo);
            this.Controls.Add(this.pIdSeccion);
            this.Controls.Add(this.pGrado);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "GEvaluacion";
            this.Text = "GEvaluacion";
            this.pIdSeccion.ResumeLayout(false);
            this.pIdSeccion.PerformLayout();
            this.pIdIndicador.ResumeLayout(false);
            this.pIdIndicador.PerformLayout();
            this.pIdMateria.ResumeLayout(false);
            this.pIdMateria.PerformLayout();
            this.pIdPeriodo.ResumeLayout(false);
            this.pIdPeriodo.PerformLayout();
            this.pGrado.ResumeLayout(false);
            this.pGrado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel pIdSeccion;
        private System.Windows.Forms.Label lbIdSeccion;

        private System.Windows.Forms.Panel pIdIndicador;
        private System.Windows.Forms.Label lbIdIndicador;

        private System.Windows.Forms.Panel pIdMateria;
        private System.Windows.Forms.Label lbIdMateria;

        private System.Windows.Forms.Panel pIdPeriodo;
        private System.Windows.Forms.Label lbIdPeriodo;

        private System.Windows.Forms.Panel pGrado;
        private System.Windows.Forms.Label lbGrado;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.ComboBox cboIndicador;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.FlowLayoutPanel flpControls;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetDescripcion;
        private System.Windows.Forms.TextBox tbfiltro;
        private System.Windows.Forms.Button btnfiltro;
    }
}
