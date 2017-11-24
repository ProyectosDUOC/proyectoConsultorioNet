<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/Medico.Master" AutoEventWireup="true" CodeBehind="PanelConsultaM.aspx.cs" Inherits="consultorioWeb.Medico.PanelConsultaM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
            .style1 {
                width: 204px;
            }

            .style2 {
                width: 76px;
            }

            table {
                border: 2px solid black;
            }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
                <table style="width:100%;">
                    <tr>
                        <td class="style1">
                            <img alt="" src="/Imagen/Foto1.jpg" style="height: 164px; width: 161px" />
                        </td>
                        <td class="style4">
                            <table style="width: 100%; height: 114px;">
                                <tr>
                                    <td class="style2">Nombre:</td>
                                    <td class="style3"> <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Button ID="Button2" runat="server" Text="Cerrar Sesión" onclick="Button2_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:Label ID="Label1" runat="server" Text="Rut:"></asp:Label>
                                    </td>
                                    <td class="style3">
                                        
                                        <asp:Label ID="lblRut" runat="server" Text=""></asp:Label>
                                    </td>
                                   
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:Label ID="Label2" runat="server" Text="Fecha: "></asp:Label>
                                    </td>
                                    <td class="style3">
                                        <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
                                    </td>
                                    
                                </tr>
                            </table>
                        </td>
                        <td class="style4">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style4">
                            <asp:Label ID="Label3" runat="server" Text="Lista Pacientes"></asp:Label>
                        </td>
                        <td class="style4">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style4">&nbsp;</td>
                        <td class="style4">&nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style4">Ha seleccionado: 
                            <asp:Label ID="lblResultado" runat="server" ForeColor="Red" Text=""></asp:Label>
                        </td>
                        <td class="style4">&nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style4">
                            <asp:Button ID="bntRevisar" runat="server" Text="Ficha Paciente" 
                                onclick="bntRevisar_Click" Height="82px" style="text-align: center" 
                                Width="170px" />
                            <asp:Label ID="lblError" runat="server" ForeColor="Blue" Text="" 
                                style="font-weight: 700; font-size: xx-large; text-align: center;"></asp:Label>
                        </td>
                        <td class="style4">&nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style4">
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                                BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Chequeo"                                  
                                onpageindexchanging="GridView1_PageIndexChanging" 
                                onselectedindexchanged="Seleccionar">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:BoundField DataField="IdFicha" HeaderText="IdFicha" 
                                        SortExpression="IdFicha" />
                                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                                    <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" />
                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                                        SortExpression="Nombre" />
                                    <asp:BoundField DataField="Sector" HeaderText="Sector" 
                                        SortExpression="Sector" />
                                    <asp:BoundField DataField="Chequeo" HeaderText="Chequeo" 
                                        SortExpression="Chequeo" />
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
                        <td class="style4">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </div>
</asp:Content>
