<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AgregarPaciente.aspx.cs" Inherits="Consultorio.Admin.Paciente.AgregarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .style2
        {
            width: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        
        <table>
            <tr>
                <td>N° ficha</td>
                <td>Rut</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txt_nFicha" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txt_Rut" TextMode="Number" runat="server"></asp:TextBox></td>
                <td>-<asp:TextBox ID="txt_dv" runat="server" Width="35px"></asp:TextBox>
                </td>
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
                <td><asp:TextBox ID="txt_pNombre" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txt_sNombre" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txt_apPaterno" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txt_apMaterno" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="style2">&nbsp;</td>
            </tr>
            <tr>
                <td>Fecha nacimiento</td>
                <td>Edad</td>
                <td>Género</td>
                <td>NaciNacionalidad</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_Fecha" TextMode="Date" runat="server"></asp:TextBox>
                </td>

                <td><asp:Label ID="lbl_Edad" runat="server" Text=" "></asp:Label></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddNacionalidad" runat="server">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="style2">&nbsp;</td>
            </tr>
            <tr>
                <td>Domicilio>
                <td>Comuna</td>
                <td>Sector</td>
            </tr>
            <tr>                
                <td><asp:TextBox ID="txt_Domicilio" runat="server"></asp:TextBox></td>
                <td>
                    <asp:DropDownList ID="ddComuna" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddSector" runat="server">
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
                <td><asp:TextBox ID="txt_nCasa"  runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txt_nCelular" TextMode="Number" runat="server"></asp:TextBox></td>                  
            </tr>
            <tr>
                <td class="style2">&nbsp;</td>
            </tr>
            <tr>
                <td>Grupo sanguineo</td>
                <td>Rh sanguineo</td>
                <td>Alergia</td>
            </tr>
            <tr>                
                <td>
                    <asp:DropDownList ID="ddGrupoS" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddlRh" runat="server">
                    </asp:DropDownList>
                </td>      
                <td>&nbsp;</td>             
            </tr>
        </table>
        <br>
        <br>

            <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" Height="47px" 
            Width="232px" onclick="btn_Guardar_Click" />

        <asp:Label ID="lblRespuesta" runat="server" Text="Label"></asp:Label>

    </div>
</asp:Content>
