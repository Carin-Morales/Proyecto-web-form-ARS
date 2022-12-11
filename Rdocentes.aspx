<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rdocentes.aspx.cs" Inherits="Proyecto_web_form_ARS.Rdocentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="text-align: justify; background-color: #CCD5F0;">
        <div style="text-align: center">
        <br />
        </div>
        <h1 style="text-align: center"><span style="font-family: 'Microsoft Sans Serif'; color: #FFFFFF">Registro de Docentes
        </span></h1>
        <asp:TextBox ID="Lblmensaje" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table style="border-style: solid; border-width: 1px; background-color: #DDDDDD; height: 323px; width: 881px;" class="col-s-12">
            <tr>
                <td style="width: 405px; height: 22px; background-color: #336699; color: #40568D;"><span style="color: #FFFFFF">Informacion Personal </span> </td>
                <td style="width: 405px; height: 22px; background-color: #336699; color: #40568D;">I<span style="color: #FFFFFF">nformacion Academica</span></td>
            </tr>
            <tr>
                <td style="width: 405px; height: 22px;">Nombre
                    <asp:TextBox ID="Txnombre" runat="server" Width="284px"></asp:TextBox>
                </td>
                <td style="height: 22px">Profecion&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txp" runat="server" Width="188px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 405px; height: 22px;">Dui&nbsp;
                    <asp:TextBox ID="Txdui" runat="server" style="margin-left: 29px" Width="168px"></asp:TextBox>
                </td>
                <td style="height: 22px; ">Area&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:TextBox ID="Txa" runat="server" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 405px; height: 22px; ">Fecha de nacimiento<asp:TextBox ID="txfecha" runat="server" style="margin-left: 29px" Width="144px"></asp:TextBox>
                </td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td style="width: 405px; height: 29px;">Direccion<asp:TextBox ID="Txdireccion" runat="server" style="margin-left: 29px" Width="226px"></asp:TextBox>
                </td>
                <td style="height: 29px"></td>
            </tr>
            <tr>
                <td style="width: 405px; ">Telefono<asp:TextBox ID="Txtelefono" runat="server" style="margin-left: 29px" Width="233px"></asp:TextBox>
                </td>
                <td style="width: 405px; height: 22px; background-color: #336699; color: #40568D;"><span style="color: #FFFFFF">Creacion de Usuario</span></td>
            </tr>
            <tr>
                <td style="width: 405px; height: 22px;">Correo&nbsp;&nbsp;
                    <asp:TextBox ID="Txcorreo" runat="server" style="margin-left: 29px" Width="239px"></asp:TextBox>
                </td>
                <td style="height: 22px; ">Usuario&nbsp;&nbsp;
                    <asp:TextBox ID="Txusuario" runat="server" style="margin-left: 29px" Width="147px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 405px; height: 22px;"></td>
                <td style="height: 22px">Contraseña<asp:TextBox ID="Txc" runat="server" style="margin-left: 29px" Width="149px"></asp:TextBox>
&nbsp; </td>
            </tr>
            <tr>
                <td style="width: 405px; height: 22px;"></td>
                <td style="height: 22px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 405px; height: 30px;">
                    
                </td>
                <td style="height: 30px">
                    
                </td>
            </tr>
        </table>
        <div style="text-align: center">
            <br />
            <br />
&nbsp;&nbsp;
            <strong>
            <asp:Button ID="btguardar" runat="server" Height="41px" Text="Guardar" Width="161px" style="background-color: #40568D; color: #FFFFFF; font-weight: bold;" OnClick="btguardar_Click" />
            </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <strong>
            <asp:Button ID="btnuevo" runat="server" Height="38px" Text="Nuevo" Width="145px" style="background-color: #40568D; color: #FFFFFF; font-weight: bold;" OnClick="btnuevo_Click" />
            </strong>
        <br />
        <br />
        <br />
        </div>
    </div>

</asp:Content>
