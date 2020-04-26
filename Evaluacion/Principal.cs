using Evaluacion.Evaluacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Principal : Form
    {
        public static bool close = false;
        public Principal()
        {
            InitializeComponent();
        }

        private void estudianteTSIM_DoubleClick(object sender, EventArgs e)
        {
            util.show(this, new GEstudiante());
        }

        private void detalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            util.show(this, new Individual());
        }

        private void evaluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            util.show(this, new GEvaluacion());

        }

        private void seccionTSIM_DoubleClick(object sender, EventArgs e)
        {
            util.show(this, new GSeccion());

        }

        private void materiaTSIM_DoubleClick(object sender, EventArgs e)
        {
            util.show(this, new GMateria());
        }

        private void indicadorTSIM_DoubleClick(object sender, EventArgs e)
        {
            util.show(this, new GIndicador());
        }

        private void evaluacionTSIM_DoubleClick(object sender, EventArgs e)
        {

        }

        private void crearEstudianteTSIM_Click(object sender, EventArgs e)
        {
            util.show(this, new MEstudiante());
        }

        private void editarEstudianteTSIM_Click(object sender, EventArgs e)
        {
          LEstudiante estudiante=   new LEstudiante();

            util.show(this, estudiante);
            if(estudiante.estudiante!=null)
                util.show(this, new MEstudiante(estudiante.estudiante));
        }

        private void crearSeccionTSIM_Click(object sender, EventArgs e)
        {
            util.show(this, new MSeccion());
        }

        private void editarSeccion_Click(object sender, EventArgs e)
        {
            LSeccion seccion = new LSeccion();

            util.show(this, seccion);
            if (seccion.seccions != null)
                util.show(this, new MSeccion(seccion.seccions));
        }

        private void crearMateriaTSIM_Click(object sender, EventArgs e)
        {
            util.show(this, new MMateria());
        }

        private void crearIndicadorTSIM_Click(object sender, EventArgs e)
        {
            util.show(this, new MIndicador());
        }

        private void editarIndicadorTSIM_Click(object sender, EventArgs e)
        {
            LIndicador indicador = new LIndicador();

            util.show(this, indicador);
            if (indicador.Indicadors != null)
                util.show(this, new MIndicador(indicador.Indicadors));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Dispose();
            close = true;
            Close();
        }
    }
}
