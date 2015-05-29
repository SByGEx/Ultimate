<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="la_pagina_de_la_iglesia.Calendario"/ %>--%>

<!DOCTYPE html>

<style>
    h1 {color:darkblue}   
    h2 {color:salmon}
    h3 {color:blue;background-color:white;}
    h4 {color:cornflowerblue;}
    *{
        font-family:'Segoe UI';
    }
    article
    {
        background-image:url("article.jpg");
    }
    p {color: red}

</style>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Calendario</title>
</head>


<body>

    <img src="startof.jpg" />

    <hgroup>
        <h1>Calendario de actividades </h1>
        <h2>A continuación podemos ver el calendario de actividades</h2>
    </hgroup>

    <form id="form1" runat="server">
    <div>
    
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <br />
        A continuación las actividades que tenemos para Mayo.<br />
        <br />

    <article>
        <hgroup>
            <h3>05/05/2015</h3>
            <h4>Actividad en las matas de Santa Cruz</h4>
        </hgroup>
        <p>Tendremos una actividad para seguir trabajando con el crecimiento de nuestros hermanos en la nueva congregación en Las Matas de Santa Cruz</p>

    </article>

    <article>
        <hgroup>
            <h3>14/05/2015</h3>
            <h4>Culto en el Caimito</h4>
        </hgroup>
        <p>Esperamos en el señor llevar el evangelio y gozarnos con nuestros hermanos en el Caimito</p>

    </article>

    <article>
        <hgroup>
            <h3>20/05/2015</h3>
            <h4>Estudio Bíblico</h4>
        </hgroup>
        <p>El martes, como hemos acostumbrado tendremos nuestro usual estudio bíblico</p>

    </article>
    
    </div>
    </form>

</body>
</html>
