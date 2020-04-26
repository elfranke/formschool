using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Evaluacion
{
    public class Estudiantes
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime Nacimiento { get; set; }
        public int Grado { get; set; }
        public int IdSeccion { get; set; }
        public string Direccion { get; set; }
        public string Seccion { get; set; }
        public List<Estudiantes> LEstudiante = new List<Estudiantes>();

        public Estudiantes(int id)
        {
            DataTable table = util.ValoresEnTabla("Select * from Estudiante where IdEstudiante=" + id + " order by nombre asc ;");

            foreach (DataRow field in table.Rows)
            {
                IdEstudiante = Convert.ToInt32(field["IdEstudiante"].ToString());
                Nombre = field["Nombre"].ToString();
                Apellidos = field["Apellidos"].ToString();
                Nacimiento = DateTime.Parse(field["Nacimiento"].ToString());
                Grado = Convert.ToInt32(field["Grado"].ToString());
                IdSeccion = Convert.ToInt32(field["IdSeccion"].ToString());
                Direccion = field["Direccion"].ToString();
                Seccion = field["Seccion"].ToString();
            }
        }

        public Estudiantes(DataRow field)
        {


                IdEstudiante = Convert.ToInt32(field["IdEstudiante"].ToString());
                Nombre = field["Nombre"].ToString();
                Apellidos = field["Apellidos"].ToString();
                Nacimiento = DateTime.Parse(field["Nacimiento"].ToString());
                Grado = Convert.ToInt32(field["Grado"].ToString());
                IdSeccion = Convert.ToInt32(field["IdSeccion"].ToString());
                Direccion = field["Direccion"].ToString();
                Seccion = field["Seccion"].ToString();
            
        }

        public Estudiantes()
        {
            IdEstudiante = 0;
            Nombre = "";
            Apellidos = "";
            Nacimiento = DateTime.Now;
            Grado = 0;
            IdSeccion = 0;
            Direccion = "";
            Seccion = "";
        }

        public void LlenarEst(int grado,int seccion)
        {
            DataTable table = util.ValoresEnTabla(string.Format($"Select * from Estudiante where Grado={grado} and IdSeccion={seccion} order by nombre asc"));

            Estudiantes est;


            foreach (DataRow field in table.Rows)
            {
                est = new Estudiantes();

                est.IdEstudiante = Convert.ToInt32(field["IdEstudiante"].ToString());
                est.Nombre = field["Nombre"].ToString();
                est.Apellidos = field["Apellidos"].ToString();
                est.Nacimiento = DateTime.Parse(field["Nacimiento"].ToString());
                est.Grado = Convert.ToInt32(field["Grado"].ToString());
                est.IdSeccion = Convert.ToInt32(field["IdSeccion"].ToString());
                est.Direccion = field["Direccion"].ToString();
                est.Seccion = field["Seccion"].ToString();

                LEstudiante.Add(est);
            }
        }

        public bool guardar()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "crudEstudiante";
            cmd.Parameters.AddWithValue("@IdEstudiante", IdEstudiante);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", Apellidos);
            cmd.Parameters.AddWithValue("@Nacimiento", Nacimiento.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@Grado", Grado);
            cmd.Parameters.AddWithValue("@IdSeccion", IdSeccion);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.Parameters.AddWithValue("@Seccion", Seccion);
            cmd.Parameters.Add("@Retorno", SqlDbType.Int);
            cmd.Parameters["@Retorno"].Direction = ParameterDirection.Output; //se debe especificar que es output
            return util.GuardarYUsarId("@Retorno", ref cmd);

        }
    }

}
