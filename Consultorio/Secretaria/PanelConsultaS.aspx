<%@ Page Title="" Language="C#" MasterPageFile="~/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="PanelConsultaS.aspx.cs" Inherits="Consultorio.Secretaria.PanelConsultaS" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
            .style1 {
                height: 23px;
            }

            .style2 {
                width: 138px;
            }

            .style3 {
                height: 23px;
                width: 138px;
            }

            .style5 {
                width: 377px;
            }

            .style6 {
                height: 23px;
                width: 377px;
            }
        </style>
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div>
                <table style="width: 100%;">
                    <tr>
                        <td class="style2">
                            <img src="/Imagen/LogoGobierno.png" alt="ministerio de la salud" />
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
                            &nbsp;
                            <asp:Button ID="Button2" runat="server" Text="Agregar Paciente" onclick="Button2_Click" />
                        </td>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style1">
                            &nbsp;
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="Panel1" runat="server">

                </asp:Panel>
            </div>
    </asp:Content>