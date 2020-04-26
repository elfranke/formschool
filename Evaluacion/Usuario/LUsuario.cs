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
    public partial class LUsuario : Form
    {
        public string id = "";
        public string nombre = "";
        public LUsuario()
        {

            InitializeComponent();

        }

        public void Limpiar()
        {
            tbbusqueda.Clear();

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgvUsuario.DataSource = util.BusquedatLista(cboCriterio.Text, cboTabla.Text, tbbusqueda.Text);
            Limpiar();
        }

        private void dtgvUsuario_DoubleClick(object sender, EventArgs e)
        {
            id = dtgvUsuario.Rows[dtgvUsuario.CurrentRow.Index].Cells[IdUsuario.Index].Value.ToString();
            nombre = dtgvUsuario.Rows[dtgvUsuario.CurrentRow.Index].Cells[Nombre.Index].Value.ToString();
            this.Close();
        }

        private void tbbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnGuardar_Click(sender, e);
            }
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTabla.SelectedIndex = cboTabla.Items.Count - 1;
        }
    }

}
