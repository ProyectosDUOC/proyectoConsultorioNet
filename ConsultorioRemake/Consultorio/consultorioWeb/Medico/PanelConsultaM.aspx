<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/Medico.Master" AutoEventWireup="true" CodeBehind="PanelConsultaM.aspx.cs" Inherits="consultorioWeb.Medico.PanelConsultaM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                                    <td class="style3">Benjamin Mora</td>
                                    <td>
                                        <asp:Button ID="Button2" runat="server" Text="Cerrar Sesión" onclick="Button2_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:Label ID="Label1" runat="server" Text="Rut:"></asp:Label>
                                    </td>
                                    <td class="style3">
                                        19.111.111-2</td>
                                    <td>
                                        Sector
                                        <asp:DropDownList ID="DropDownList1" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:Label ID="Label2" runat="server" Text="Fecha: "></asp:Label>
                                    </td>
                                    <td class="style3">
                                        15-09-17</td>
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
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" onclick="btnBuscar_Click" />
                        </td>
                        <td class="style4">
                            <asp:Label ID="Label3" runat="server" Text="Lista Pacientes"></asp:Label>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td class="style4">
                            <asp:GridView ID="GridView1" runat="server" Width="467px">
                            </asp:GridView>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </div>
</asp:Content>
