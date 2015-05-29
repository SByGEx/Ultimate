<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Miembro.aspx.cs" Inherits="la_pagina_de_la_iglesia.Miembro" %>

<!DOCTYPE html>

<link rel="stylesheet" href="StyleSheet1.css" type="text/css"/>

<html xmlns="http://www.w3.org/1999/xhtml">

    
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Miembro" runat="server">

    <hgroup>
        <h1>Agregar Miembros</h1>
        <h2>Introduzca sus datos al formulario</h2>
    </hgroup>

    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Introduzca su nombre"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Introduzca sus apellidos"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Introduzca su teléfono"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label>
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <p>
            <asp:RadioButton ID="RadioButton2" runat="server" />
        </p>
    </form>
</body>
</html>
