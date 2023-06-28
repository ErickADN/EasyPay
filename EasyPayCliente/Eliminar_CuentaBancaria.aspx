<%@ Register Src="Arriba.ascx" TagName="cabecera" TagPrefix="cabe" %>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar_CuentaBancaria.aspx.cs" Inherits="EasyPayCliente.Eliminar_CuentaBancaria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            margin-left: 0px;
            font-weight: bold;
        }
        .auto-style5 {
            width: 362px;
        }
        .auto-style6 {
            height: 23px;
            width: 362px;
        }
        .auto-style7 {
            text-align: center;
            width: 401px;
        }
        .auto-style8 {
            height: 23px;
            text-align: center;
            width: 401px;
        }
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            width: 401px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
                        <cabe:cabecera runat="server" ID="MiControl" />

        <div><H1 style="background-color: #3366CC; color: #FFFFFF" class="auto-style10">ELIMINAR CUENTA BANCARIA</H1>
        </div>
        
        <table style="width:100%;">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:TextBox placeholder="Ingrese Nro de Cuenta Bancaria" ID="txtNroCuenta" runat="server" Height="39px" Width="305px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style8">
                    <asp:TextBox placeholder="Ingrese RUC del usuario" ID="txtRuc" runat="server" Height="39px" Width="305px"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:TextBox placeholder="Ingrese Contraseña" ID="txtContra" runat="server" Height="39px" Width="305px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <strong>
                    <asp:Button ID="btnEliminar" runat="server" CssClass="auto-style4" Height="43px" Text="ELIMINAR" Width="167px" BackColor="#3366CC" ForeColor="White" OnClick="btnEliminar_Click" />
                    </strong>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
    </form>
</body>
</html>
