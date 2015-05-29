using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace la_pagina_de_la_iglesia
{
    public partial class Miembro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder temp = new StringBuilder();
            temp.AppendFormat("{0} ", tbNombre.Text);
            temp.AppendFormat("{0} ", tbApellido.Text);
            temp.AppendFormat("{0} ", tbTelefono.Text);

            if (rbMasculino.Checked)
                temp.Append("Masculino");
            else
                temp.Append("Femenino");

            Label5.Text = temp.ToString();
        }
    }
}