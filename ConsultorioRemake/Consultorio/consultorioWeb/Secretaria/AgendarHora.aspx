<%@ Page Title="" Language="C#" MasterPageFile="~/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="AgendarHora.aspx.cs" Inherits="consultorioWeb.Secretaria.AgendarHora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
            .style1 {
                height: 23px;
            }

            .style2 {
                width: 144px;
            }

            .style3 {
                height: 23px;
                width: 144px;
            }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div>
                <table style="width: 100%;">
                    <tr>
                        <td class="style2">
                            <img src="../Imagen/logoGobierno.png" alt="ministerio de la salud" />
                        </td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="REGISTRO PACIENTE CON HORAS"></asp:Label>
                        </td>
                        <td>
                            &nbsp;
                            <asp:Button ID="Button1" runat="server" Text="Atras" onclick="Button1_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            FECHA</td>
                        <td class="style1">
                            &nbsp;
                            <asp:Button ID="Button2" runat="server" Text="Agregar Paciente" onclick="Button2_Click1" />
                        </td>
                        <td class="style1">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </div>
</asp:Content>
