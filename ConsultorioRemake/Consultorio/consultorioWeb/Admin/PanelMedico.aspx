<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="PanelMedico.aspx.cs" Inherits="consultorioWeb.Admin.PanelMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
 <center>
                    <h1>Medico</h1>
                </center>
                <center>
                    <asp:Button ID="btn_Agregar" runat="server" Text="Control Medico" Width="288px" Height="55px" onclick="btn_Agregar_Click" /><br><br><br>
                    <asp:Button ID="btn_Listar" runat="server" Text="Listar" Width="288px" Height="55px" onclick="btn_Listar_Click" />
                    <br />
                    <br />
                    <br>
                <asp:Button ID="btn_Atras" runat="server" Text="Atrás" Width="188px" Height="55px" onclick="btn_Atras_Click" />
                    <br>
                </center>
            </div>
</asp:Content>
