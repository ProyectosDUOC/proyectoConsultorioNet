<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba.aspx.cs" Inherits="Consultorio.prueba" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 167px;
        }
        .style2
        {
            width: 199px;
        }
        .style3
        {
            width: 166px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td class="style1">
                    &nbsp;
                    Alergias</td>
                <td class="style2">
                    Comuna</td>
                <td class="style3">
                    &nbsp;
                    Sector</td>
                <td>
                    medico</td>
            </tr>
            <tr>
                <td class="style1">                   
                    <asp:SqlDataSource ID="sqlAlergia" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConsultoriosConnectionString2 %>" 
                        SelectCommand="SELECT * FROM [Alergia]"></asp:SqlDataSource>
                </td>
                <td class="style2">
                    <asp:SqlDataSource ID="SqlComunaRegion" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConsultoriosConnectionString3 %>" 
                        
                        SelectCommand="SELECT Comuna.id_comuna, Comuna.nom_com, Provincia.nom_com AS Expr2, Region.nom_region, Pais.nom_pais FROM Comuna INNER JOIN Provincia ON Comuna.id_provincia = Provincia.id_provincia INNER JOIN Region ON Provincia.id_region = Region.id_region INNER JOIN Pais ON Region.id_pais = Pais.id_pais"></asp:SqlDataSource>
                </td>
                <td class="style3">
                   
                    <asp:SqlDataSource ID="sqlSector" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConsultoriosConnectionString4 %>" 
                        SelectCommand="SELECT id_sector as &quot;ID&quot;,nombre as &quot;Nombre sector&quot; FROM Sector"></asp:SqlDataSource>
                   
                </td>
                <td>
                   
                    <asp:SqlDataSource ID="SqlMedico" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConsultoriosConnectionString5 %>" 
                        SelectCommand="SELECT Medico.id_Medico as &quot;Id Medico&quot;, Medico.rut_medico as &quot;Rut Medico&quot;,  Medico.dv_medico as &quot;Dv Medico&quot;,  Usuario.rut_usuario as &quot;Rut Medico personal&quot;, Usuario.dv_usuario as &quot;dv&quot;, Usuario.pnombre as &quot;Nombre&quot;, Usuario.snombre as &quot;Segundo Nombre&quot;, Usuario.appaterno as &quot;Apellido Paterno&quot;, Usuario.apmaterno as &quot;Apellido Materno&quot;, Usuario.fecha_nacimiento as &quot;Fecha Nacimiento&quot;, Usuario.direccion as &quot;Dirección&quot;, Usuario.fono1 as &quot;Fono 1&quot;, Usuario.fono2 as &quot;Fono 2&quot;,  Especialidad.nom_especialidad as &quot;Nombre Especialidad&quot; FROM Medico INNER JOIN Usuario ON Medico.id_usuario = Usuario.id_usuario INNER JOIN Especialidad ON Medico.id_especialidad = Especialidad.id_especialidad"></asp:SqlDataSource>
                   
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                        DataKeyNames="id_alergia" DataSourceID="sqlAlergia">
                        <Columns>
                            <asp:BoundField DataField="id_alergia" HeaderText="id_alergia" ReadOnly="True" 
                                SortExpression="id_alergia" />
                            <asp:BoundField DataField="nombre" HeaderText="nombre" 
                                SortExpression="nombre" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                </td>
                <td class="style2">
                   
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" DataKeyNames="id_comuna" DataSourceID="SqlComunaRegion" 
                        GridLines="Vertical" AllowPaging="True" AllowSorting="True">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="id_comuna" HeaderText="id_comuna" ReadOnly="True" 
                                SortExpression="id_comuna" />
                            <asp:BoundField DataField="nom_com" HeaderText="nom_com" 
                                SortExpression="nom_com" />
                            <asp:BoundField DataField="Expr2" HeaderText="Expr2" 
                                SortExpression="Expr2" />
                            <asp:BoundField DataField="nom_region" HeaderText="nom_region" 
                                SortExpression="nom_region" />
                            <asp:BoundField DataField="nom_pais" HeaderText="nom_pais" 
                                SortExpression="nom_pais" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                </td>
                <td class="style3">
                    
                    <asp:GridView ID="GridView3" runat="server" AllowPaging="True" 
                        AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
                        DataKeyNames="ID" DataSourceID="sqlSector" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" 
                                SortExpression="ID" />
                            <asp:BoundField DataField="Nombre sector" HeaderText="Nombre sector" 
                                SortExpression="Nombre sector" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
                <td>
                    
                    <asp:GridView ID="GridView4" runat="server" AllowPaging="True" 
                        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                        BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                        DataKeyNames="Id Medico" DataSourceID="SqlMedico" GridLines="Horizontal">
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <Columns>
                            <asp:BoundField DataField="Id Medico" HeaderText="Id Medico" ReadOnly="True" 
                                SortExpression="Id Medico" />
                            <asp:BoundField DataField="Rut Medico" HeaderText="Rut Medico" 
                                SortExpression="Rut Medico" />
                            <asp:BoundField DataField="Dv Medico" HeaderText="Dv Medico" 
                                SortExpression="Dv Medico" />
                            <asp:BoundField DataField="Rut Medico personal" 
                                HeaderText="Rut Medico personal" SortExpression="Rut Medico personal" />
                            <asp:BoundField DataField="dv" HeaderText="dv" SortExpression="dv" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                                SortExpression="Nombre" />
                            <asp:BoundField DataField="Segundo Nombre" HeaderText="Segundo Nombre" 
                                SortExpression="Segundo Nombre" />
                            <asp:BoundField DataField="Apellido Paterno" HeaderText="Apellido Paterno" 
                                SortExpression="Apellido Paterno" />
                            <asp:BoundField DataField="Apellido Materno" HeaderText="Apellido Materno" 
                                SortExpression="Apellido Materno" />
                            <asp:BoundField DataField="Fecha Nacimiento" HeaderText="Fecha Nacimiento" 
                                SortExpression="Fecha Nacimiento" />
                            <asp:BoundField DataField="Dirección" HeaderText="Dirección" 
                                SortExpression="Dirección" />
                            <asp:BoundField DataField="Fono 1" HeaderText="Fono 1" 
                                SortExpression="Fono 1" />
                            <asp:BoundField DataField="Fono 2" HeaderText="Fono 2" 
                                SortExpression="Fono 2" />
                            <asp:BoundField DataField="Nombre Especialidad" 
                                HeaderText="Nombre Especialidad" SortExpression="Nombre Especialidad" />
                        </Columns>
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <SortedAscendingCellStyle BackColor="#F4F4FD" />
                        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                        <SortedDescendingCellStyle BackColor="#D8D8F0" />
                        <SortedDescendingHeaderStyle BackColor="#3E3277" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
