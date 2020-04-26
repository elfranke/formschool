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
    public partial class MEstudiante : Form
    {
        Estudiantes estudiante;
        bool grado = false;
        bool sc = false;

        public MEstudiante(Estudiantes est)
        {

            InitializeComponent();
            estudiante = est;
            util.LlenarCbo(ref cboSeccion, "Seccion", "grado=", est.Grado.ToString());
            Seccions.LlenarCbo(ref cboGrado);
            grado = true;

            tbIdEstudiante.Text = estudiante.IdEstudiante.ToString();
            tbNombre.Text=estudiante.Nombre ;
            tbApellidos.Text=estudiante.Apellidos ;
            tbDireccion.Text=estudiante.Direccion ;
            dtpNacimiento.Text=estudiante.Nacimiento.ToString();
            cboGrado.SelectedValue = estudiante.Grado;
            cboSeccion.SelectedValue = estudiante.IdSeccion;

        }

        public MEstudiante()
        {

            InitializeComponent();
            estudiante = new Estudiantes();
            Seccions.LlenarCbo(ref cboGrado);
            grado = true;

        }
        public void Limpiar()
        {

            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbDireccion.Text = "";

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            estudiante.IdEstudiante = Convert.ToInt32(tbIdEstudiante.Text);
            estudiante.Nombre = tbNombre.Text;
            estudiante.Apellidos = tbApellidos.Text;
            estudiante.Direccion = tbDireccion.Text;
            estudiante.Nacimiento = Convert.ToDateTime(dtpNacimiento.Text);
            estudiante.Grado = Convert.ToInt32(cboGrado.SelectedValue);
            estudiante.IdSeccion = Convert.ToInt32(cboSeccion.SelectedValue);
            estudiante.Seccion = cboSeccion.Text;
            estudiante.guardar();
            Limpiar();

        }

        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(estudiante.IdEstudiante==0)
                if(grado)
                    util.LlenarCbo(ref cboSeccion, "Seccion", "grado=", cboGrado.Text); 

        }



        private void MEstudiante_Load(object sender, EventArgs e)
        {

        }
    }

}
