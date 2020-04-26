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
    public partial class GEvaluacion : Form
    {
        bool secpuede = false;
        bool indpuede = false;
        bool grado = false;
        public GEvaluacion()
        {

            InitializeComponent();

            util.LlenarCbo(ref cboPeriodo, "Periodo");
            Seccions.LlenarCbo(ref cboGrado);
            cboPeriodo.SelectedValue = util.Idperiodo();
            grado = true;
        }

        public void Limpiar()
        {

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {


        }

        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grado)
            {
                util.LlenarCbo(ref cboMateria, "Materia", "grado=", cboGrado.Text);
                util.LlenarCbo(ref cboSeccion, "Seccion", "grado=", cboGrado.Text);
                secpuede = true;
            }
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secpuede)
                util.LlenarCbo(ref cboIndicador, "Indicador", "Idmateria=", cboMateria.SelectedValue.ToString());
            indpuede = true;
        }

        private void cboIndicador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (indpuede)
            {
                foreach (Evaluacion.Estudiante item in flpControls.Controls)
                {
                    item.IdIndicador = Convert.ToInt32(cboIndicador.SelectedValue.ToString());
                    item.Indicador = cboIndicador.Text.ToString();
                }
            }
        }

        private void btnSetDescripcion_Click(object sender, EventArgs e)
        {
            flpControls.Controls.Clear();
            if (indpuede)
            {
                Estudiantes estudiantes = new Estudiantes();
                estudiantes.LlenarEst(Convert.ToInt32(cboGrado.Text.ToString()), Convert.ToInt32(cboSeccion.SelectedValue.ToString()));
                Evaluacions evaluacions = new Evaluacions();
                indpuede = true;
                evaluacions.LlenarList(estudiantes.LEstudiante, cboMateria.Text, Convert.ToInt32(cboMateria.SelectedValue.ToString()), cboPeriodo.Text);

                foreach (Evaluacions item in evaluacions.levaluacions)
                {
                    Evaluacion.Estudiante estudiante = new Estudiante(item);
                    estudiante.IdIndicador= Convert.ToInt32(cboIndicador.SelectedValue.ToString());
                    estudiante.Indicador= cboIndicador.Text.ToString();
                    estudiante.Descripcion= tbDescripcion.Text;
                    flpControls.Controls.Add(estudiante);
                }

            }
        }

        private void btnfiltro_Click(object sender, EventArgs e)
        {
            List<string> campo = new List<string>();
            List<string> filtro = new List<string>();

            campo.Add("Idmateria=");
            filtro.Add(cboMateria.SelectedValue.ToString());
            campo.Add("indicador like ");
            filtro.Add(string.Format($"'%{tbfiltro.Text}%'"));
            if (secpuede)
                util.LlenarCbo(ref cboIndicador, "Indicador",campo,filtro);

        }
    }

}
