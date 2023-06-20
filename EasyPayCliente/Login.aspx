<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EasyPayCliente.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 325px;
        }
        .auto-style3 {
            width: 325px;
        }
        .auto-style4 {
            width: 325px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div><center><h1 style="background-color: #3366CC; color: #FFFFFF">INICIAR SESION</h1></center></div></div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3" style="color: #3366CC">INGRESE USUARIO:</td>
                <td>
                    <asp:TextBox ID="txtusuario" runat="server" Width="174px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="color: #3366CC">INGRESE SU CONTRASEÑA:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtpass" runat="server" TextMode="Password" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Crear_Cuenta.aspx">NO TIENES CUENTA ENTRA AQUI</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btningresar" runat="server" Text="INGRESAR" Width="133px" OnClick="btningresar_Click" BackColor="#3366CC" Font-Bold="True" ForeColor="White" Height="34px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>