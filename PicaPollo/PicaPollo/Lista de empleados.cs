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
    public partial class Lista_de_empleados : Form
    {
        public Lista_de_empleados()
        {
            InitializeComponent();
        }
        SqlConnection conec = new SqlConnection("Data Source=WIN-BP78IAALQQA\\SQLEXPRESS;Initial Catalog=PicaPollo;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        DataTable data = new DataTable();

        private void Lista_de_empleados_Load(object sender, EventArgs e)
        {
            SqlDataAdapter add = new SqlDataAdapter();
            add = new SqlDataAdapter("SELECT Nombre, Apellido,Sexo,FechaNacimiento,Cedula FROM Empleados", conec);
            add.Fill(data);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = data;
            this.Height = 340;
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DialogResult re =  MessageBox.Show("Desea eliminar el empleado seleccionado", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch(re)
            {
                case DialogResult.Yes:
                    try
                    {
                        conec.Open();
                        SqlCommand conamd = new SqlCommand(string.Format("DELETE FROM Empleados WHERE Nombre = '{0}' AND Apellido = '{1}'", dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString()), conec);
                        conec.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Fallo al eliminar el emplado", "", MessageBoxButtons.OK);
                    }

                    break;

                        
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Height = 540;

            tbNombre.DataBindings.Clear();
            tbApellido.DataBindings.Clear();
            tbCelula.DataBindings.Clear();


            tbNombre.DataBindings.Add("Text", data, "Nombre", false, DataSourceUpdateMode.Never);
            tbApellido.DataBindings.Add("Text", data, "Nombre", false, DataSourceUpdateMode.Never);
            tbCelula.DataBindings.Add("Text", data, "Nombre", false, DataSourceUpdateMode.Never);

            if (dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString() == "M")
            {
                rbMasculino.Checked = true;
            }
            if (dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString() == "F")
            {
                rbFemenimo.Checked = true;
            }
            if (dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString() == "N")
            {
                radioButton3.Checked = true;
            }

            tbNombre.Visible = true;
            tbApellido.Visible = true;
            tbCelula.Visible = true;
            rbFemenimo.Visible = true;
            rbMasculino.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button4.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter add = new SqlDataAdapter();
            add = new SqlDataAdapter("SELECT Nombre, Apellido,Sexo,FechaNacimiento,Cedula FROM Empleados", conec);
            data.Clear();
            add.Fill(data);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = data;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string Sexo = "";

            if (tbNombre.Text.Length >= 1)
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

            if (radioButton3.Checked || rbMasculino.Checked || rbFemenimo.Checked)
            {
                errorProvider4.Clear();
            }
            else
            {
                errorProvider4.SetError(rbFemenimo, "Debe seleccionar una de las obciones");
            }

            if (rbFemenimo.Checked)
                Sexo = "F";
            else if (rbMasculino.Checked)
                Sexo = "M";
            else if (radioButton3.Checked)
                Sexo = "N";

            DialogResult re = MessageBox.Show("Editar asegurece de aver puesto la fecha","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            switch(re)
            {
                case DialogResult.Yes:
                    try
                    {
                        if (tbNombre.Text.Length >= 1 && (radioButton3.Checked || rbMasculino.Checked || rbFemenimo.Checked) && tbCelula.TextLength >= 10 && tbApellido.TextLength >= 2)
                        {
                            conec.Open();
                            SqlCommand comand = new SqlCommand(string.Format("UPDATE Empleados WHERE Cedula = '{0}' SET Nombre = '{1}', Apellido = '{2}',Sexo ='{3}',FechaNacimiento = CONVERT(VARCHAR,'{4}',103),Cedula = '{5}' ", dataGridView1.CurrentRow.Cells["Cedula"], tbNombre.Text, tbApellido.Text, Sexo, dateTimePicker1.Value.ToString(), tbCelula.Text), conec);
                            conec.Close();
                        }
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Error al editar", "", MessageBoxButtons.OK);
                    }
                    break;
            }


            tbNombre.Visible = false;
            tbApellido.Visible = false;
            tbCelula.Visible = false;
            rbFemenimo.Visible = false;
            rbMasculino.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button4.Visible = false;
            groupBox1.Visible = false;
            button2.Enabled = false;
            groupBox2.Visible = false;
            this.Height = 340;
        }
    }
}
