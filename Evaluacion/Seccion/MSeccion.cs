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
    public partial class MSeccion : Form
    {
        Seccions seccion;
        public MSeccion()
        {
            
            InitializeComponent();
            seccion = new Seccions();
        }

        public MSeccion(Seccions sec)
        {

            InitializeComponent();
            seccion = sec;

            tbIdSeccion.Text = seccion.IdSeccion.ToString();
            tbSeccion.Text = seccion.Seccion;
            tbgrado.Text = seccion.Grado.ToString();
        }

        public void Limpiar()
        {

            tbSeccion.Text = "";
            tbgrado.Text = "";
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {

            seccion.IdSeccion = Convert.ToInt32(tbIdSeccion.Text);
            seccion.Seccion = tbSeccion.Text;
            seccion.Grado = Convert.ToInt32(tbgrado.Text);
            seccion.guardar();
            Limpiar();

        }

    }

}
