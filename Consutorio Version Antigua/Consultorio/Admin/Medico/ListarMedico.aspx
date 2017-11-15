<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ListarMedico.aspx.cs" Inherits="Consultorio.Admin.Medico.ListarMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        
        <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" Height="47px" 
            Width="232px" onclick="btn_Guardar_Click" />
            <asp:Button ID="btn_Atras" runat="server" Text="Atrás" Width="188px" 
            Height="47px" onclick="btn_Atras_Click"/>

   
</asp:Content>
