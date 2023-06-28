<%@ Register Src="Arriba.ascx" TagName="cabecera" TagPrefix="cabe" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EasyPay_Principal.aspx.cs" Inherits="EasyPayCliente.EasyPay_Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 297px;
        }
        .auto-style4 {
            width: 284px;
        }
        .auto-style5 {
            width: 284px;
            height: 244px;
        }
        .auto-style6 {
            width: 297px;
            height: 244px;
        }
        .auto-style8 {
            width: 284px;
            height: 56px;
        }
        .auto-style9 {
            width: 297px;
            height: 56px;
        }
        .auto-style10 {
            height: 56px;
        }
        .auto-style11 {
            height: 244px;
        }
    </style>   
</head>
<body>   
    <form id="form1" runat="server">
        <cabe:cabecera runat="server" ID="MiControl" />
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8" style="font-size: x-large; color: #0000CC;">Saldo de EasyPay</td>
                <td class="auto-style9">
                    <asp:Button ID="btnenviar" runat="server" BackColor="Yellow" Font-Bold="True" ForeColor="#0000CC" Height="50px" Text="Enviar" Width="150px" OnClick="btnenviar_Click" />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblsaldo" runat="server" Font-Size="XX-Large" ForeColor="Blue" Text="SALDO"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblsaldo0" runat="server" Font-Size="XX-Large" ForeColor="Blue"></asp:Label>
                </td>
                <td class="auto-style11"></td>
            </tr>
        </table>
    </form>
</body>
</html>
