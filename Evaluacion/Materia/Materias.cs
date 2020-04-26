using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Evaluacion
{
    public class Materias
    {
        public int IdMateria { get; set; }
        public string Materia { get; set; }
        public int Grado { get; set; }
        public int IdUsuario { get; set; }

        public Materias(int id)
        {
            DataTable table = util.ValoresEnTabla("Select * from Materia where IdMateria=" + id + " ;");

            foreach (DataRow field in table.Rows)
            {
                IdMateria = Convert.ToInt32(field["IdMateria"].ToString());
                Materia = field["Materia"].ToString();
                Grado = Convert.ToInt32(field["Grado"].ToString());
                IdUsuario = Convert.ToInt32(field["IdUsuario"].ToString());
            }
        }

        public Materias(DataRow field)
        {
                IdMateria = Convert.ToInt32(field["IdMateria"].ToString());
                Materia = field["Materia"].ToString();
                Grado = Convert.ToInt32(field["Grado"].ToString());
                IdUsuario = Convert.ToInt32(field["IdUsuario"].ToString());
        }

        public Materias()
        {
            IdMateria = 0;
            Materia = "";
            Grado = 0;
            IdUsuario = 0;
        }

        public static List<Materias> LMateria(int grado = 0, int usuario = 0)
        {
            string query = string.Format("exec slMateria @grado={0}, @idusuario={1}", grado, usuario);
            DataTable data = db.db.GetValuesInDataTable(query);

            List<Materias> n = new List<Materias>();
            Materias m;
            foreach (DataRow item in data.Rows)
            {
                m = new Materias();
                m.IdMateria = Convert.ToInt32(item["IdMateria"].ToString());
                m.Materia = item["Materia"].ToString();
                m.Grado = grado;
                n.Add(m);
            }

            return n;
        }

        public bool guardar()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CrudMateria";
            cmd.Parameters.AddWithValue("@IdMateria", IdMateria);
            cmd.Parameters.AddWithValue("@Materia", Materia);
            cmd.Parameters.AddWithValue("@Grado", Grado);
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            cmd.Parameters.Add("@Retorno", SqlDbType.Int);
            cmd.Parameters["@Retorno"].Direction = ParameterDirection.Output; //se debe especificar que es output
            return util.GuardarYUsarId("@Retorno", ref cmd);

        }
    }

}
