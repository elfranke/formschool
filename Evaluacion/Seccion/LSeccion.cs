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
    public partial class LSeccion : Form
    {
        public string id = "";
        public Seccions seccions;

        public LSeccion()
        {

            InitializeComponent();
            new Seccions();

        }

        public void Limpiar()
        {


        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgvSeccion.DataSource = util.BusquedatLista(cboCriterio.Text, cboTabla.Text, tbbusqueda.Text);
            Limpiar();

        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTabla.SelectedIndex = cboTabla.Items.Count - 1;

        }

        private void tbbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar_Click(sender, e);
            }
        }

        private void dtgvSeccion_DoubleClick(object sender, EventArgs e)
        {
            id = dtgvSeccion.Rows[dtgvSeccion.CurrentRow.Index].Cells[IdSeccion.Index].Value.ToString();
            DataTable dt = dtgvSeccion.DataSource as DataTable;
            DataRow row = dt.Rows[dtgvSeccion.CurrentRow.Index];
            seccions = new Seccions(row);
            this.Close();
        }
    }

}
