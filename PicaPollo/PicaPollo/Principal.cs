using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicaPollo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bSumarTodo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ClearForm<TextBox>();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarOQuitarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos neo = new Productos();
            neo.Show();
        }

        private void despacharMercancíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Despacho neo = new Despacho();
            neo.Show();
        }
    }

    public static class UtilityMethods
    {
        public static double SumarCeldas(this DataGridView dgvTemp, string columnName)
        {
            string temp;
            double counter = 0;

            foreach(DataGridViewRow dc in dgvTemp.Rows)
            {
                temp = (string) dc.Cells[columnName].Value;
                counter += Convert.ToDouble(temp);
            }
            

            return counter;
        }

        public static void ClearForm(this Form f)
        {
            f.ClearForm<ErrorProvider>();
        }

        public static void ClearForm<T>(this Form f)
        {
            foreach(Control c in f.Controls)
            {
                if(c is TextBox && (c.GetType() != typeof(T)))
                { 
                    TextBox t = c as TextBox;
                    t.Text = "";
                }
                if(c is MaskedTextBox && (c.GetType() != typeof(T)))
                {
                    MaskedTextBox t = c as MaskedTextBox;
                    t.Text = "";
                }
                if(c is RadioButton && (c.GetType() != typeof(T)))
                {
                    RadioButton t = c as RadioButton;
                    t.Text = "";
                }
                if(c is CheckBox && (c.GetType() != typeof(T)))
                {
                    CheckBox t = c as CheckBox;
                    t.Checked = false;
                }
                if(c is ComboBox && (c.GetType() != typeof(T)))
                {
                    ComboBox t = c as ComboBox;
                    t.SelectedItem = "";
                }
            }
        }
    }
}
