using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Evaluacion
{
    public class Seccions
    {
        public int IdSeccion { get; set; }
        public string Seccion { get; set; }
        public int Grado { get; set; }

        public Seccions(int id)
        {
            DataTable table = util.ValoresEnTabla("Select * from Seccion where IdSeccion=" + id + " ;");

            foreach (DataRow field in table.Rows)
            {
                IdSeccion = Convert.ToInt32(field["IdSeccion"].ToString());
                Seccion = field["Seccion"].ToString();
                Grado = Convert.ToInt32(field["Grado"].ToString());
            }
        }

        public Seccions(DataRow field)
        {

                IdSeccion = Convert.ToInt32(field["IdSeccion"].ToString());
                Seccion = field["Seccion"].ToString();
                Grado = Convert.ToInt32(field["Grado"].ToString());
            
        }

        public Seccions()
        {
            IdSeccion = 0;
            Seccion = "";
            Grado = 0;
        }

        public static void LlenarCbo(ref ComboBox cbo)
        {


            DataTable data = util.ValoresEnTabla(string.Format("select grado from Seccion group by Grado"));
            cbo.DataSource = data;
            cbo.ValueMember = "grado";
            cbo.DisplayMember = "grado";
        }


        public bool guardar()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CrudSeccion";
            cmd.Parameters.AddWithValue("@IdSeccion", IdSeccion);
            cmd.Parameters.AddWithValue("@Seccion", Seccion);
            cmd.Parameters.AddWithValue("@Grado", Grado);
            cmd.Parameters.Add("@Retorno", SqlDbType.Int);
            cmd.Parameters["@Retorno"].Direction = ParameterDirection.Output; //se debe especificar que es output
            return util.GuardarYUsarId("@Retorno", ref cmd);

        }
    }

}
