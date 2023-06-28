<%@ Register Src="Arriba.ascx" TagName="cabecera" TagPrefix="cabe" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Depositar.aspx.cs" Inherits="EasyPayCliente.Depositar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 441px;
        }
        .auto-style3 {
            width: 441px;
            height: 75px;
        }
        .auto-style4 {
            height: 75px;
        }
        .auto-style5 {
            width: 441px;
            height: 76px;
        }
        .auto-style6 {
            height: 76px;
        }
        .auto-style7 {
            text-align: center;
            width: 697px;
        }
        .auto-style8 {
            height: 76px;
            text-align: center;
            width: 697px;
        }
        .auto-style9 {
            height: 75px;
            text-align: center;
            width: 697px;
        }
        .auto-style10 {
            width: 697px;
        }
        .auto-style11 {
            font-weight: bold;
            font-size: medium;
        }
        .auto-style12 {
            color: #FFFFFF;
            background-color: #6666FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <cabe:cabecera runat="server" ID="MiControl" />
        <center><h1 class="auto-style12">Depositar</h1></center>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtNroTarjeta" placeholder="Ingresa Nro Tarjeta" runat="server" Height="30px" Width="250px"></asp:TextBox>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtCantidad" placeholder="Ingresa Cantidad" runat="server" Height="30px" Width="250px"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">
                    <strong>
                    <asp:Button ID="btnRegistrar" runat="server" Height="43px" Text="Registrar" Width="258px" BackColor="#3333FF" CssClass="auto-style11" ForeColor="White" OnClick="btnRegistrar_Click" />
                    </strong>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
