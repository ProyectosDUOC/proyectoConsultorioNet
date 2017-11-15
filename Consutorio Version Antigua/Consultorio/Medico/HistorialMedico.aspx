<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/Medico.Master" AutoEventWireup="true" CodeBehind="HistorialMedico.aspx.cs" Inherits="Consultorio.Medico.HistorialMedico" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
            .style1 {
                width: 64px;
            }

            .style2 {
                width: 336px;
            }
        </style>
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">        
            <div>
                <center>
                    <asp:Label ID="Label3" runat="server" Text="Historial Medico"></asp:Label>
                </center>
            </div>
            <table style="width:100%;">
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label1" runat="server" Text="Rut:"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="191px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="191px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style1">
                        &nbsp;</td>
                    <td class="style2">
                        &nbsp;</td>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="114px" Width="126px" />
                    </td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                        <asp:Button ID="Button1" runat="server" Text="Opcion Paciente" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnAtras" runat="server" Text="Atras" Height="50px" Width="122px" onclick="btnAtras_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
    </asp:Content>