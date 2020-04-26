using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion.db
{
   public class db
    {
        public static string strconexion = @"Data Source=server;Initial Catalog=School; Persist Security Info=True; User ID=SalonAlba;Password=Salon360Ba";

        public static bool SaveSPIntValueReturn(string valretorno, ref SqlCommand cmd)
        {
            bool valor = false;
            SqlConnection conexion = new SqlConnection(strconexion);
            cmd.Connection = conexion;
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                if (cmd.Parameters[valretorno].Value != null)
                {
                    int v = 0;
                    int.TryParse(cmd.Parameters[valretorno].Value.ToString(), out v);
                    if (v > 0)
                        valor = true;
                }

            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode ==- 2146232060)
                {
                    MessageBox.Show("Use Otro Usuario");
                }
                else
                {
                    MessageBox.Show(ex.Message);

                }
                valor = false;
            }
            finally
            {
                conexion.Close();
                cmd.Dispose();
            }

            return valor;

        }
        public static DataTable GetValuesInDataTable(string Query, int time = 30)
        {
            DataTable ret = new DataTable();
            SqlConnection con= new SqlConnection(strconexion);


            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            adapter.SelectCommand.CommandTimeout = time;
            try
            {
                con.Open();
                adapter.Fill(ret);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                ret = new DataTable();
            }
            finally
            {
                adapter.Dispose();
                con.Close();
            }

            return ret;
        }

    }
}
