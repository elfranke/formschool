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
    public partial class GMateria : Form
    {
         bool dnd=true;
         Materias materia;
         string qr = "select * from Materia where IdMateria>0  ";
         bool nd=false;
         string grdo="";
         string mat;

        public GMateria()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            tbMateria.Text = "";
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            dtgvMateria.DataSource = util.ValoresEnTabla(qr + mat + grdo);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            util.show(this, new MMateria(materia));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            util.show(this, new MMateria());
        }

        private void dtgvMateria_SelectionChanged(object sender, EventArgs e)
        {
            if (dnd)
            {
                DataTable dt = dtgvMateria.DataSource as DataTable;
                DataRow row = dt.Rows[dtgvMateria.CurrentRow.Index];
                materia = new Materias(row);
            }
            dnd = true;
        }

        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nd)
            {
                grdo = String.Format($" and {cboGrado.Tag} like '%{cboGrado.Text}%' ");
            }
            nd = true;
        }

        private void tbMateria_TextChanged(object sender, EventArgs e)
        {
            mat = String.Format($" and {tbMateria.Tag} like '%{tbMateria.Text}%' ");
        }
    }

}
