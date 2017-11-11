<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ListarPaciente.aspx.cs" Inherits="consultorioWeb.Admin.Paciente.ListarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
     <asp:ObjectDataSource ID="odPaciente" runat="server"></asp:ObjectDataSource>
     <asp:GridView ID="GridView1" runat="server">
     </asp:GridView>


                <asp:Button ID="btn_Atras" runat="server" Text="Atrás" Width="188px" 
                    Height="55px" onclick="btn_Atras_Click" />

            </div>
</asp:Content>
