using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Real.delvy
{
    public partial class Delvy : Form
    {
        public Delvy()
        {
            InitializeComponent();
        }

        private void Delvy_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(); 
            richTextBox1.Font = fontDialog1.Font;
        }
    }
}
