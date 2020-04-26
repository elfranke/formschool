using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Evaluacion
{
    public class Usuarios: IDisposable
    {
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
        public bool Activo { get; set; }

        public static int id { get; private set; }
        public static int idempresa { get; private set; }
        public static string nombre { get; private set; }
        public Usuarios(int id)
        {
            DataTable table = util.ValoresEnTabla("Select * from Usuario where IdUsuario="+ id+ " ;");

            foreach (DataRow field in table.Rows)
            {
                IdUsuario = Convert.ToInt32(field["IdUsuario"].ToString());
                Usuario = field["Usuario"].ToString();
                Nombre = field["Nombre"].ToString();
                Pass = field["Pass"].ToString();
                Activo = Convert.ToBoolean(field["Activo"].ToString());
            }
        }


        public Usuarios()
        {
            IdUsuario = 0;
            Usuario = "";
            Nombre = "";
            Pass = "";
            Activo = false;
        }



        public static bool login(string nombre,string pass)
        {
            bool login = false;
            DataTable table = util.ValoresEnTabla(string.Format($"Select * from Usuario where Usuario='{nombre}' and Pass='{pass}';"));
            foreach (DataRow field in table.Rows)
            {
                id = Convert.ToInt32(field["IdUsuario"].ToString());
                nombre = field["Nombre"].ToString();
               // idempresa =Convert.ToInt32(field["IdEmpresa"].ToString());
            }
            if (id > 0)
            {
                login = true;
            }

            return login;
        }

        public bool guardar()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_GUsuario";
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Pass", Pass);
           // cmd.Parameters.AddWithValue("@IdEmpresa", IdEmpresa);
            cmd.Parameters.AddWithValue("@Activo", Activo);
            cmd.Parameters.Add("@Retorno", SqlDbType.Int);
            cmd.Parameters["@Retorno"].Direction = ParameterDirection.Output; //se debe especificar que es output
            return util.GuardarYUsarId("@Retorno", ref cmd);

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Usuarios() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            id = 0;
            idempresa = 0;
            nombre = "";
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

}
