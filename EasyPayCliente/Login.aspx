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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div><center><h1>INICIAR SESION</h1></center></div></div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3">INGRESE USUARIO</td>
                <td>
                    <asp:TextBox ID="txtusuario" runat="server" Width="174px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">INGRESE SU CONTRASEÑA</td>
                <td>
                    <asp:TextBox ID="txtpass" runat="server" TextMode="Password" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AddUsuario.aspx">NO TIENES CUENTA ENTRA AQUI</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btningresar" runat="server" OnClick="btningresar_Click" Text="INGRESAR" Width="133px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
