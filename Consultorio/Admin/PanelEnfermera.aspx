<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="PanelEnfermera.aspx.cs" Inherits="Consultorio.Admin.PanelEnfermera" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div>
                <center>
                    <h1>ENFERMERA</h1>
                </center>
                <asp:Button ID="btn_Atras" runat="server" Text="Atrás" Width="188px" Height="55px" onclick="btn_Atras_Click" />
                <center>
                    <asp:Button ID="btn_Agregar" runat="server" Text="Agregar" Width="288px" Height="55px" onclick="btn_Agregar_Click" /><br><br>
                    <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" Width="288px" Height="55px" onclick="btn_Buscar_Click" /><br><br>
                    <asp:Button ID="btn_Modificar" runat="server" Text="Modificar" Width="288px" Height="55px" onclick="btn_Modificar_Click"
                    /><br><br>
                    <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar" Width="288px" Height="55px" onclick="btn_Eliminar_Click" /><br><br>
                    <asp:Button ID="btn_Listar" runat="server" Text="Listar" Width="288px" Height="55px" onclick="btn_Listar_Click" /><br><br>
                </center>
            </div>
    </asp:Content>