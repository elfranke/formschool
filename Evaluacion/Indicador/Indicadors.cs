using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Evaluacion
{
    public class Indicadors
    {
        public int IdIndicador { get; set; }
        public string Indicador { get; set; }
        public int Grado { get; set; }
        public int IdMateria { get; set; }
        public string Materia { get; set; }

        public Indicadors(int id)
        {
            DataTable table = util.ValoresEnTabla("Select * from Indicador where IdIndicador=" + id + " ;");

            foreach (DataRow field in table.Rows)
            {
                IdIndicador = Convert.ToInt32(field["IdIndicador"].ToString());
                Indicador = field["Indicador"].ToString();
                Grado = Convert.ToInt32(field["Grado"].ToString());
                IdMateria = Convert.ToInt32(field["IdMateria"].ToString());
                Materia = field["Materia"].ToString();
            }
        }

        public Indicadors()
        {
            IdIndicador = 0;
            Indicador = "";
            Grado = 0;
            IdMateria = 0;
            Materia = "";
        }

        public Indicadors(DataRow field)
        {
            IdIndicador = Convert.ToInt32(field["IdIndicador"].ToString());
            Indicador = field["Indicador"].ToString();
            Grado = Convert.ToInt32(field["Grado"].ToString());
            IdMateria = Convert.ToInt32(field["IdMateria"].ToString());
            Materia = field["Materia"].ToString();
        }

        public static List<Indicadors> LIndicador(int materia = 0)
        {
            string query = string.Format("exec slIndicador  @idmateria={0}", materia);
            DataTable data = db.db.GetValuesInDataTable(query);

            List<Indicadors> n = new List<Indicadors>();
            Indicadors m;
            foreach (DataRow item in data.Rows)
            {
                m = new Indicadors();
                m.IdIndicador = Convert.ToInt32(item["IdIndicador"].ToString());
                m.Materia = item["Materia"].ToString();
                m.Grado = Convert.ToInt32(item["Grado"].ToString());
                m.Indicador = item["Indicador"].ToString();

                n.Add(m);
            }

            return n;
        }


        public bool guardar()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CrudIndicador";
            cmd.Parameters.AddWithValue("@IdIndicador", IdIndicador);
            cmd.Parameters.AddWithValue("@Indicador", Indicador);
            cmd.Parameters.AddWithValue("@Grado", Grado);
            cmd.Parameters.AddWithValue("@IdMateria", IdMateria);
            cmd.Parameters.Add("@Retorno", SqlDbType.Int);
            cmd.Parameters["@Retorno"].Direction = ParameterDirection.Output; //se debe especificar que es output
            return util.GuardarYUsarId("@Retorno", ref cmd);

        }
    }

}
