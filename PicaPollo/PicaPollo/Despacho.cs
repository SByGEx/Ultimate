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
    public partial class Despacho : Form
    {
        public DataTable empleados;
        public SqlConnection conectaPica = new SqlConnection("Data Source=WIN-BP78IAALQQA\\SQLEXPRESS;Initial Catalog=PicaPollo;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Despacho()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbFacturacion.Enabled = true;
        }

        private void Despacho_Load(object sender, EventArgs e)
        {
            empleados = new DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter(new SqlCommand("SELECT ID, Nombre, Apellido, Sexo, Cedula, FechaNacimiento FROM [Empleados]", conectaPica));

            try
            {
                adapt.Fill(empleados);
                cbCajero.Items.Clear();
                cbCajero.Items.AddRange(empleados.ColumnToArray("Nombre"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
