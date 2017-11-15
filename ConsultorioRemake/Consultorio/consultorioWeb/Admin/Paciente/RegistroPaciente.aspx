<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="RegistroPaciente.aspx.cs" Inherits="consultorioWeb.Admin.Paciente.RegistroPaciente" %>
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
                <td><asp:TextBox ID="txt_nFicha" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txt_Rut" TextMode="Number" runat="server"></asp:TextBox></td>
                <td>-<asp:TextBox ID="txt_dv" runat="server" MaxLength="1" Width="35px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" onclick="btn_Buscar_Click" 
                         /></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="*Ingrese Rut" ForeColor="Red" ControlToValidate="txt_Rut"></asp:RequiredFieldValidator>
                    <br/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_dv" ForeColor="Red"
                    ErrorMessage="*Ingrese Dv"></asp:RequiredFieldValidator>
                    </td>
                
                <td>
        <asp:Label ID="lblRespuesta" runat="server" ForeColor="Red" Text=""></asp:Label>
    
                    <asp:Button ID="btnHabilitar" runat="server" Text="Habilitar Edicion" onclick="btnHabilitar_Click" 
                         />
                    </td>
                
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
                <td>Nacionalidad</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_Fecha" TextMode="Date" runat="server" style="height: 22px"></asp:TextBox>
                </td>

                <td><asp:Label ID="lbl_Edad" runat="server" Text=" "></asp:Label>
                    <asp:Label ID="lblAnios" runat="server" Text="0"></asp:Label>                 
                    <asp:Label runat="server" Text="años"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddGenero" runat="server"
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddNacionalidad" runat="server" 
                        DataTextField="Nombre" 
                        DataValueField="Id">
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
                <td><asp:TextBox ID="txt_Domicilio" runat="server"></asp:TextBox></td>
                <td>
                    <asp:DropDownList ID="ddComuna" runat="server" 
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddSector" runat="server"  
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                </td>                   
            </tr>
            <tr>
                <td class="style2">&nbsp;</td>
            </tr>
            <tr>
                <td>Fono 1</td>
                <td>Fono 2</td>
            </tr>
            <tr>                
                <td><asp:TextBox ID="txt_fono1" TextMode="Number"  runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txt_fono2" TextMode="Number" runat="server"></asp:TextBox></td>                  
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
                    <asp:DropDownList ID="ddGrupoS" runat="server" 
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddRh" runat="server"
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                </td>      
                <td>&nbsp;</td>             
            </tr>
        </table>
        <br>
        <br>

            <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" Height="47px" 
            Width="232px" onclick="btn_Guardar_Click" />
            <a href="../PanelPaciente.aspx" 
            style="font-size: xx-large; font-weight: 700">Volver</a>
            
    </div>
</asp:Content>
