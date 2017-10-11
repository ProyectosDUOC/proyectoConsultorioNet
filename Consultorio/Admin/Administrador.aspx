<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Consultorio.Admin.Administrador" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <style type="text/css">
            .style1 {
                width: 608px;
            }

            .style2 {
                width: 141px;
            }

            .style4 {
                width: 193px;
            }

            .style6 {
                width: 404px;
            }

            .style7 {
                width: 20px;
            }
            .style8
            {
                width: 141px;
                height: 198px;
            }
            .style9
            {
                width: 20px;
                height: 198px;
            }
            .style10
            {
                height: 198px;
            }
            .style12
            {
                width: 309px;
            }
            .style13
            {
                width: 146px;
            }
        </style>
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div>

                <table style="width:100%;">
                    <tr>
                        <td class="style2">&nbsp;</td>
                        <td class="style7">&nbsp;</td>
                        <td class="style1">
                            <h1 style="width: 751px">PANEL ADMINISTRADOR</h1>
                        </td>
                        <td>
                            <asp:Label ID="lblFecha" runat="server" Text="Fecha: "></asp:Label>
                        </td>
                        <td class="style4">
                            <asp:Button ID="btn_CerrarSesion" runat="server" Text="Cerrar sesión" Width="188px" Height="55px"
                                onclick="btn_CerrarSesion_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            <img alt="" src="/Imagen/Foto3.jpg" style="height: 194px; width: 186px" /></td>
                        <td class="style9"></td>
                        <td class="style10">
                            <table>
                                <tr>
                                    <td>Nombre : </td>
                                    <td class="style6">
                                        <asp:Label ID="lbl_Nombre" runat="server" Text=" "></asp:Label>
                                        Carlos Orellana</td>
                                </tr>
                                <tr>
                                    <td>Rut :</td>
                                    <td class="style6">
                                        <asp:Label ID="lbl_rut" runat="server" Text=" "></asp:Label>
                                        11.111.111-1</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">&nbsp;</td>

                    </tr>
                </table>
                <center>

    <table style="width: 100%;">
        <tr>
            <td class="style13">
                <asp:Button ID="btnSector" runat="server" Text="Sector" 
                    onclick="btnSector_Click" />
            </td>
            <td class="style12">
                <img alt="/Imagen/Iconos/001-personas-1.png" 
                    src="/Imagen/Iconos/001-personas-1.png" style="height: 44px; width: 79px" />&nbsp;<asp:Button ID="btn_Paciente" runat="server" 
                    Text="Paciente" Height="43px" Width="235px" onclick="btn_Paciente_Click" />
            </td>
        </tr>
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style12">
                <img alt="" src="/Imagen/Iconos/016-enfermera-1.png" 
                    style="height: 49px; width: 100px" />&nbsp;<asp:Button ID="btn_Enfermera" runat="server" 
                    Text="Enfermera" Height="53px" Width="234px" onclick="btn_Enfermera_Click"
                    />
            </td>
        </tr>
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style12">
                <img alt="" src="/Imagen/Iconos/021-doctor-2.png" 
                    style="height: 58px; width: 80px" /><asp:Button ID="btn_Medico" runat="server" Text="Medico" 
                    Height="39px" Width="233px" onclick="btn_Medico_Click" />
            </td>
        </tr>
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style12">
                <img alt="" src="/Imagen/Iconos/006-estuche.png" 
                    style="height: 62px; width: 92px" /><asp:Button ID="btn_Secretaria" runat="server" 
                    Text="Secretaria" Height="35px" 
                        Width="238px" onclick="btn_Secretaria_Click" />
            </td>
        </tr>
    </table>
                </center>
            </div>
    </asp:Content>