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
    public partial class MMateria : Form
    {
        Materias materia;
        public MMateria()
        {
            InitializeComponent();
            materia = new Materias();
            Seccions.LlenarCbo(ref cboGrado);
        }
        public MMateria(Materias materia)
        {
            InitializeComponent();
            Seccions.LlenarCbo(ref cboGrado);
        }

        public void Limpiar()
        {
           
            tbMateria.Text = "";
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            materia.IdMateria = Convert.ToInt32(tbIdMateria.Text);
            materia.Materia = tbMateria.Text;
            materia.Grado = Convert.ToInt32(cboGrado.Text);
            materia.IdUsuario = Usuarios.id;
            materia.guardar();
            Limpiar();

        }

    }

}
