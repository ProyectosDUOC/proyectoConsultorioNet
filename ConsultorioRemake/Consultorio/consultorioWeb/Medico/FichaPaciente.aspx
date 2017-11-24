<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/Medico.Master" AutoEventWireup="true" CodeBehind="FichaPaciente.aspx.cs" Inherits="consultorioWeb.Medico.FichaPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 199px;
        }
        .style3
        {
            width: 230px;
        }
        .style4
        {
            width: 200px;
        }
        .style5
        {
            width: 442px;
        }
        .style6
        {
            width: 9px;
        }
        .style7
        {
            width: 14px;
        }
        .style8
        {
            width: 18px;
        }
        .style9
        {
            width: 19px;
        }
        .style10
        {
            width: 20px;
        }
        .style11
        {
            width: 337px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
        <table style="width:100%;">
            <tr>
                <td class="style6">&nbsp;</td>
                <td class="style7">
                    <asp:Label ID="Label1" runat="server" Text="Ficha Paciente"                         
                        
                        style="font-weight: 700; font-size: xx-large; color: #FFFFFF; text-align: center; background-color: #003366;"></asp:Label>
                </td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style6">&nbsp;</td>
                <td class="style7">
                <center>
                    <asp:Label ID="lblMensaje" runat="server" 
                        style="font-weight: 700; color: #FF5050; font-size: xx-large;" Text=""></asp:Label>
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
                            <td class="style5">
                                <asp:Label ID="lbl" runat="server" Text="N° Ficha " 
                        style="color: #003366; font-size: x-large"></asp:Label>
                    <asp:Label ID="lblID" runat="server" 
                        style="font-weight: 700; color: #3399FF; font-size: xx-large" Text=""></asp:Label>
                            </td>
                            <td class="style3">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style5">
                                <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                            &nbsp;<asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="style3">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Licencia" Width="86px" 
                                    style="height: 26px" onclick="Button1_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                <asp:Label ID="Label14" runat="server" Text="Rut"></asp:Label>
                                :
                                        <asp:Label ID="lblRut" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="style3">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style5">
                                <asp:Label ID="Label15" runat="server" Text="Fecha"></asp:Label>
                                :
                                        <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="style3">
                                &nbsp;</td>                            
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
                            &nbsp;<asp:Label ID="lblPeso" runat="server" Text=""></asp:Label>
                                    </td>
                            <td class="style8">
                                IMC: 
                                        <asp:Label ID="IMC" runat="server" Text=""></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <asp:Label ID="Label4" runat="server" Text="Estatura:"></asp:Label>
                            &nbsp;<asp:Label ID="lblEstatura" runat="server" Text=""></asp:Label>
                                    </td>
                            <td class="style8">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <asp:Label ID="Label5" runat="server" Text="Temperatura:"></asp:Label>
                            &nbsp;<asp:Label ID="lblTemperatura" runat="server" Text=""></asp:Label>
                                    </td>
                            <td class="style8">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <table style="width: 96%;">
                        <tr>
                            <td class="style9">
                               
                            </td
                            <td class="style10">
                                &nbsp;</td>
                            <td>
                            
                                <asp:Label ID="Label6" runat="server" Text="Presión"></asp:Label>
                            </td>
                            <td class="style11">
                            
                                &nbsp;</td>
                        </tr>
                        <tr>

                        <td>
                            <asp:Label ID="Label8" runat="server" Text="DIA"></asp:Label>
                        </td>
                        <td>
                                        <asp:Label ID="lblDia" runat="server" Text=""></asp:Label>
                            <asp:Label ID="Label10" runat="server" Text="mmHg"></asp:Label>
                        </td>
                        <td class="style11">
                                        &nbsp;</td>
                        </tr>
                         <tr>

                        <td>
                            SYS</td>
                        <td>
                                        <asp:Label ID="lblSys" runat="server" Text=""></asp:Label>
                            <asp:Label ID="Label11" runat="server" Text="mmHg"></asp:Label>
                        </td>
                        <td class="style11">
                                        &nbsp;</td>
                        </tr>
                         <tr>
                        <td>
                            Pulsacion</td>
                        <td>
                                        <asp:Label ID="lblPul" runat="server" Text=""></asp:Label>
                            <asp:Label ID="Label12" runat="server" Text="/min"></asp:Label>
                        </td>
                        <td class="style11">
                                        &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <asp:Label ID="Label7" runat="server" Text="Motivo"></asp:Label>
                            </td>
                            <td class="style10">
                                        <asp:Label ID="lblMotivo" runat="server" Text=""></asp:Label>
                                    </td>
                            <td class="style11">
                                        <asp:Button ID="btnMedicamentos" runat="server" Text="Medicamentos" 
                                            Width="132px" style="text-align: center" onclick="btnMedicamentos_Click" />
                             </td>                            
                        </tr>
                        <tr>
                            <td>

                                <asp:Label ID="Label13" runat="server" Text="Diagnostico"></asp:Label>

                            </td>
                            <td>
                            
                                <asp:TextBox ID="txtDiagnostico" runat="server" TextMode="MultiLine" Height="165px" Width="231px"></asp:TextBox>
                            
                            </td>
                            <td class="style11">
                            
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <a href="PanelConsultaM.aspx" style="font-weight: 700; font-size: x-large">Volver</a></td>
                            <td class="style10">
                                <asp:Button ID="btnGuardarMedico" runat="server" Text="Guardar" Height="54px" 
                                    onclick="btnGuardarMedico_Click" Width="236px" 
                                  />
                            </td>
                            <td class="style11">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>                    
                    
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
