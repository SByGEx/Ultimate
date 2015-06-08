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
        public DataTable empleados, productos;
        public SqlConnection conectaPica = new SqlConnection("Data Source=WIN-BP78IAALQQA\\SQLEXPRESS;Initial Catalog=PicaPollo;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Despacho()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            productos = new DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter(new SqlCommand("SELECT IDProd, NombreProducto, PrecioProducto FROM [Productos]", conectaPica));

            try
            {
                adapt.Fill(productos);
                gbFacturacion.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bAgregarCodigo_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = tbCodigo.Text.Trim();
            
            try
            {
                int item = Convert.ToInt32(tbCodigo.Text);

                if(productos.Existent<int>("IDProd", item))
                {
                    int indice = productos.SearchRow<int>("IDProd", item);

                    dgvFactura.Rows.Add(productos.Rows[indice].Field<int>("IDProd"), productos.Rows[indice].Field<string>("NombreProducto"),
                        productos.Rows[indice].Field<double>("PrecioProducto"), 1, productos.Rows[indice].Field<double>("PrecioProducto"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFactura_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tbTotal.Text = dgvFactura.SumarCeldas("Total").ToString("F2");
        }

        private void dgvFactura_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(dgvFactura.Rows[e.RowIndex].Cells["Precio"].Value);
                double cantidad = Convert.ToDouble(dgvFactura.Rows[e.RowIndex].Cells["Cantidad"].Value);
                dgvFactura.Rows[e.RowIndex].Cells["Total"].Value = precio * cantidad;
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvFactura_Validated(object sender, EventArgs e)
        {
            tbTotal.Text = dgvFactura.SumarCeldas("Total").ToString("F2");
        }

        private void dgvFactura_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            tbTotal.Text = dgvFactura.SumarCeldas("Total").ToString("F2");
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
