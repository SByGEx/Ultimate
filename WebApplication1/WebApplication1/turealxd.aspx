<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="turealxd.aspx.cs" Inherits="la_pagina_de_la_iglesia.turealxd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css" type="text/css" />
    <style type="text/css">
        #form1 {
            height: 939px;
        }
    </style>
</head>
<body style="background-color:aqua; background-image:url(back.jpg); background-attachment:fixed; " >
    <div >
       <img src="delvytoolbar.jpg"  style="margin-left:200px;width: 993px; height: 161px" />
        
    </div>
  <div id="divBody" style="background-color: #FFFFFF">
        <nav>
        <ul>
            <li> <a href="#" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; color: #FFFFFF; height: 30px;">Inicio </a> </li>
            <li style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 21px; color: #FFFFFF; height: 44px;"> <a href="#" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; color: #FFFFFF; height: 30px;">Ver Historia </a> </li>
            <li style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 21px; color: #FFFFFF; height: 52px;"> <a href="#" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; color: #FFFFFF; height: 30px;">Centro infantil </a> </li>
            <li style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 21px; color: #FFFFFF; height: 45px;"> <a href="#" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; color: #FFFFFF; height: 30px;">Contactos </a> </li>
            <li>
                <a href="#" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; color: #FFFFFF; height: 30px;">Actividades </a>
                <ul>
                    <li> <a href="Calendario.aspx" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; color: #FFFFFF"> Calendario </a> </li>
                    <li> <a href="Miembro.aspx" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; color: #FFFFFF">Miembros (0.1v) </a> </li>
                    <li><a href="#" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; color: #FFFFFF"> Opcion3 </a> </li>
                </ul>
            </li>
        </ul>
    </nav>
      
      <a href="#" id="sign" > Sign-in </a>
      <a href="#" style="margin-left:930px"> Sign-out </a>
    <!--<form id="form1"  runat="server" style="background-color: #CCCCFF">
        <asp:HyperLink ID="HyperLink1" runat="server">Sign-in</asp:HyperLink>
    </form>-->
         <img id="imagenes" src="startof.jpg" style="height: 256px; width: 985px"  />
    
      <hr />
         </div>

</body>
</html>
