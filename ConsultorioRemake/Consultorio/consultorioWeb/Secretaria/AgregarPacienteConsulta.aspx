<%@ Page Title="" Language="C#" MasterPageFile="~/Secretaria/Secretaria.Master" AutoEventWireup="true"
    CodeBehind="AgregarPacienteConsulta.aspx.cs" Inherits="consultorioWeb.Secretaria.AgregarPacienteConsulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style5
        {
            width: 274px;
        }
        .style8
        {
            width: 89px;
        }
        .style9
        {
            width: 77px;
        }
        .style10
        {
            width: 207px;
        }
        .style12
        {
            width: 420px;
        }
        .style13
        {
            width: 378px;
        }
        .style14
        {
            width: 216px;
        }
        .style15
        {
            width: 400px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="style12">
                &nbsp;
            </td>
            <td class="style8">
                <img src="/Imagen/logoGobierno.png" alt="ministerio de la salud" />
            </td>
            <td class="style13">
                &nbsp;
                <asp:Label ID="Label1" runat="server" Text="REGISTRO PACIENTE"></asp:Label>
            </td>
            <td class="style10">
                &nbsp;
            </td>
            <td class="style5">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp; <a href="PanelConsultaS.aspx" style="font-size: xx-large; font-weight: 700">&lt;Volver</a>
            </td>
            <td class="style8">
                Rut Paciente
            </td>
            <td class="style13">
                &nbsp;<asp:TextBox ID="txt_Rut" TextMode="Number" runat="server" Width="100px"></asp:TextBox>-<asp:TextBox
                    ID="txt_dv" runat="server" MaxLength="1" Width="35px"></asp:TextBox>
                <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" OnClick="btn_Buscar_Click" />
            </td>
            <td class="style10">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Ingrese Rut"
                    ForeColor="Red" ControlToValidate="txt_Rut"></asp:RequiredFieldValidator><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_dv"
                    ForeColor="Red" ErrorMessage="*Ingrese Dv"></asp:RequiredFieldValidator>
            </td>
            <td class="style5">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;
            </td>
            <td class="style8">
                <asp:Label ID="lblRespuesta" runat="server" ForeColor="Red" Text=""></asp:Label>
            </td>
            <td class="style13">
                <asp:TextBox ID="txtArea" TextMode="MultiLine" runat="server" Height="151px" Width="188px"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" Text="Agregar" />
            </td>
            <td class="style10">
                &nbsp;
            </td>
            <td class="style5">
                &nbsp;
            </td>
        </tr>
    </table>
    <table id="tabla1">
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                &nbsp;
            </td>
            <td class="style14">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                N° ficha
            </td>
            <td class="style14">
                <asp:Label ID="ln" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Nombre:
            </td>
            <td class="style14">
                <asp:Label ID="lnombre" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Fecha Nacimiento:
            </td>
            <td class="style14">
                <asp:Label ID="lfecha" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Edad:
            </td>
            <td class="style14">
                <asp:Label ID="ledad" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Genero:
            </td>
            <td class="style14">
                <asp:Label ID="lGenero" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Nacionalidad:
            </td>
            <td class="style14">
                <asp:Label ID="lNacionalidad" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Domicilio:
            </td>
            <td class="style14">
                <asp:Label ID="lDomicilio" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Comuna:
            </td>
            <td class="style14">
                <asp:Label ID="lComuna" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Sector:
            </td>
            <td class="style14">
                <asp:Label ID="lSector" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Fono1
            </td>
            <td class="style14">
                <asp:Label ID="lf1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Fono 2
            </td>
            <td class="style14">
                <asp:Label ID="lf2" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Grupo Sanguineo
            </td>
            <td class="style14">
                <asp:Label ID="lGrupoS" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                Rh
            </td>
            <td class="style14">
                <asp:Label ID="lRsan" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                &nbsp;
            </td>
            <td class="style14">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                &nbsp;
            </td>
            <td class="style14">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;
            </td>
            <td class="style9">
                &nbsp;
            </td>
            <td class="style14">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    <br />
    <br />
</asp:Content>
