using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion.Evaluacion
{
    public partial class Individual : Form
    {
        bool ES = false;
        public Individual()
        {
            InitializeComponent();
            Seccions.LlenarCbo(ref cboGrado);
        }

 

        private void btnSetDescripcion_Click(object sender, EventArgs e)
        {
            LEstudiante estudiante = new LEstudiante();
            estudiante.ShowDialog();
            ES = true;
            cboEstudiante.SelectedValue = estudiante.id;

            ES = false;
        }


        decimal total()
        {
            decimal dc = 0;
            foreach (DataGridViewRow item in dtgvEvaluacion.Rows)
            {
              dc+=  Convert.ToDecimal(item.Cells["Evaluacion"].Value);
            }

            return dc;
        }



        private void cboGrado_DropDownClosed(object sender, EventArgs e)
        {
            util.LlenarCbo(ref cboMateria, "Materia", "grado=", cboGrado.Text);
            util.LlenarCbo(ref cboSeccion, "Seccion", "grado=", cboGrado.Text);
        }

        private void cboSeccion_DropDownClosed(object sender, EventArgs e)
        {
            util.LlenarCbo(ref cboEstudiante, tabla: "estudiante", campo: "IdSeccion=", filtro: cboSeccion.SelectedValue.ToString(), sele: " IdEstudiante, CONCAT(Nombre,' ',Apellidos) as Estudiante   ");
            tbtotal.Text = "";
        }

        private void cboEstudiante_DropDownClosed(object sender, EventArgs e)
        {
            Evaluacions.llenarIndicadorEvaluado(ref cboIndicador, cboMateria.SelectedValue.ToString(), cboEstudiante.SelectedValue.ToString());
            DataTable dt = util.ValoresEnTabla("select * from evaluacion where idevaluacion=0");
            dtgvEvaluacion.DataSource = dt;
            
        }

        private void cboIndicador_DropDownClosed(object sender, EventArgs e)
        {
            if (cboIndicador.Items.Count > 0)
            {
                dtgvEvaluacion.DataSource = util.ValoresEnTabla($"select * from evaluacion where idestudiante={cboEstudiante.SelectedValue.ToString()} " +
                     $" and idindicador={cboIndicador.SelectedValue.ToString()}");

                if (dtgvEvaluacion.Rows.Count > 0)
                {
                    tbtotal.Text = total().ToString();

                }
            }

        }

        private void cboEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ES)
                Evaluacions.llenarIndicadorEvaluado(ref cboIndicador, cboMateria.SelectedValue.ToString(), cboEstudiante.SelectedValue.ToString());

        }
    }
}
