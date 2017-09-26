<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="BuscarMedico.aspx.cs" Inherits="Consultorio.Admin.Medico.BuscarMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>N° ficha</td>
                <td>Rut</td>
                <td></td>
                <td></td>
                <td>Rut medico</td>
                <td>Especialidad</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txt_nFicha" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txt_Rut" runat="server"></asp:TextBox></td>
                <td class="style1">-</td>
                <td class="style2"><asp:Label ID="lbl_Dv" runat="server" Text=" "></asp:Label></td>
                <td><asp:TextBox ID="txtMedico" runat="server"></asp:TextBox></td>
                <td><asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList></td>
                <td><asp:Button ID="btn_Buscar" runat="server" Text="Buscar" 
                         /></td>
            </tr>
        </table>

        <br>
        <br>

        <table>
            <tr>
                <td>Primer nombre</td>
                <td>Segundo nombre</td>
                <td>Primer apellido</td>
                <td>Segundo nombre</td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPNombre" runat="server" Text=" "></asp:Label></td>
                <td><asp:Label ID="lblSNombre" runat="server" Text=" "></asp:Label></td>
                <td><asp:Label ID="lblApPaterno" runat="server" Text=" "></asp:Label></td>
                <td><asp:Label ID="lblApMaterno" runat="server" Text=" "></asp:Label></td>
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
                    <table>
                        <tr>
                            <td><asp:Label ID="lblDia" runat="server" Text=" " Width="30px"></asp:Label></td>
                            <td> / </td>
                            <td><asp:Label ID="lblMes" runat="server" Text=" " Width="30px"></asp:Label></td>
                            <td> / </td>
                            <td><asp:Label ID="lblAño" runat="server" Text=" " Width="30px"></asp:Label></td>                       
                        </tr>
                    </table>
                </td>

                <td><asp:Label ID="lbl_Edad" runat="server" Text=" "></asp:Label></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
                <td><asp:TextBox ID="txt_nacionalidad" runat="server"></asp:TextBox></td>
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
                <td><asp:Label ID="lblDomicilio" runat="server" Text=" "></asp:Label></td>
                <td><asp:Label ID="lblComuna" runat="server" Text=" "></asp:Label></td>
                <td><asp:Label ID="lblSector" runat="server" Text=" "></asp:Label></td>                   
            </tr>
            <tr>
                <td class="style2">&nbsp;</td>
            </tr>
            <tr>
                <td>N° casa</td>
                <td>N° celular</td>
            </tr>
            <tr>                
                <td><asp:Label ID="lblNCasa" runat="server" Text=" "></asp:Label></td>
                <td><asp:Label ID="lblNCelular" runat="server" Text=" "></asp:Label></td>                  
            </tr>
            
        </table>
        <br>
        <br>

            <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" Height="47px" 
            Width="232px" onclick="btn_Guardar_Click" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" Height="47px" 
            Width="232px" onclick="btnModificar_Click"/>
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Height="47px" 
            Width="232px" onclick="btnEliminar_Click"/>
            <asp:Button ID="btn_Atras" runat="server" Text="Atrás" Width="188px" 
            Height="55px" onclick="btn_Atras_Click"/>
    </form>
</asp:Content>
