<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Miembro.aspx.cs" Inherits="la_pagina_de_la_iglesia.Miembro" %>

<!DOCTYPE html>

<style>
   
</style>

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
            <asp:TextBox ID="tbNombre" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Introduzca sus apellidos"></asp:Label>
        <br />
        <asp:TextBox ID="tbApellido" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Introduzca su teléfono"></asp:Label>
        <br />
        <asp:TextBox ID="tbTelefono" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label>
        <br />
        <asp:RadioButton ID="rbMasculino" Text="Masculino" runat="server" />
        <p>
            <asp:RadioButton ID="rbFemenino" Text="Femenino" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#003399" BorderColor="Black" OnClick="Button1_Click" Text="Agregar" />
        </p>
    </form>
</body>
</html>
