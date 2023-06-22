<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EasyPay_Principal.aspx.cs" Inherits="EasyPayCliente.EasyPay_Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 40px;
        }
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
        <div class="auto-style1" style="background-color: #3366CC">
            <asp:ImageButton ID="btnlogo" runat="server" Height="40px" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWEnUyGOBPtr28gq13D89AxB-w0MS4IoRfInee5qwsm5eMub8yzHSepBszmb5lkNeMoWs&usqp=CAU" OnClick="btnlogo_Click" Width="40px" />
            <asp:Button ID="btntransferir" runat="server" BackColor="#3366CC" ForeColor="White" Height="40px" Text="Transferir fondos" Width="110px" />
            <asp:Button ID="btntarjeta" runat="server" BackColor="#3366CC" ForeColor="White" Height="40px" Text="Insertar tarjeta" Width="110px" OnClick="btntarjeta_Click" />
            <asp:Button ID="btncuenta" runat="server" BackColor="#3366CC" ForeColor="White" Height="40px" Text="Insertar cuenta bancaria" Width="160px" OnClick="btncuenta_Click" />
            <asp:Button ID="btnmovimiento" runat="server" BackColor="#3366CC" ForeColor="White" Height="40px" Text="Movimientos" Width="100px" />
            <asp:Button ID="btnchatbot" runat="server" BackColor="#3366CC" ForeColor="White" Height="40px" Text="Chatbot" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btncerrar" runat="server" BackColor="#3366CC" ForeColor="White" Height="40px" OnClick="btncerrar_Click" Text="Cerrar sesion" Width="100px" />
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8" style="font-size: x-large; color: #0000CC;">Saldo de EasyPay</td>
                <td class="auto-style9">
                    <asp:Button ID="btnenviar" runat="server" BackColor="Yellow" Font-Bold="True" ForeColor="#0000CC" Height="50px" Text="Enviar" Width="150px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="btnsolicitar" runat="server" BackColor="Yellow" Font-Bold="True" ForeColor="#0000CC" Height="50px" Text="Solicitar" Width="150px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblsaldo" runat="server" Font-Size="XX-Large" ForeColor="Blue" Text="$ALDO"></asp:Label>
                </td>
                <td class="auto-style6"></td>
                <td class="auto-style11"></td>
            </tr>
        </table>
    </form>
</body>
</html>
