<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Proyecto_web_form_ARS.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <!-- contenedor  -->
<div class="row">
  <div class="side">
    <h2 style="color: #006699">ARS</h2>
    <h5 style="color: #0099FF">Academic Records System </h5>
    <div class="fakeimg" style="height:238px; text-align: center; width: 92%; background-color: #FFFFFF;">
        <asp:Image ID="Image1" runat="server" Height="218px" ImageUrl="~/Imagenes/ars.jpg" Width="267px" />
      </div>
    <p>Ars, esta creado para que funcione como un registro academico.</p>
    <h3>Contactos</h3>
    <p>Redes Sociales </p>
    <div class="fakeimg" style="height:113px; text-align: center; width: 90%; background-color: #FFFFFF;">
        <asp:Image ID="Image6" runat="server" Height="83px" ImageUrl="~/Imagenes/Logo-socijalne-mreze.png" Width="391px" />
      </div><br>
  
    
  </div>
  <div class="main">
    <h2 style="background-color: #40568D; color: #FFFFFF;">Registro de Estudiantes</h2>
    <div class="fakeimg" style="height:200px; text-align: center; background-color: #FFFFFF; width: 99%;">
        <asp:Image ID="Image3" runat="server" Height="203px" Width="314px" ImageUrl="~/Imagenes/libros-de-lectura-felices-del-muchacho-del-estudiante-en-biblioteca-56987489.jpg"  />
        <asp:Image ID="Image2" runat="server" Height="203px" ImageUrl="~/Imagenes/estuudiantes.jpg" Width="314px" />
      </div>
    <p><strong>Como funciona?</strong></p>
    <p style="width: 1036px">El registro de estudiante funciona con una base de datos en SQLserver, teniendo el registro de todos ellos y agregando un usuario y contraseña.</p>
    <br>
    <h2 style="background-color: #40568D; color: #FFFFFF;">Registro de Docentes</h2>
    <h5>&nbsp;</h5>
    <div class="fakeimg" style="height:200px; text-align: center; background-color: #FFFFFF;">
        <asp:Image ID="Image5" runat="server" Height="190px" Width="254px" ImageUrl="~/Imagenes/docente.jpg"/>
        <asp:Image ID="Image4" runat="server" Height="190px" Width="254px" ImageUrl="~/Imagenes/docentess.jpg" />
      </div >
    <p><strong>Como funciona?</strong></p>
    <p>El registro de docente funciona de la misma manera que el registro de estudiante, con una base de datos donde se almacenan todo los datos guardados&nbsp; con la opcion de modificar usuario y eliminar perfil.</p>
  </div>
</div>
<div class="footer">
    <h2>Creado por equipo 7 de programacion</h2>
</div>

</asp:Content>
