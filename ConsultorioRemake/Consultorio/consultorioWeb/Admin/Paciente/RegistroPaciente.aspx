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
                <td>-<asp:TextBox ID="txt_dv" runat="server" Width="35px"></asp:TextBox>
                </td>
                <td><asp:Button ID="btn_Buscar" runat="server" Text="Buscar" onclick="btn_Buscar_Click" 
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
                <td>Género<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        SelectMethod="ReadAll" TypeName="capaNegocio.GeneroColeccion">
                    </asp:ObjectDataSource>
                </td>
                <td>Nacionalidad<asp:ObjectDataSource ID="ObjectDataSource6" runat="server" 
                        SelectMethod="ReadAll" TypeName="capaNegocio.NacionalidadColeccion">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_Fecha" TextMode="Date" runat="server" style="height: 22px"></asp:TextBox>
                </td>

                <td><asp:Label ID="lbl_Edad" runat="server" Text=" "></asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddGenero" runat="server" DataSourceID="ObjectDataSource1" 
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddNacionalidad" runat="server" 
                        DataSourceID="ObjectDataSource6" DataTextField="Nombre" 
                        DataValueField="Id">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">&nbsp;</td>
            </tr>
            <tr>
                <td>Domicilio>
                <td>Comuna<asp:ObjectDataSource ID="ObjectDataSource4" runat="server" 
                        SelectMethod="ReadAll" TypeName="capaNegocio.ComunaColeccion">
                    </asp:ObjectDataSource>
                </td>
                <td>Sector<asp:ObjectDataSource ID="ObjectDataSource5" runat="server" 
                        SelectMethod="ReadAll" TypeName="capaNegocio.SectorColeccion">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>                
                <td><asp:TextBox ID="txt_Domicilio" runat="server"></asp:TextBox></td>
                <td>
                    <asp:DropDownList ID="ddComuna" runat="server" DataSourceID="ObjectDataSource4" 
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddSector" runat="server" DataSourceID="ObjectDataSource5" 
                        DataTextField="Nombre" DataValueField="Id">
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
                    <asp:DropDownList ID="ddGrupoS" runat="server" DataSourceID="ObjectDataSource7" 
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="ObjectDataSource7" runat="server" 
                        SelectMethod="ReadAll" TypeName="capaNegocio.GrupoSanguineoColeccion">
                    </asp:ObjectDataSource>
                </td>
                <td>
                    <asp:DropDownList ID="ddRh" runat="server" DataSourceID="ObjectDataSource8" 
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="ObjectDataSource8" runat="server" 
                        SelectMethod="ReadAll" TypeName="capaNegocio.Rh_sanguineoColeccion">
                    </asp:ObjectDataSource>
                </td>      
                <td>&nbsp;</td>             
            </tr>
        </table>
        <br>
        <br>

            <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" Height="47px" 
            Width="232px" />
               <asp:Button ID="btnAtras" runat="server" Text="Atras" Height="47px" 
            Width="232px" onclick="btnAtras_Click" />

        <asp:Label ID="lblRespuesta" runat="server" Text="Label"></asp:Label>
    
    </div>
</asp:Content>
