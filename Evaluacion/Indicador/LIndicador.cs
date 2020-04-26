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
    public partial class LIndicador : Form
    {
        public  string id="";
        public Indicadors Indicadors;
        public LIndicador()
        {

            InitializeComponent();

        }

        public void Limpiar()
        {


        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgvIndicador.DataSource = util.BusquedatLista(cboCriterio.Text, cboTabla.Text, tbbusqueda.Text);
            Limpiar();
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
            cboTabla.SelectedIndex = cboTabla.Items.Count - 1;
        }

        private void dtgvIndicador_DoubleClick(object sender, EventArgs e)
        {
            id = dtgvIndicador.Rows[dtgvIndicador.CurrentRow.Index].Cells[IdIndicador.Index].Value.ToString();
            DataTable dt = dtgvIndicador.DataSource as DataTable;
            DataRow row = dt.Rows[dtgvIndicador.CurrentRow.Index];
            Indicadors = new Indicadors(row);
            this.Close();
        }
    }

}
