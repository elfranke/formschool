using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Evaluacion
{
    public class util
    {
        public static DataTable ValoresEnTabla(string v)
        {

            return db.db.GetValuesInDataTable(v);
        }

        internal static bool GuardarYUsarId(string v, ref SqlCommand cmd)
        {
          return  db.db.SaveSPIntValueReturn(v, ref cmd);
        }
        
        public static Form show(Form form,Form guest)
        {
            form.Hide();
            guest.ShowDialog();
            form.Show();
            return guest;
        }
        public static DataTable BusquedatLista(string criterio, string tabla, string filtro)
        {
            string busqueda = string.Format($"select * from {tabla} where {criterio}= '{filtro}'");
            return util.ValoresEnTabla(busqueda);
        }

        internal static object ValoresEnTabla(object p)
        {
            throw new NotImplementedException();
        }

        public void textBoxNumeric(TextBox box)
        {
            box.KeyPress += Box_KeyPress;
        }

        private void Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)||e.KeyChar==(char)Keys.Back ||e.KeyChar==(char)Keys.Delete)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        public void Umper(ref TextBox  tex)
        {
            tex.Text = tex.Text.ToUpper();
        }
        public static void LlenarCbo(ref ComboBox cbo, string tabla, string campo="",string filtro="",string group="",string sele="")
        {
            string filtros = "";
            string colums = "*";

            if (sele.Length>0)
            {
                colums =sele;
            }
            if(campo.Length>0)
            {
                filtros += string.Format($" where  {campo} {filtro} ");
            }

            DataTable data = util.ValoresEnTabla(string.Format($"select {colums} from {tabla} " +filtros+ group));
            cbo.DataSource = data;
            cbo.ValueMember = "Id"+tabla;
            cbo.DisplayMember =tabla;
        }
        public static void LlenarCbo(ref ComboBox cbo, string tabla, List<string> campo,List<string> filtro,string group="")
        {
            string filtros = "";
            if(campo.Count>0)
            {
           
                for (int i=0; campo.Count - 1>=i ;i++)
                {
                    if (i == 0) {

                        filtros += string.Format($" where  {campo[i]} {filtro[i]} ");

                    }
                    else
                    {
                        filtros += string.Format($" and  {campo[i]}  {filtro[i]} ");

                    }


                }                
            }

            DataTable data = util.ValoresEnTabla(string.Format($"select * from {tabla} " +filtros+group));
            cbo.DataSource = data;
            cbo.ValueMember = "Id"+tabla;
            cbo.DisplayMember =tabla;
        }
        public static ContextMenu contenmenu()
        {
            
            return new ContextMenu();
        }

        public static int Idperiodo()
        {

            int id = 0;
            switch (DateTime.Now.Month)
            {
                case 8:
                    id = 1;
                    break;
                case 9:
                case 10:
                    id = 2;
                    break;
                case 11:
                case 12:
                case 1:
                    id = 3;
                    break;
                case 2:
                case 3:
                    id = 4;
                    break;
                case 4:
                case 5:
                case 6:
                    id = 5;
                    break;

            }
            return id;
        }



    }
}