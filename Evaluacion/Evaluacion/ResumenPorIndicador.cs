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
    public partial class ResumenPorIndicador : Form
    {
        public ResumenPorIndicador()
        {
            InitializeComponent();

            for (int i=0; i<=9 ;i++)
            {
                RadioButton r = new RadioButton();
                r.Text = (i + 1).ToString();
                r.AutoSize = true;
                int x = 70 * i;
                r.Location = new Point(x, 0);
                pnGrupo.Controls.Add(r);
            }
        }

        private void pnGrupo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
