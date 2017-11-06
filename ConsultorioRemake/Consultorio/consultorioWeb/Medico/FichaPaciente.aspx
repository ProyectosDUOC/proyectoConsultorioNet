<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/Medico.Master" AutoEventWireup="true" CodeBehind="FichaPaciente.aspx.cs" Inherits="consultorioWeb.Medico.FichaPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
        <table style="width:100%;">
            <tr>
                <td class="style6">
                    </td>
                <td class="style7">
                <center>
                    <asp:Label ID="Label1" runat="server" Text="Ficha Paciente"></asp:Label>
                </center>
                </td>
                <td class="style7">
                    </td>
            </tr>
            <tr>
                <td class="style1">
                    <img alt="" src="" style="height: 138px; width: 145px" /></td>
                <td>
                    <table style="width: 100%; height: 130px;">
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:TextBox ID="TextBox6" runat="server" Width="218px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Licencia" Width="86px" 
                                    style="height: 26px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label14" runat="server" Text="Rut"></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="Historial" Width="86px" 
                                     />
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label15" runat="server" Text="Fecha"></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                            </td>                            
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    <table style="width: 83%; height: 71px;">
                        <tr>
                            <td class="style4">
                                <asp:Label ID="Label3" runat="server" Text="Peso:"></asp:Label>
                            </td>
                            <td class="style8">
                                <asp:TextBox ID="TextBox1" runat="server" Width="192px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <asp:Label ID="Label4" runat="server" Text="Estatura:"></asp:Label>
                            </td>
                            <td class="style8">
                                <asp:TextBox ID="TextBox2" runat="server" Width="190px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <asp:Label ID="Label5" runat="server" Text="Temperatura:"></asp:Label>
                            </td>
                            <td class="style8">
                                <asp:TextBox ID="TextBox3" runat="server" Width="187px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <table style="width: 83%;">
                        <tr>
                            <td class="style9">
                               
                            </td
                            <td class="style10">
                                &nbsp;</td>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Presión"></asp:Label>
                            </td>
                        </tr>
                        <tr>

                        <td>
                            <asp:Label ID="Label8" runat="server" Text="DIA"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox7" runat="server" Width="77px" style="margin-left: 0px"></asp:TextBox>
                            <asp:Label ID="Label10" runat="server" Text="mmHg"></asp:Label>
                        </td>
                        </tr>
                         <tr>

                        <td>
                            SYS</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" Width="78px" style="margin-left: 0px"></asp:TextBox>
                            <asp:Label ID="Label11" runat="server" Text="mmHg"></asp:Label>
                        </td>
                        </tr>
                         <tr>
                        <td>
                            Pulsacion</td>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server" Width="86px" style="margin-left: 0px"></asp:TextBox>
                            <asp:Label ID="Label12" runat="server" Text="/min"></asp:Label>
                        </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <asp:Label ID="Label7" runat="server" Text="Motivo"></asp:Label>
                            </td>
                            <td class="style10">
                                <asp:TextBox ID="TextBox5" runat="server" Height="53px" Width="230px" 
                                    style="margin-top: 6px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>

                                <asp:Label ID="Label13" runat="server" Text="Diagnostico"></asp:Label>

                            </td>
                            <td>
                            
                                <asp:TextBox ID="TextBox10" runat="server" Height="165px" Width="231px"></asp:TextBox>
                            
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                &nbsp;</td>
                            <td class="style10">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="Button4" runat="server" Text="Guardar" 
                                    />
                            </td>
                        </tr>
                    </table>                    
                    
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
