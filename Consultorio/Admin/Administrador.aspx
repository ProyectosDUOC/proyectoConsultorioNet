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
                        <td class="style2">
                            <img alt="" src="/Imagen/Foto3.jpg" style="height: 194px; width: 186px" /></td>
                        <td class="style7">&nbsp;</td>
                        <td>
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
                    <asp:Button ID="btn_Paciente" runat="server" Text="Paciente" Height="100px" Width="300px" onclick="btn_Paciente_Click" />
                    <asp:Button ID="btn_Enfermera" runat="server" Text="Enfermera" Height="100px" Width="300px" onclick="btn_Enfermera_Click"
                    />
                    <asp:Button ID="btn_Medico" runat="server" Text="Medico" Height="100px" Width="300px" onclick="btn_Medico_Click" />
                    <asp:Button ID="btn_Secretaria" runat="server" Text="Secretaria" Height="100px" 
                        Width="300px" onclick="btn_Secretaria_Click" />
                </center>
            </div>
    </asp:Content>