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
        public static float SumarColumnas(this DataGridView dt, String nombreColumna)
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
    }
}