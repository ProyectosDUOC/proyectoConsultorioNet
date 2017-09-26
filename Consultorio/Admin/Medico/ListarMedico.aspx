<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ListarMedico.aspx.cs" Inherits="Consultorio.Admin.Medico.ListarMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <form id="form1" runat="server">
     <div>
         <asp:GridView ID="GridView1" runat="server" Width="336px">
        </asp:GridView>
        <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" Height="47px" 
            Width="232px" onclick="btn_Guardar_Click" />
            <asp:Button ID="btn_Atras" runat="server" Text="Atrás" Width="188px" 
            Height="47px" onclick="btn_Atras_Click"/>

    </div>
    </form>
</asp:Content>
