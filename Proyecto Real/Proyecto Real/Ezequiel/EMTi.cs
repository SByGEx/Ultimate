using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Proyecto_Real.Ezequiel
{
    public partial class EMTi : Form
    {
        public EMTi()
        {
            InitializeComponent();
            label1.Text = "Usted perdio y es raro";
        }

        private void rbR1_CheckedChanged(object sender, EventArgs e)
        {
            rbL1.Enabled = false;
            rbR1.Enabled = false;
            rbR11.Visible = true;
            rbR12.Visible = true;
        }

        private void lPlay_Click(object sender, EventArgs e)
        {
            label1.Text = "Usted es el ganador";
        }

        private void rbJugar_CheckedChanged(object sender, EventArgs e)
        {
            rbR1.Visible = true;
            rbL1.Visible = true;
            rbJugar.Enabled = false;
            lPlay.ForeColor = Color.LightGray;
        }

        private void rbL1_CheckedChanged(object sender, EventArgs e)
        {
            rbL1.Enabled = false;
            rbR1.Enabled = false;
            rbL11.Visible = true;
            rbL12.Visible = true;
        }

        private void rbL11_CheckedChanged(object sender, EventArgs e)
        {
            rbL11.Enabled = false;
            rbL12.Enabled = false;
            label1.Visible = true;
        }

        private void rbL12_CheckedChanged(object sender, EventArgs e)
        {
            rbL11.Enabled = false;
            rbL12.Enabled = false;
            label1.Visible = true;
        }

        private void rbR11_CheckedChanged(object sender, EventArgs e)
        {
            rbR11.Enabled = false;
            rbR12.Enabled = false;
            label1.Visible = true;
        }

        private void rbR12_CheckedChanged(object sender, EventArgs e)
        {
            rbR11.Enabled = false;
            rbR12.Enabled = false;
            label1.Visible = true;
        }
    }
}
