<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Consultorio.Login" %>

    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title>Acceso Plataforma Virtual</title>
        <link href="/CSS/estilo.css" rel="stylesheet" type="text/css" />

        <style type="text/css">
            .style1 {
                height: 182px;
            }

            .style3 {
                height: 182px;
                width: 104px;
            }

            .style4 {
                width: 24px;
            }

            .style5 {
                width: 174px;
            }

            .style6 {
                width: 301px;
            }

            .style7 {
                height: 182px;
                width: 301px;
            }

            .style8 {
                width: 253px;
            }

            .style9 {
                width: 187px;
            }

            .style10 {
                width: 104px;
            }
        </style>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>

                <table style="width:100%;">
                    <tr>
                        <td class="style10">
                            <br><br> &nbsp;
                        </td>
                        <td class="style6">
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style10">
                            <img alt="ministerio de la salud" src="/Imagen/LogoGobierno.png" /> </td>
                        <td class="style6">
                            <center>
                                <asp:Label ID="Label4" runat="server" Text="ACCESO PLATAFORMA VIRTUAL CONSULTORIO"></asp:Label>
                            </center>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                        </td>
                        <td class="style7">
                            <table style="width: 96%; height: 173px;">
                                <tr>
                                    <td class="style4">
                                        &nbsp;</td>
                                    <td class="style5">
                                        &nbsp;</td>

                                </tr>
                                <tr>
                                    <td class="style4">
                                        <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
                                    </td>
                                    <td class="style5">
                                        <asp:TextBox ID="txtUsuario" runat="server" Width="139px"></asp:TextBox>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="style4">
                                        <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
                                    </td>
                                    <td class="style5">
                                        <asp:TextBox ID="txtPass" TextMode="Password" runat="server" Width="137px"></asp:TextBox>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="style4">
                                        &nbsp;</td>
                                    <td class="style5">
                                        <asp:RequiredFieldValidator ID="valUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Debe ingresar Usuario"></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                            </table>
                        </td>
                        <td class="style1">
                        </td>
                    </tr>
                </table>
                <table style="width: 100%;">
                    <tr>
                        <td class="style8">
                            &nbsp;
                        </td>
                        <td class="style9">
                            &nbsp;
                            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Height="71px" onclick="btnIngresar_Click" Width="160px" class="button"
                            />
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            &nbsp;
                        </td>
                        <td class="style9">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            &nbsp;
                        </td>
                        <td class="style9">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </div>
        </form>
        <footer id="footer">
            <center>
                <asp:Label ID="Label1" runat="server" Text="@ConsultorioWebNet"></asp:Label>
            </center>
        </footer>
    </body>

    </html>