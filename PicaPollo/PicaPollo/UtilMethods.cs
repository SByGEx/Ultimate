using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace PicaPollo
{
    public static class Utilities
    {
        public static float SumarColumna(this DataTable dt, String nombreColumna)
        {
            float total = 0.0f;

            foreach(DataRow r in dt.Rows)
            {
                total += r.Field<float>(nombreColumna);
            }

            return total;
        }

        public static String[] ColumnToArray(this DataTable dt, String nombreColumna)
        {
            String[] ara = new String[dt.Rows.Count];
            int counter = 0;

            foreach (DataRow r in dt.Rows)
            {
                ara[counter] = r.Field<string>(nombreColumna);
                counter++;
            }

            return ara;
        }

        public static int SearchRow<T>(this DataTable dt, String nombreColumna, T criteria)
        {
            int counter = 0;

            foreach(DataRow dr in dt.Rows)
            {
                if (dr.Field<T>(nombreColumna).Equals(criteria))
                    break;
                else
                    counter++;
            }

            return counter;
        }

        public static bool Existent<T>(this DataTable dt, String nombreColumna, T criteria)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.Field<T>(nombreColumna).Equals(criteria))
                {
                    return true;
                }
            }

            return false;
        }
    }
}