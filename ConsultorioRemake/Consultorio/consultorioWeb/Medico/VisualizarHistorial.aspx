<%@ Page Title="" Language="C#" MasterPageFile="~/Medico/Medico.Master" AutoEventWireup="true" CodeBehind="VisualizarHistorial.aspx.cs" Inherits="consultorioWeb.Medico.VisualizarHistorial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div>
                <asp:Label ID="Label1" runat="server" Text="Visualizar Historial"></asp:Label>
            </div>
            <table style="width:100%;">
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label2" runat="server" Text="Id Ficha:"></asp:Label>
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:Label ID="Label8" runat="server" Text="Secretaria: "></asp:Label>
                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="105px" Width="118px" />
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label3" runat="server" Text="Fecha:"></asp:Label>
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:Label ID="Label10" runat="server" Text="Enfermera:"></asp:Label>
                        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label14" runat="server" Text="Imagen Paciente"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label4" runat="server" Text="Nombre paciente:"></asp:Label>
                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="style2">
                        <asp:Label ID="Label11" runat="server" Text="Medico Tratante:"></asp:Label>
                        <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label15" runat="server" Text="Peso: "></asp:Label>
                        <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="style3">
                        <asp:Label ID="Label28" runat="server" Text="Pulsación:"></asp:Label>
                        <asp:Label ID="Label29" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label18" runat="server" Text="Temperatura:"></asp:Label>
                        <asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label16" runat="server" Text="Estatura: "></asp:Label>
                        <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="style3">
                        <asp:Label ID="Label19" runat="server" Text="Sistonia:"></asp:Label>
                        <asp:Label ID="Label25" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label17" runat="server" Text="I.M.C:"></asp:Label>
                        <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="style3">
                        <asp:Label ID="Label20" runat="server" Text="Diastolica:"></asp:Label>
                        <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnAtras" runat="server" Text="Atras" Width="117px" onclick="btnAtras_Click" />
                        <asp:Button ID="btnAtras0" runat="server" Text="Licencia Medica" Width="117px" />
                    </td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td class="style4">
                        <asp:Label ID="Label30" runat="server" Text="Diagnostico:"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:Label ID="Label31" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
</asp:Content>
