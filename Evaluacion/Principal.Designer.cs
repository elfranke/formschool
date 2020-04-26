namespace Evaluacion
{
    partial class Principal
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.estudianteTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEstudianteTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEstudianteTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.seccionTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSeccionTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.editarSeccion = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMateriaTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.indicadorTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.crearIndicadorTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.editarIndicadorTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteTSIM,
            this.seccionTSIM,
            this.materiaTSIM,
            this.indicadorTSIM,
            this.evaluacionTSIM,
            this.salirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(696, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // estudianteTSIM
            // 
            this.estudianteTSIM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEstudianteTSIM,
            this.editarEstudianteTSIM});
            this.estudianteTSIM.Name = "estudianteTSIM";
            this.estudianteTSIM.Size = new System.Drawing.Size(74, 20);
            this.estudianteTSIM.Text = "Estudiante";
            this.estudianteTSIM.DoubleClick += new System.EventHandler(this.estudianteTSIM_DoubleClick);
            // 
            // crearEstudianteTSIM
            // 
            this.crearEstudianteTSIM.Name = "crearEstudianteTSIM";
            this.crearEstudianteTSIM.Size = new System.Drawing.Size(104, 22);
            this.crearEstudianteTSIM.Text = "Crear";
            this.crearEstudianteTSIM.Click += new System.EventHandler(this.crearEstudianteTSIM_Click);
            // 
            // editarEstudianteTSIM
            // 
            this.editarEstudianteTSIM.Name = "editarEstudianteTSIM";
            this.editarEstudianteTSIM.Size = new System.Drawing.Size(104, 22);
            this.editarEstudianteTSIM.Text = "Editar";
            this.editarEstudianteTSIM.Click += new System.EventHandler(this.editarEstudianteTSIM_Click);
            // 
            // seccionTSIM
            // 
            this.seccionTSIM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSeccionTSIM,
            this.editarSeccion});
            this.seccionTSIM.Name = "seccionTSIM";
            this.seccionTSIM.Size = new System.Drawing.Size(60, 20);
            this.seccionTSIM.Text = "Seccion";
            this.seccionTSIM.DoubleClick += new System.EventHandler(this.seccionTSIM_DoubleClick);
            // 
            // crearSeccionTSIM
            // 
            this.crearSeccionTSIM.Name = "crearSeccionTSIM";
            this.crearSeccionTSIM.Size = new System.Drawing.Size(104, 22);
            this.crearSeccionTSIM.Text = "Crear";
            this.crearSeccionTSIM.Click += new System.EventHandler(this.crearSeccionTSIM_Click);
            // 
            // editarSeccion
            // 
            this.editarSeccion.Name = "editarSeccion";
            this.editarSeccion.Size = new System.Drawing.Size(104, 22);
            this.editarSeccion.Text = "Editar";
            this.editarSeccion.Click += new System.EventHandler(this.editarSeccion_Click);
            // 
            // materiaTSIM
            // 
            this.materiaTSIM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearMateriaTSIM});
            this.materiaTSIM.Name = "materiaTSIM";
            this.materiaTSIM.Size = new System.Drawing.Size(59, 20);
            this.materiaTSIM.Text = "Materia";
            this.materiaTSIM.DoubleClick += new System.EventHandler(this.materiaTSIM_DoubleClick);
            // 
            // crearMateriaTSIM
            // 
            this.crearMateriaTSIM.Name = "crearMateriaTSIM";
            this.crearMateriaTSIM.Size = new System.Drawing.Size(102, 22);
            this.crearMateriaTSIM.Text = "Crear";
            this.crearMateriaTSIM.Click += new System.EventHandler(this.crearMateriaTSIM_Click);
            // 
            // indicadorTSIM
            // 
            this.indicadorTSIM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearIndicadorTSIM,
            this.editarIndicadorTSIM});
            this.indicadorTSIM.Name = "indicadorTSIM";
            this.indicadorTSIM.Size = new System.Drawing.Size(69, 20);
            this.indicadorTSIM.Text = "Indicador";
            this.indicadorTSIM.DoubleClick += new System.EventHandler(this.indicadorTSIM_DoubleClick);
            // 
            // crearIndicadorTSIM
            // 
            this.crearIndicadorTSIM.Name = "crearIndicadorTSIM";
            this.crearIndicadorTSIM.Size = new System.Drawing.Size(104, 22);
            this.crearIndicadorTSIM.Text = "Crear";
            this.crearIndicadorTSIM.Click += new System.EventHandler(this.crearIndicadorTSIM_Click);
            // 
            // editarIndicadorTSIM
            // 
            this.editarIndicadorTSIM.Name = "editarIndicadorTSIM";
            this.editarIndicadorTSIM.Size = new System.Drawing.Size(104, 22);
            this.editarIndicadorTSIM.Text = "Editar";
            this.editarIndicadorTSIM.Click += new System.EventHandler(this.editarIndicadorTSIM_Click);
            // 
            // evaluacionTSIM
            // 
            this.evaluacionTSIM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evaluarToolStripMenuItem,
            this.detalleToolStripMenuItem});
            this.evaluacionTSIM.Name = "evaluacionTSIM";
            this.evaluacionTSIM.Size = new System.Drawing.Size(76, 20);
            this.evaluacionTSIM.Text = "Evaluacion";
            this.evaluacionTSIM.DoubleClick += new System.EventHandler(this.evaluacionTSIM_DoubleClick);
            // 
            // evaluarToolStripMenuItem
            // 
            this.evaluarToolStripMenuItem.Name = "evaluarToolStripMenuItem";
            this.evaluarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.evaluarToolStripMenuItem.Text = "Evaluar";
            this.evaluarToolStripMenuItem.Click += new System.EventHandler(this.evaluarToolStripMenuItem_Click);
            // 
            // detalleToolStripMenuItem
            // 
            this.detalleToolStripMenuItem.Name = "detalleToolStripMenuItem";
            this.detalleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.detalleToolStripMenuItem.Text = "Detalle";
            this.detalleToolStripMenuItem.Click += new System.EventHandler(this.detalleToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem estudianteTSIM;
        private System.Windows.Forms.ToolStripMenuItem crearEstudianteTSIM;
        private System.Windows.Forms.ToolStripMenuItem editarEstudianteTSIM;
        private System.Windows.Forms.ToolStripMenuItem seccionTSIM;
        private System.Windows.Forms.ToolStripMenuItem crearSeccionTSIM;
        private System.Windows.Forms.ToolStripMenuItem editarSeccion;
        private System.Windows.Forms.ToolStripMenuItem materiaTSIM;
        private System.Windows.Forms.ToolStripMenuItem crearMateriaTSIM;
        private System.Windows.Forms.ToolStripMenuItem indicadorTSIM;
        private System.Windows.Forms.ToolStripMenuItem crearIndicadorTSIM;
        private System.Windows.Forms.ToolStripMenuItem editarIndicadorTSIM;
        private System.Windows.Forms.ToolStripMenuItem evaluacionTSIM;
        private System.Windows.Forms.ToolStripMenuItem evaluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}