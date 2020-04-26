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
    public class Evaluacions
    {
        public int IdEvaluacion { get; set; }
        public int IdEstudiante { get; set; }
        public string Estudiante { get; set; }
        public int IdSeccion { get; set; }
        public int IdIndicador { get; set; }
        public string Indicador { get; set; }
        public int IdMateria { get; set; }
        public string Materia { get; set; }
        public int IdPeriodo { get; set; }
        public string Periodo { get; set; }
        public int Grado { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public decimal Evaluacion { get; set; }

        public List<Evaluacions> levaluacions { get; set; }
        public Evaluacions(int id)
        {
            DataTable table = util.ValoresEnTabla("Select * from Evaluacion where IdEvaluacion=" + id + " ;");

            foreach (DataRow field in table.Rows)
            {
                IdEvaluacion = Convert.ToInt32(field["IdEvaluacion"].ToString());
                IdEstudiante = Convert.ToInt32(field["IdEstudiante"].ToString());
                Estudiante = field["Estudiante"].ToString();
                IdSeccion = Convert.ToInt32(field["IdSeccion"].ToString());
                IdIndicador = Convert.ToInt32(field["IdIndicador"].ToString());
                Indicador = field["Indicador"].ToString();
                IdMateria = Convert.ToInt32(field["IdMateria"].ToString());
                Materia = field["Materia"].ToString();
                IdPeriodo = Convert.ToInt32(field["IdPeriodo"].ToString());
                Periodo = field["Periodo"].ToString();
                Grado = Convert.ToInt32(field["Grado"].ToString());
                Descripcion = field["Descripcion"].ToString();
                Fecha = DateTime.Parse(field["Fecha"].ToString());
                IdUsuario = Convert.ToInt32(field["IdUsuario"].ToString());
                Evaluacion = Convert.ToDecimal(field["Evaluacion"].ToString());
            }
        }

        public Evaluacions()
        {
            IdEvaluacion = 0;
            IdEstudiante = 0;
            Estudiante = "";
            IdSeccion = 0;
            IdIndicador = 0;
            Indicador = "";
            IdMateria = 0;
            Materia = "";
            IdPeriodo = 0;
            Periodo = "";
            Grado = 0;
            Descripcion = "";
            Fecha = DateTime.Now;
            IdUsuario = 0;
            Evaluacion = 0;
        }

        public void LlenarList(List<Estudiantes> estudiantes, string stmateria, int idmateria, string periodo)
        {
            Evaluacions est;
            levaluacions = new List<Evaluacions>();

            foreach (Estudiantes field in estudiantes)
            {
                est = new Evaluacions();

                est.IdEvaluacion = 0;
                est.Materia = stmateria;
                est.Periodo = periodo;
                est.IdMateria = idmateria;
                est.Descripcion = "";
                est.IdUsuario = Usuarios.id;
                est.IdEstudiante = field.IdEstudiante;
                est.Estudiante = field.Nombre + " " + field.Apellidos;
                est.Grado = field.Grado;
                est.IdSeccion = field.IdSeccion;
                est.IdPeriodo = util.Idperiodo();
                est.Fecha = DateTime.Now;
                est.Evaluacion = 0;
                est.IdEstudiante = field.IdEstudiante;


                levaluacions.Add(est);
            }
        }

        public static void llenarIndicadorEvaluado (ref ComboBox cbo,string idmateria,string idestudiante)
        {
            try
            {
                string qr = $"select IdIndicador,Indicador from Evaluacion where IdMateria={idmateria} and IdEstudiante={idestudiante} group by IdIndicador,Indicador";
                DataTable data = util.ValoresEnTabla(qr);
                cbo.ValueMember = "IdIndicador";
                cbo.DisplayMember = "Indicador";
                cbo.DataSource = data;
            }
            catch (Exception)
            {

            }

        }
            



        public bool guardar()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_GEvaluacion";
            cmd.Parameters.AddWithValue("@IdEvaluacion", IdEvaluacion);
            cmd.Parameters.AddWithValue("@IdEstudiante", IdEstudiante);
            cmd.Parameters.AddWithValue("@Estudiante", Estudiante);
            cmd.Parameters.AddWithValue("@IdSeccion", IdSeccion);
            cmd.Parameters.AddWithValue("@IdIndicador", IdIndicador);
            cmd.Parameters.AddWithValue("@Indicador", Indicador);
            cmd.Parameters.AddWithValue("@IdMateria", IdMateria);
            cmd.Parameters.AddWithValue("@Materia", Materia);
            cmd.Parameters.AddWithValue("@IdPeriodo", IdPeriodo);
            cmd.Parameters.AddWithValue("@Periodo", Periodo);
            cmd.Parameters.AddWithValue("@Grado", Grado);
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            cmd.Parameters.AddWithValue("@Evaluacion", Evaluacion);
            cmd.Parameters.Add("@Retorno", SqlDbType.Int);
            cmd.Parameters["@Retorno"].Direction = ParameterDirection.Output; //se debe especificar que es output
            return util.GuardarYUsarId("@Retorno", ref cmd);

        }
    }

}
