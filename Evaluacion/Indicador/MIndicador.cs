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
    public partial class MIndicador : Form
    {
        Indicadors indicador;
        bool grado = false;
        public MIndicador()
        {
            InitializeComponent();
            indicador = new Indicadors();
            Seccions.LlenarCbo(ref cboGrado);
            grado = true;
        }

        public MIndicador(Indicadors ind)
        {
            InitializeComponent();
            Seccions.LlenarCbo(ref cboGrado);
            indicador = ind;
            tbIdIndicador.Text = ind.IdIndicador.ToString();
            tbIndicador.Text = ind.Indicador;

            cboMateria.SelectedValue = ind.IdMateria;

            cboGrado.SelectedValue = ind.Grado;
            grado = true;
        }

        public void Limpiar()
        {

            
            tbIndicador.Text = "";

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {

            indicador.IdIndicador = Convert.ToInt32(tbIdIndicador.Text);
            indicador.Indicador = tbIndicador.Text;
            indicador.Grado = Convert.ToInt32(cboGrado.Text);
            indicador.IdMateria = Convert.ToInt32(cboMateria.SelectedValue.ToString());
            indicador.Materia = cboMateria.Text;
            indicador.guardar();
            Limpiar();

        }

        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(grado)
                util.LlenarCbo(ref cboMateria, "Materia",campo:"grado=",filtro:cboGrado.SelectedValue.ToString());
        }
    }

}
