<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ListarEnfermera.aspx.cs" Inherits="consultorioWeb.Admin.Enfermera.ListarEnfermera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GenerarListado" TypeName="capaNegocio.EnfermeraColeccion">
            <SelectParameters>
                <asp:Parameter Name="EnfermeraDALC" Type="Object" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" 
                    SortExpression="IdUsuario" />
                <asp:BoundField DataField="IdJornadaLaboral" HeaderText="IdJornadaLaboral" 
                    SortExpression="IdJornadaLaboral" />
            </Columns>
        </asp:GridView>
                <asp:Button ID="btn_Atras" runat="server" Text="Atrás" Width="188px" 
                    Height="55px" onclick="btn_Atras_Click" />

            </div>
</asp:Content>
