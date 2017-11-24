<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera/Enfermera.Master" AutoEventWireup="true" CodeBehind="FichaPacienteE.aspx.cs" Inherits="consultorioWeb.Enfermera.FichaPacienteE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
            .style1 {
                width: 268px;
            }

            .style2 {
                width: 256px;
            }

            .style6 {
                width: 205px;
            }

            .style7 {
                width: 202px;
            }

            .style8 {
                width: 87px;
            }

            .style9 {
                width: 201px;
            }

            .style10 {
                width: 200px;
            }

            .style11 {
                width: 192px;
            }

            .style12 {
                width: 251px;
            }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
                <table style="width:100%;">
                    <tr>
                        <td class="style6">
                        </td>
                        <td class="style7">
                            <center>
                                <asp:Label ID="Label1" runat="server" Text="Ficha Paciente" 
                                    style="font-weight: 700; font-size: x-large"></asp:Label>
                            </center>
                        </td>
                        <td class="style7">
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            &nbsp;</td>
                        <td>
                            <table style="width: 100%; height: 130px;">
                                <tr>
                                    <td class="style2">
                                        <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                                        <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td class="style12">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        Rut:
                                        <asp:Label ID="lblRut" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td class="style12">
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
                        <td>
                            <table style="width: 99%; height: 71px;">
                                <tr>
                                    <td class="style8">
                                        <asp:Label ID="Label3" runat="server" Text="Peso:"></asp:Label>
                                    </td>
                                    <td class="style11">
                                        <asp:TextBox ID="txtPeso" TextMode="Number" runat="server" Width="192px"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style8">
                                        <asp:Label ID="Label4" runat="server" Text="Estatura:"></asp:Label>
                                    </td>
                                    <td class="style11">
                                        <asp:TextBox ID="txtEstatura"  TextMode="Number" runat="server" Width="190px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label9" runat="server" Text="IMC"></asp:Label>
                                        :<asp:Label ID="IMC" ForeColor="Red" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style8">
                                        <asp:Label ID="Label5" runat="server" Text="Temperatura:"></asp:Label>
                                    </td>
                                    <td class="style11">
                                        <asp:TextBox ID="txtTemperatura" TextMode="Number" runat="server" Width="189px"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <table style="width: 83%;">
                                <tr>
                                    <td class="style9">

                                    </td <td class="style10">
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
                                <asp:TextBox ID="txtDia" runat="server" Width="77px" style="margin-left: 0px"></asp:TextBox>
                                <asp:Label ID="Label10" runat="server" Text="mmHg"></asp:Label>
                            </td>
                        </tr>
                        <tr>

                            <td>
                                SYS</td>
                            <td>
                                <asp:TextBox ID="txtSys" runat="server" Width="78px" style="margin-left: 0px"></asp:TextBox>
                                <asp:Label ID="Label11" runat="server" Text="mmHg"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Pulsacion</td>
                            <td>
                                <asp:TextBox ID="txtPulsaciones" runat="server" Width="86px" style="margin-left: 0px"></asp:TextBox>
                                <asp:Label ID="Label12" runat="server" Text="/min"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <asp:Label ID="Label7" runat="server" Text="Motivo"></asp:Label>
                            </td>
                            <td class="style10">
                                <asp:TextBox ID="txtMotivo" TextMode="MultiLine" runat="server" Height="210px" Width="199px" style="margin-top: 6px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <a href="PanelConsultaE.aspx" style="font-weight: 700; font-size: x-large">Volver</a> </td>
                            <td class="style10">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" onclick="Button4_Click" />
                            </td>
                        </tr>
                        </table>
                        </td>
                    </tr>
                </table>
            </div>
</asp:Content>
