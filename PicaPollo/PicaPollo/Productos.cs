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
    public partial class Productos : Form
    {
        public SqlConnection conectaPica = new SqlConnection("Data Source=WIN-BP78IAALQQA\\SQLEXPRESS;Initial Catalog=PicaPollo;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public DataTable dataTemp;

        public Productos()
        {
            InitializeComponent();
        }

        private void CargarProductos()
        {
            dataTemp = new DataTable();

            SqlCommand select = new SqlCommand("SELECT [IDProd],[NombreProducto],[PrecioProducto] FROM Productos ", conectaPica);

            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = select;

            try
            {
                adaptador.Fill(dataTemp);
                dgvProductos.DataSource = dataTemp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataTemp.Dispose();
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombreProd.Text.Length == 0)
            {
                MessageBox.Show("Debe especificar el nombre del producto");
                return;
            }

            if (tbNombreProd.Text.Length == 0)
            {
                MessageBox.Show("Debe especificar el precio del producto");
                return;
            }

            SqlCommand insert = new SqlCommand(String.Format("INSERT INTO [Productos] (NombreProducto,PrecioProducto) VALUES ('{0}',{1})", tbNombreProd.Text, tbPrecio.Text), conectaPica);

            try
            {
                conectaPica.Open();
                insert.ExecuteNonQuery();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectaPica.Close();
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow.Index > 0)
            {
                SqlCommand delete = new SqlCommand(String.Format("DELETE FROM [Productos] WHERE IDProd={0}", dgvProductos.CurrentRow.Cells[0].Value.ToString()), conectaPica);

                try
                {
                    conectaPica.Open();
                    delete.ExecuteNonQuery();
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conectaPica.Close();
                }
            }
            else
                return;
        }
    }
}
