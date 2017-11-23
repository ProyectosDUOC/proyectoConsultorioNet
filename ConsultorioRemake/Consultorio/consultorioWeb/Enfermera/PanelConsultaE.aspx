<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera/Enfermera.Master" AutoEventWireup="true" CodeBehind="PanelConsultaE.aspx.cs" Inherits="consultorioWeb.Enfermera.PanelConsultaE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
                <table style="width:100%;">
                    <tr>
                        <td class="style1">
                            <img alt="" src="/Imagen/Foto4.jpg" style="height: 149px; width: 140px" /></td>
                        <td class="style4">
                            <table style="width: 100%; height: 114px;">
                                <tr>
                                    <td class="style2">Nombre: <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td class="style3">
                                        &nbsp;</td>
                                    <td>
                                        <asp:Button ID="Button2" runat="server" Text="Cerrar Sesión" onclick="Button2_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">Rut: 
                                        
                                        <asp:Label ID="lblRut" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td class="style3">
                                        </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:Label ID="Label2" runat="server" Text="Fecha: "></asp:Label>
                                        <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td class="style3">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style4">
                            <asp:Label ID="Label3" runat="server" Text="Lista Pacientes"></asp:Label>
                            :
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style4">Ha seleccionado: 
                            <asp:Label ID="Label6" runat="server" ForeColor="Red" Text=""></asp:Label>
                            <asp:Button ID="bntRevisar" runat="server" Text="Ficha Paciente" 
                                onclick="bntRevisar_Click" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style4">
                            <asp:GridView ID="GridView1" runat="server" Width="467px" AllowPaging="True" 
                                AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" 
                                BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                                DataKeyNames="IdFicha,Rut,Fecha"
                                onpageindexchanging="GridView1_PageIndexChanging" 
                                onselectedindexchanged="seleccion">
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
                                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" ForeColor="#003399" />
                                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                                <SortedDescendingHeaderStyle BackColor="#002876" />
                            </asp:GridView>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </div>
</asp:Content>
