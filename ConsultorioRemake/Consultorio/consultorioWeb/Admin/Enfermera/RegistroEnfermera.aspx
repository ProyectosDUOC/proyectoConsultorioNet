<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="RegistroEnfermera.aspx.cs" Inherits="consultorioWeb.Admin.Enfermera.RegistroEnfermera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
 <table>

                    <tr>
                        <td>N° ficha</td>
                        <td>Rut</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txt_nFicha" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_Rut" runat="server"></asp:TextBox>
                        </td>
                        <td class="style1">-</td>
                        <td class="style2">
                            <asp:Label ID="lbl_Dv" runat="server" Text=" "></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" />
                        </td>
                    </tr>
                </table>


                <table>
                    <tr>
                        <td>Primer nombre</td>
                        <td>Segundo nombre</td>
                        <td>Primer apellido</td>
                        <td>Segundo nombre</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txt_pNombre" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_sNombre" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_apPaterno" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_apMaterno" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Fecha nacimiento</td>
                        <td>Edad</td>
                        <td>Género</td>
                        <td>Nacionalidad</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txt_Fecha" runat="server" style="height: 22px" TextMode="Date"></asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lbl_Edad" runat="server" Text=" "></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Domicilio</td>
                        <td>Comuna</td>
                        <td>Sector</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txt_Domicilio" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList3" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList4" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>N° casa</td>
                        <td>N° celular</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txt_nCasa" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_nCelular" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                </table>               

                <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" Height="47px" Width="232px" />
                <asp:Button ID="btn_Atras" runat="server" Text="Atrás" Width="188px" Height="55px" onclick="btn_Atras_Click" />
            </div>
</asp:Content>
