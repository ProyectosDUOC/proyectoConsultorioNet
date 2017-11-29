<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/Medico.Master" AutoEventWireup="true" CodeBehind="FichaPaciente.aspx.cs" Inherits="consultorioWeb.Medico.FichaPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
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
        .style12
        {
            width: 284px;
        }
        .style13
        {
            width: 100px;
        }
        .style17
        {
            height: 59px;
        }
        .style18
        {
            width: 140px;
            height: 59px;
        }
        .style19
        {
            width: 140px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="width:100%;">
            <tr>
                <td class="style12">
                    &nbsp;</td>
                <td class="style13">
                    <img alt="" src="../Imagen/031-doctor.png" 
                        style="height: 132px; width: 138px" /></td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Ficha Paciente"                         
                        
                        style="font-weight: 700; font-size: xx-large; color: #FFFFFF; text-align: center; background-color: #003366;"></asp:Label>
                </td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style12">&nbsp;</td>
                <td class="style13">&nbsp;</td>
                <td>
                <center>
                    <asp:Label ID="lblMensaje" runat="server" 
                        style="font-weight: 700; color: #FF5050; font-size: xx-large;" Text=""></asp:Label>
                </center>
                </td>
                <td class="style7">
                    </td>
            </tr>
            <tr>
                <td class="style12">
                    &nbsp;</td>
                <td class="style13">
                    <img alt="" src="../Imagen/001-plan-de-estudios.png" 
                        style="height: 132px; width: 138px" /></td>
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
                                &nbsp;</td>
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
                <td class="style12">
                    &nbsp;</td>
                <td class="style13">
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
                            <td class="style19">
                            
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
                        <td class="style19">
                                        &nbsp;</td>
                        </tr>
                         <tr>

                        <td>
                            SYS</td>
                        <td>
                                        <asp:Label ID="lblSys" runat="server" Text=""></asp:Label>
                            <asp:Label ID="Label11" runat="server" Text="mmHg"></asp:Label>
                        </td>
                        <td class="style19">
                                        &nbsp;</td>
                        </tr>
                         <tr>
                        <td class="style17">
                            Pulsacion</td>
                        <td class="style17">
                                        <asp:Label ID="lblPul" runat="server" Text=""></asp:Label>
                            <asp:Label ID="Label12" runat="server" Text="/min"></asp:Label>
                        </td>
                        <td class="style18">
                                        </td>
                        </tr>
                        <tr>
                            <td class="style9">
                                <asp:Label ID="Label7" runat="server" Text="Motivo"></asp:Label>
                            </td>
                            <td class="style10">
                                        <asp:Label ID="lblMotivo" runat="server" Text=""></asp:Label>
                                    </td>
                            <td class="style19">
                                        <asp:Button ID="btnMedicamentos" runat="server" Text="Medicamentos" 
                                            Width="105px" style="text-align: justify" onclick="btnMedicamentos_Click" 
                                            Height="71px" />
                    <img alt="" src="../Imagen/018-drogas-3.png" 
                        style="height: 85px; width: 99px; float: right; text-align: justify;" /></td>                            
                        </tr>
                        <tr>
                            <td>

                                <asp:Label ID="Label13" runat="server" Text="Diagnostico"></asp:Label>

                            </td>
                            <td>
                            
                                <asp:TextBox ID="txtDiagnostico" runat="server" TextMode="MultiLine" Height="165px" Width="231px"></asp:TextBox>
                            
                            </td>
                            <td class="style19">
                            
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3">
                                    <Columns>
                                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                                            SortExpression="Nombre" />
                                        <asp:BoundField DataField="Cant" HeaderText="Cant" SortExpression="Cant" />
                                        <asp:BoundField DataField="Hora" HeaderText="Hora" SortExpression="Hora" />
                                        <asp:BoundField DataField="Dia" HeaderText="Dia" SortExpression="Dia" />
                                        <asp:BoundField DataField="Glosa" HeaderText="CantTotal" 
                                            SortExpression="Glosa" />
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
                        </tr>
                        <tr>
                            <td class="style9">
                                <a href="PanelConsultaM.aspx" style="font-weight: 700; font-size: x-large">Volver</a></td>
                            <td class="style10">
                                <asp:Button ID="btnGuardarMedico" runat="server" Text="Guardar" Height="54px" 
                                    onclick="btnGuardarMedico_Click" Width="236px" 
                                  />
                            </td>
                            <td class="style19">
                                <asp:Label ID="lblResultadoBSOTROS" ForeColor="Red" runat="server" Text="Label" 
                                    style="text-align: center; font-weight: 700"></asp:Label>
                            </td>
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
