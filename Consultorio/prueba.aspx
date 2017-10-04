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
                <td>
                    &nbsp;
                    Sector</td>
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
                        SelectCommand="SELECT Comuna.id_comuna as id, Comuna.nom_com as Comuna, Region.nom_region as nombre_region, Pais.nom_pais as pais FROM Comuna INNER JOIN Region ON Comuna.id_region = Region.id_region INNER JOIN Pais ON Region.id_pais = Pais.id_pais "></asp:SqlDataSource>
                </td>
                <td>
                   
                    <asp:SqlDataSource ID="sqlSector" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConsultoriosConnectionString4 %>" 
                        SelectCommand="SELECT id_sector as &quot;ID&quot;,nombre as &quot;Nombre sector&quot; FROM Sector"></asp:SqlDataSource>
                   
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
                        CellPadding="3" DataKeyNames="id" DataSourceID="SqlComunaRegion" 
                        GridLines="Vertical" AllowPaging="True" AllowSorting="True">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" 
                                SortExpression="id" />
                            <asp:BoundField DataField="Comuna" HeaderText="Comuna" 
                                SortExpression="Comuna" />
                            <asp:BoundField DataField="nombre_region" HeaderText="nombre_region" 
                                SortExpression="nombre_region" />
                            <asp:BoundField DataField="pais" HeaderText="pais" SortExpression="pais" />
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
                <td>
                    
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
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
