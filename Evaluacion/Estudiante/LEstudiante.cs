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
    public partial class LEstudiante : Form
    {
        public  Estudiantes estudiante;
        public int id=0;

        DataTable dt;
        DataRow row;
        public LEstudiante()
        {

            InitializeComponent();

        }



        public void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgvEstudiante.DataSource = util.BusquedatLista(cboCriterio.Text, cboTabla.Text, tbbusqueda.Text);


        }

        private void dtgvEstudiante_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dtgvEstudiante_DoubleClick(object sender, EventArgs e)
        {

             dt = dtgvEstudiante.DataSource as DataTable;
             row = dt.Rows[dtgvEstudiante.CurrentRow.Index];
            estudiante = new Estudiantes(row);
            id = estudiante.IdEstudiante;
            this.Close();
        }

        private void tbbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar_Click(sender, e);
            }
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
             dt = dtgvEstudiante.DataSource as DataTable;
             row = dt.Rows[dtgvEstudiante.CurrentRow.Index];
            estudiante = new Estudiantes(row);
            id = estudiante.IdEstudiante;
        }

        private void btnProgreso_Click(object sender, EventArgs e)
        {
            if (dt!=null)
            {
                util.show(this, new ResumenPorIndicador());
            }
        }
    }

}
