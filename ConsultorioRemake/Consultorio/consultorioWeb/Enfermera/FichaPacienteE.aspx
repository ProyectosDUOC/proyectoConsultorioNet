<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera/Enfermera.Master" AutoEventWireup="true" CodeBehind="FichaPacienteE.aspx.cs" Inherits="consultorioWeb.Enfermera.FichaPacienteE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
            .style1 {
                width: 268px;
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

            .style13
        {
            width: 633px;
        }
        .style14
        {
            width: 256px;
            height: 41px;
        }
        .style15
        {
            width: 251px;
            height: 41px;
        }
        .style16
        {
            height: 41px;
        }
        .style17
        {
            width: 256px;
            height: 34px;
        }
        .style18
        {
            width: 251px;
            height: 34px;
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
                                    <td class="style14">
                                        <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                                        <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td class="style15">
                                        <img alt="" src="../Imagen/009-botiquin-de-primeros-auxilios.png" 
                                            style="height: 73px; width: 83px" /></td>
                                    <td class="style16">
                                        </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        Rut:
                                        <asp:Label ID="lblRut" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td class="style18">
                                        <asp:Label ID="lblEstado" ForeColor="Red" runat="server" Text="" 
                                            style="font-weight: 700; font-size: x-large"></asp:Label>
                                    </td>

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
                                        <asp:TextBox ID="txtPeso" TextMode="Number" MaxLength="3" runat="server" Width="192px"></asp:TextBox>
                                    </td>
                                    <td>
                                    Kg
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                           ControlToValidate="txtPeso" ForeColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style8">
                                        <asp:Label ID="Label4" runat="server" Text="Estatura:"></asp:Label>
                                    </td>
                                    <td class="style11">
                                        <asp:TextBox ID="txtEstatura" MaxLength="3" TextMode="Number" runat="server" Width="190px"></asp:TextBox>
                                    </td>
                                    <td>cm
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ControlToValidate="txtEstatura" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style8">
                                        <asp:Label ID="Label9" runat="server" Text="IMC"></asp:Label>
                                        :</td>
                                    <td class="style11">
                                        <asp:Label ID="IMC" ForeColor="Red" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                <img alt="" src="../Imagen/imc.gif" style="height: 143px; width: 277px" /></td>
                                </tr>
                                <tr>
                                    <td class="style8">
                                        <asp:Label ID="Label5" runat="server" Text="Temperatura:"></asp:Label>
                                    </td>
                                    <td class="style11">
                                        <asp:TextBox ID="txtTemperatura"  TextMode="Number" runat="server" Width="189px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                            ControlToValidate="txtTemperatura" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator ID="RangeValidator1" ControlToValidate="txtTemperatura" MaximumValue="40" MinimumValue="0" runat="server" 
                                            ForeColor="Blue" ErrorMessage="*Rango [20-40]°c"></asp:RangeValidator>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 83%; margin-right: 0px;">
                                <tr>
                                    <td class="style9">

                                    </td <td class="style10">
                                    &nbsp;</td>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Presión"></asp:Label>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style13">
                            &nbsp;</td>
                        </tr>
                        <tr>

                            <td>
                                <asp:Label ID="Label8" runat="server" Text="DIA"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDia" runat="server" TextMode="Number" Width="77px" style="margin-left: 0px"></asp:TextBox>
                                <asp:Label ID="Label10" runat="server" Text="mmHg"></asp:Label>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                    ControlToValidate="txtDia" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtDia" 
                                    ForeColor="Blue" MinimumValue="0" MaximumValue="500" ErrorMessage="*Mayor de 0 o menor a 500"></asp:RangeValidator>
                            </td>
                            <td class="style13">
                                <img alt="" src="../Imagen/Presion.jpg" style="height: 159px; width: 339px" /></td>
                        </tr>
                        <tr>

                            <td>
                                SYS</td>
                            <td>
                                <asp:TextBox ID="txtSys" runat="server"  TextMode="Number"  Width="78px" style="margin-left: 0px"></asp:TextBox>
                                <asp:Label ID="Label11" runat="server" Text="mmHg"></asp:Label>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                    ControlToValidate="txtSys" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txtSys" 
                                    ForeColor="Blue" MinimumValue="0" MaximumValue="500" ErrorMessage="*Mayor de 0 o menos a 500"></asp:RangeValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Pulsacion</td>
                            <td>
                                <asp:TextBox ID="txtPulsaciones"  TextMode="Number"  runat="server" Width="86px" style="margin-left: 0px"></asp:TextBox>
                                <asp:Label ID="Label12" runat="server" Text="/min"></asp:Label>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                    ControlToValidate="txtPulsaciones" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="txtPulsaciones" 
                                    ForeColor="Blue" MinimumValue="0" MaximumValue="500" ErrorMessage="*Mayor de 0 o menos a 500"></asp:RangeValidator>
                            </td>
                            <td class="style13">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <asp:Label ID="Label7" runat="server" Text="Motivo"></asp:Label>
                            </td>
                            <td class="style10">
                                <asp:TextBox ID="txtMotivo" TextMode="MultiLine" runat="server" Height="210px" Width="199px" style="margin-top: 6px"></asp:TextBox>
                            </td>
                            <td class="style10">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                    ControlToValidate="txtMotivo" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="style13">
                                <img alt="" src="../Imagen/Pulsaciones.png" 
                                    style="height: 210px; width: 354px" /></td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <a href="PanelConsultaE.aspx" style="font-weight: 700; font-size: x-large">Volver</a> </td>
                            <td class="style10">
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" 
                                    onclick="Button4_Click" Height="31px" Width="198px" />
                            </td>
                            <td class="style10">
                                &nbsp;</td>
                            <td class="style13">
                                &nbsp;</td>
                        </tr>
                        </table>
                        </td>
                    </tr>
                </table>
            </div>
</asp:Content>
