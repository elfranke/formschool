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
    public partial class GSeccion : Form
    {
         bool nd = false;
         string grdo;
         string seccion;
         string qr= "select * from Seccion where IdSeccion>0 ";
         bool dnd=false;
         Seccions sec;

        public GSeccion()
        {
            InitializeComponent();
        }


        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nd)
            {
                grdo = String.Format($" and {cboGrado.Tag} like '%{cboGrado.Text}%' ");
            }
            nd = true;
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgvSeccion.DataSource = util.ValoresEnTabla(qr + seccion  + grdo);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            util.show(this, new MSeccion(sec));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            util.show(this, new MSeccion());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbSeccion.Text = "";
        }


        private void tbSeccion_TextChanged(object sender, EventArgs e)
        {
            seccion = String.Format($" and {tbSeccion.Tag} like '%{tbSeccion.Text}%' ");
        }

        private void dtgvSeccion_SelectionChanged(object sender, EventArgs e)
        {
            if (dnd)
            {
                DataTable dt = dtgvSeccion.DataSource as DataTable;
                DataRow row = dt.Rows[dtgvSeccion.CurrentRow.Index];
                sec = new Seccions(row);
            }
            dnd = true;
        }
    }

}
