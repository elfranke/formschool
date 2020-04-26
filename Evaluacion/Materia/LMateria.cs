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
    public partial class LMateria : Form
    {
        public string id = "";

        public LMateria()
        {

            InitializeComponent();

        }

        public void Limpiar()
        {


        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgvMateria.DataSource = util.BusquedatLista(cboCriterio.Text, cboTabla.Text, tbbusqueda.Text);
            Limpiar();

        }

        private void dtgvMateria_DoubleClick(object sender, EventArgs e)
        {
            id = dtgvMateria.Rows[dtgvMateria.CurrentRow.Index].Cells[IdMateria.Index].Value.ToString();
            this.Close();
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
    }

}
