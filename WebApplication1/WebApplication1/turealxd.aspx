<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="turealxd.aspx.cs" Inherits="la_pagina_de_la_iglesia.turealxd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css" type="text/css" />
    <script src="sliderengine/jquery.js"></script>
    <script src="sliderengine/amazingslider.js"></script>
    <link rel="stylesheet" type="text/css" href="sliderengine/amazingslider-0.css"/>
    <script src="sliderengine/initslider-0.js"></script>
      
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
      <div id="amazingslider-wrapper-0" style="display:block;position:relative;max-width:900px;margin:90px auto 56px;">
        <div id="amazingslider-0" style="display:block;position:relative;margin:0 auto;">
            <ul class="amazingslider-slides" style="display:none;">
                <li><a href="http://localhost:49650/turealxd.aspx" target="_blank"><img src="images/BIBLIA-1.jpg" alt="BIBLIA-1" data-duration="5000" /></a>
                </li>
                <li><img src="images/976083_74231444.jpg" alt="976083_74231444" />
                </li>
                <li><img src="images/recomendaciones.jpg" alt="recomendaciones" />
                </li>
            </ul>
            <ul class="amazingslider-thumbnails" style="display:none;">
                <li><img src="images/BIBLIA-1-tn.jpg" alt="BIBLIA-1" /></li>
                <li><img src="images/976083_74231444-tn.jpg" alt="976083_74231444" /></li>
                <li><img src="images/recomendaciones-tn.jpg" alt="recomendaciones" /></li>
            </ul>
        <div class="amazingslider-engine"><a href="http://amazingslider.com" title="JavaScript Slideshow">JavaScript Slideshow</a></div>
        </div>
    </div>
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
