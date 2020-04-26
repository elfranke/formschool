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
    public partial class MUsuario : Form
    {

        public MUsuario()
        {

            InitializeComponent();

        }

        public void Limpiar()
        {

            tbUsuario.Text = "";
            tbNombre.Text = "";
            tbPass.Text = "";

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {

            Usuarios usuario = new Usuarios();
            usuario.IdUsuario = Convert.ToInt32(tbIdUsuario.Text);
            usuario.Usuario = tbUsuario.Text;
            usuario.Nombre = tbNombre.Text;
            usuario.Pass = tbPass.Text;
            usuario.IdEmpresa =Convert.ToInt32(tbIdEmpresa.Text);
            usuario.Activo = chkActivo.Checked;
            usuario.guardar();
            Limpiar();

        }

    }

}
