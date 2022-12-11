<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ayuda.aspx.cs" Inherits="Proyecto_web_form_ARS.Ayuda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
* {
  box-sizing: border-box;
}

input[type=text], select, textarea {
  width: 100%;
  padding: 12px;
  border: 1px solid #ccc;
  border-radius: 4px;
  resize: vertical;
}

label {
  padding: 12px 12px 12px 0;
  display: inline-block;
}

input[type=submit] {
  background-color: #04AA6D;
  color: white;
  padding: 12px 20px;
  border: none;
  border-radius: 4px;
  cursor: pointer;
  /*float: right;*/
}

input[type=submit]:hover {
  background-color: #45a049;
}

.container {
  border-radius: 5px;
  background-color: #CCD5F0;
  padding: 20px;
}

.col-25 {
  float: left;
  width: 25%;
  margin-top: 6px;
}

.col-75 {
  float: left;
  width: 75%;
  margin-top: 6px;
}

/* borrar */
.row:after {
  content: "";
  display: table;
  clear: both;
}

/* diseño cuando la pantalla */
@media screen and (max-width: 600px) {
  .col-25, .col-75, input[type=submit] {
    width: 100%;
    margin-top: 0;
  }
}
    .auto-style1 {
        text-align: center;
    }
    .auto-style2 {
        display: flex;
        flex-wrap: wrap;
        flex-direction: column;
        text-align: center;
    }
        .auto-style3 {
            float: left;
            width: 100%;
            text-align: center;
            margin-top: 0;
        }
    </style>
   
    <h2 class="auto-style1">Contactanos </h2>
<p class="auto-style1">Tu opinion es importante para nosotros.</p>

<div class="container">
  <form action="/action_page.php">
  <div class="row">
    <div class="auto-style3">
        <strong>Nombre
    </strong>
    </div>
    <div class="col-75">
      &nbsp;</div>
      <asp:TextBox ID="Texn" runat="server" Height="16px" Width="475px"></asp:TextBox>
  </div>
  <div class="row">
    <div class="auto-style3">
        <strong>Correo</strong>
    </div>
    <div class="col-75">
      &nbsp;<asp:TextBox ID="Texc" runat="server" Height="16px" Width="470px"></asp:TextBox>
    </div>
  </div>
  <div class="row">
    
    <div class="col-75">
      
    </div>
  </div>
  <div class="row">
    <div class="auto-style3">
        <strong>Mensaje</strong>
    </div>
    <div class="col-75">
      &nbsp;</div>
      <asp:TextBox ID="Texm" runat="server" Height="149px"></asp:TextBox>
      </div>
      <div class="auto-style2">
          <br />
          <br />
          <br />
          <asp:Button ID="enviar" runat="server" Text="Enviar" Height="42px" OnClick="Button1_Click" Width="123px" />
          <br />
&nbsp;</div>
  </form>
</div>




   



</asp:Content>
