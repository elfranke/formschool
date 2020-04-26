using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion.Evaluacion
{
    public partial class Estudiante : UserControl
    {
        public string Descripcion
        {
            get
            {
                return tbdescripcion.Text;
            }
            set
            {
                tbdescripcion.Text = value;
            }
        }
        public string Indicador = "";
        public int IdIndicador = 0;

         Evaluacions evaluado;
        public Estudiante(Evaluacions eva,int idestudiante=0)
        {
            InitializeComponent();
            evaluado = eva;
            tbEstudiante.Text = eva.Estudiante;
        }

        private void radios_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            switch (radio.Text)
            {
                case "nada":
                    evaluado.Evaluacion = Convert.ToDecimal(0);
                    break;
                case "mal":
                    evaluado.Evaluacion = Convert.ToDecimal(1.5);
                    break;
                case "Bien":
                    evaluado.Evaluacion = Convert.ToDecimal(2.5);
                    break;
                case "Excel":
                    evaluado.Evaluacion = Convert.ToDecimal(3.5);
                    break;
                case "Otro":
                //   
                    break;
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            evaluado.Indicador = Indicador;
            evaluado.IdIndicador = IdIndicador;
            evaluado.Descripcion = Descripcion;
            if (evaluado.guardar())
                BackColor = Color.Red;
        }

        private void tbnota_TextChanged(object sender, EventArgs e)
        {
            try
            {
                evaluado.Evaluacion = Convert.ToDecimal(tbnota.Text);
            }
            catch (Exception)
            {

            }
        }
    }
}
