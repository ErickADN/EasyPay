<%@ Register Src="Arriba.ascx" TagName="cabecera" TagPrefix="cabe" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enviar.aspx.cs" Inherits="EasyPayCliente.Enviar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 75px;
        }
        .auto-style2 {
            font-weight: bold;
            font-size: medium;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            height: 75px;
            text-align: center;
        }
        .auto-style5 {
            height: 76px;
        }
        .auto-style6 {
            height: 76px;
            text-align: center;
        }
        .auto-style7 {
            width: 65px;
        }
        .auto-style8 {
            height: 75px;
            width: 65px;
        }
        .auto-style9 {
            height: 76px;
            width: 65px;
        }
        .auto-style10 {
            color: #FFFFFF;
            background-color: #6666FF;
        }
        .auto-style11 {
            width: 65px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <cabe:cabecera runat="server" ID="MiControl" />
        <center><h1 class="auto-style10">Enviar</h1></center>
        <table style="width:100%;">
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtDNI" placeholder="Ingresa DNI" runat="server" Height="30px" Width="250px"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCantidad" placeholder="Ingresa Cantidad" runat="server" Height="30px" Width="250px"></asp:TextBox>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3"><strong>
                    <asp:Button ID="btnRegistrar" runat="server" BackColor="#6666FF" CssClass="auto-style2" ForeColor="White" Height="43px" Text="Registrar" Width="258px" OnClick="btnRegistrar_Click" />
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
