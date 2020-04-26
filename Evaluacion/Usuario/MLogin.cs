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
    public partial class MLogin : Form
    {

        public MLogin()
        {

            InitializeComponent();
            tbUsuario.ContextMenu = util.contenmenu();
            tbContrasena.ContextMenu = util.contenmenu();

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (Usuarios.login(tbUsuario.Text,tbContrasena.Text))
            {
                util.show(this, new Principal());
                tbContrasena.Text = "";
                tbUsuario.Text = "";
                if (Principal.close)
                {
                    Close();
                }
            }
            else
            {
                tbContrasena.Text = "";
            }

        }

        private void tbContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAcceder_Click(sender, e);
        }
    }

}
