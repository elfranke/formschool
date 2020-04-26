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
    public partial class GIndicador : Form
    {
         string qr="select * from indicador where idindicador>0 ";
         bool nd=false;
         string grdo="";
         string mat="";
         string ind="";
         bool dnd=false;
         Indicadors indicador;

        public GIndicador()
        {

            InitializeComponent();

        }

        public void Limpiar()
        {

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgvIndicador.DataSource = util.ValoresEnTabla(qr + mat + grdo+ind);

        }

        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nd)
            {
                grdo = String.Format($" and {cboGrado.Tag} like '%{cboGrado.Text}%' ");
            }
            nd = true;
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nd)
            {
                mat = String.Format($" and {cboMateria.Tag} like '%{cboMateria.Text}%' ");
            }
            nd = true;
        }

        private void tbIndicador_TextChanged(object sender, EventArgs e)
        {
            ind = String.Format($" and {cboMateria.Tag} like '%{cboMateria.Text}%' ");

        }

        private void dtgvIndicador_SelectionChanged(object sender, EventArgs e)
        {
            if (dnd)
            {
                DataTable dt = dtgvIndicador.DataSource as DataTable;
                DataRow row = dt.Rows[dtgvIndicador.CurrentRow.Index];
                indicador = new Indicadors(row);
            }
            dnd = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            util.show(this, new MIndicador(indicador));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            util.show(this, new MIndicador());

        }
    }

}
