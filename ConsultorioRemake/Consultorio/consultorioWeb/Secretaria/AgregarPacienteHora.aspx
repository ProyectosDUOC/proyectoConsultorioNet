<%@ Page Title="" Language="C#" MasterPageFile="~/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="AgregarPacienteHora.aspx.cs" Inherits="consultorioWeb.Secretaria.AgregarPacienteHora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>


        </div>
        <table style="width: 100%;">
            <tr>
                <td class="style2">
                    <img src="../Imagen/logoGobierno.png" alt="ministerio de la salud" />
                </td>
                <td class="style5">
                    &nbsp;
                    <asp:Label ID="Label1" runat="server" Text="REGISTRO PACIENTE"></asp:Label>
                </td>
                <td>
                    &nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Atras" Width="80px" onclick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Rut Paciente</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    -
                    <asp:TextBox ID="TextBox2" runat="server" Width="48px"></asp:TextBox>
                </td>
                <td class="style1">
                    &nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Buscar" />
                </td>

            </tr>
            <tr>
                <td class="style3">
                    Motivo</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="style1">
                    &nbsp;
                </td>

            </tr>
            <tr>
                <td>

                    <asp:Button ID="Button3" runat="server" Text="Agregar" onclick="Button3_Click" />

                </td>
            </tr>
        </table>
</asp:Content>
