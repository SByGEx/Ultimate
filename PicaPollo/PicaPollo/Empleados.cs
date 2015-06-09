using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PicaPollo
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        SqlConnection conec = new SqlConnection("Data Source=WIN-BP78IAALQQA\\SQLEXPRESS;Initial Catalog=PicaPollo;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void button1_Click(object sender, EventArgs e)
        {

            string Sexo = "";

            if(tbNombre.Text.Length >= 1)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(tbNombre, "Debe introdusir el nombre de la persona");
            }

            if (tbApellido.TextLength >= 2)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(tbApellido, "Debe introdusir el apellido de la persona");
            }

            if (tbCelula.TextLength >= 10)
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(tbApellido, "Debe introdusir la cedula de la persona");
            }

            if(radioButton3.Checked || rbMasculino.Checked || rbFemenimo.Checked)
            {
                errorProvider4.Clear();
            }
            else
            {
                errorProvider4.SetError(rbFemenimo, "Debe seleccionar una de las opciones");
            }

            if (rbFemenimo.Checked)
                Sexo = "F";
            else if (rbMasculino.Checked)
                Sexo = "M";
            else if (radioButton3.Checked)
                Sexo = "N";

            try
            {

                if (tbNombre.Text.Length >= 1 && radioButton3.Checked || rbMasculino.Checked || rbFemenimo.Checked && tbCelula.TextLength >= 10 && tbApellido.TextLength >= 2)
                {
                    conec.Open();
                    SqlCommand coman = new SqlCommand(string.Format("INSERT INTO Empleados (Nombre,Apellido,Sexo,FechaNacimineto,cedula) VALUES ('{0}','{1}','{2}',CONVERT(VARCHAR,'{3}',103),'{4}')", tbNombre.Text, tbApellido.Text, Sexo, dateTimePicker1.Value.ToString(),tbCelula.Text),conec);

                }
            }
            catch
            {
                MessageBox.Show("Ha fallado la coneccion", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conec.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista_de_empleados otro = new Lista_de_empleados();
            otro.ShowDialog();                                 
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }
    }
}
