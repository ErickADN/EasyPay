<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Crear_Cuenta.aspx.cs" Inherits="EasyPayCliente.Crear_Cuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .gradiente {
          background: #ffe259;
          background:linear-gradient(to right, #ffa751,#ffe259);
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 392px;
        }
        .auto-style5 {
            width: 392px;
            height: 167px;
        }
        .auto-style6 {
            width: 392px;
            height: 23px;
        }
        </style>
</head>
<body style="text-align:center">
    <form id="form1" runat="server">
        <div><H1 style="background-color: #3366CC; color: #FFFFFF">CREA TU CUENTA EASY PAY GRATIS</H1>
        </div>

        <div >

            <p style="font-size: large; color: #808080; font-family: Century;">

                Puedes elegir entre 2 tipos de cuenta</p>

        </div>

        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <table class="auto-style2">
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image1" runat="server" Height="190px" Width="294px" ImageUrl="~/Properties/App_LocalResources/Images/cuenta_personal.jpg" />
                </td>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Image ID="Image2" runat="server" Height="190px" Width="294px" ImageUrl="~/Properties/App_LocalResources/Images/cuenta_empresarial.jpg" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style6" style="font-size: x-large; color: #000000; font-family: Century;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Personal</td>
                <td class="auto-style6" style="color: #000000; font-size: x-large; font-family: Century">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Empresarial</td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: Century; font-size: large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registrate desde la RENIEC</td>
                <td class="auto-style3" style="font-family: Century; font-size: large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registrate desde la SUNAT</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnregistrarpers" runat="server" BackColor="#3366CC" Font-Bold="True" Font-Names="Arial Black" ForeColor="White" Height="50px" Text="REGISTRATE SIN COSTO" Width="190px" OnClick="btnregistrarpers_Click" />
                </td>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnregistraremp" runat="server" BackColor="#3366CC" Font-Bold="True" Font-Names="Arial Black" ForeColor="White" Height="50px" Text="REGISTRATE SIN COSTO" Width="190px" OnClick="btnregistraremp_Click" />
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
