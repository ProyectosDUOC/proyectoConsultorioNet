<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/Medico.Master" AutoEventWireup="true" CodeBehind="LicenciaMedica.aspx.cs" Inherits="consultorioWeb.Medico.LicenciaMedica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
                <center>
                    <asp:Label ID="Label3" runat="server" Text="Licencia Medica"></asp:Label>
                </center>
            </div>
            <table style="width:100%;">
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label1" runat="server" Text="Medico:"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="295px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="ID"></asp:Label>
                        &nbsp;:
                        <asp:Label ID="Label5" runat="server" Text="numero de la licencia"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label2" runat="server" Text="Nombre Paciente:"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="291px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Fecha: "></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label7" runat="server" Text="Descripcion"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox3" runat="server" Height="109px" Width="293px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="style4">
                        <center>
                            <asp:Button ID="Button1" runat="server" Text="Guardar" Width="169px" onclick="Button1_Click" />
                        </center>
                    </td>
                    <td>
                        <center>
                            <asp:Button ID="Button2" runat="server" Text="Imprimir" Width="198px" />
                        </center>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                    <td &nbsp;</td>
                </tr>
            </table>
</asp:Content>
