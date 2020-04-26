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
    public partial class GEstudiante : Form
    {
        string qr = "select * from estudiante where IdEstudiante>0 ";
        string nombre = "";
        string apellido = "";
        string seccion = "";
        string nacimiento = "";
        string direcion = "";
        string grdo = "";
        bool nd = false;
        bool dnd = false;
        Estudiantes est;

        public GEstudiante()
        {

            InitializeComponent();

            Seccions.LlenarCbo(ref cboGrado);
            nd = true;
        }

        public void Limpiar()
        {

            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbDireccion.Text = "";
            tbSeccion.Text = "";

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgvEstudiante.DataSource = util.ValoresEnTabla(qr + nombre + apellido + seccion + nacimiento + direcion + grdo);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
             nombre = "";
             apellido = "";
             seccion = "";
             nacimiento = "";
             direcion = "";
             grdo = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (est!=null)
            {
            util.show(this, new MEstudiante(est));
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            util.show(this, new MEstudiante());
        }


        private void tbNombre_TextChanged_1(object sender, EventArgs e)
        {
            nombre = String.Format($" and {tbNombre.Tag} like '%{tbNombre.Text}%' ");
        }

        private void tbApellidos_TextChanged(object sender, EventArgs e)
        {
            apellido = String.Format($" and {tbApellidos.Tag} like '%{tbApellidos.Text}%' ");

        }

        private void dtpnacimiento_ValueChanged(object sender, EventArgs e)
        {
            nacimiento = String.Format($" and {dtpnacimiento.Tag} like '%{dtpnacimiento.Text}%' ");
        }

        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nd)
            {
                grdo = String.Format($" and {cboGrado.Tag} like '%{cboGrado.Text}%' ");
            }
            nd = true;
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            direcion = String.Format($" and {tbDireccion.Tag} like '%{tbDireccion.Text}%' ");
        }

        private void tbSeccion_TextChanged(object sender, EventArgs e)
        {
            seccion = String.Format($" and {tbSeccion.Tag} like '%{tbSeccion.Text}%' ");
        }

        private void dtgvEstudiante_SelectionChanged(object sender, EventArgs e)
        {

            if (dnd)
            {
                DataTable dt = dtgvEstudiante.DataSource as DataTable;
                DataRow row = dt.Rows[dtgvEstudiante.CurrentRow.Index];
                est = new Estudiantes(row);
            }
            dnd = true;
        }
    }

}
