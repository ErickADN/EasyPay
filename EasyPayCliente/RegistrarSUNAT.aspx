<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarSUNAT.aspx.cs" Inherits="EasyPayCliente.RegistrarSUNAT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style11 {
            font-weight: bold;
            font-size: large;
            text-decoration: underline;
            color: #00FFCC;
        }
        .auto-style12 {
            text-align: left;
            width: 238px;
        }
        .auto-style13 {
            height: 26px;
            text-align: left;
            width: 238px;
        }
        .auto-style18 {
            text-align: left;
            height: 42px;
            width: 238px;
        }
        .auto-style33 {
            width: 189px;
            height: 42px;
            text-align: left;
        }
        .auto-style34 {
            width: 107px;
            height: 26px;
            text-align: left;
        }
        .auto-style38 {
            height: 23px;
            width: 107px;
            text-align: left;
        }
        .auto-style39 {
            height: 23px;
            width: 107px;
        }
        .auto-style40 {
            width: 107px;
        }
        .auto-style41 {
            color: #3366CC;
        }
        .auto-style43 {
            height: 23px;
            width: 189px;
        }
        .auto-style44 {
            width: 189px;
        }
        .auto-style45 {
            width: 262px;
        }
        .auto-style46 {
            height: 23px;
            width: 262px;
        }
        .auto-style47 {
            width: 262px;
            text-align: right;
            font-size: x-large;
            color: #00FFFF;
        }
        .auto-style48 {
            width: 262px;
            height: 42px;
            text-align: right;
            font-size: x-large;
            color: #3366CC;
        }
        .auto-style49 {
            width: 262px;
            height: 26px;
            text-align: right;
            font-size: x-large;
            color: #3366CC;
        }
        .auto-style50 {
            width: 107px;
            text-align: left;
        }
        .auto-style51 {
            font-size: x-large;
            color: #00FFFF;
        }
        .auto-style53 {
            width: 107px;
            height: 42px;
        }
        .auto-style54 {
            width: 189px;
            text-align: left;
        }
        .auto-style55 {
            width: 189px;
            height: 26px;
            text-align: left;
        }
        .auto-style56 {
            width: 262px;
            text-align: right;
            font-size: x-large;
            color: #3366CC;
        }
    </style>
</head>
<body style="background-color:white">
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <br />
        <br />
        <br />
        <center><h1 class="auto-style41" style="color: #FFFFFF; background-color: #3366CC;">REGISTRAR EMPRESA</h1></center>
        <table style="width:100%;">
            <tr>
                <td class="auto-style56">
                        <strong>RUC:</strong></td>
                <td class="auto-style54">
                    <asp:TextBox ID="txtruc" runat="server" Height="23px" Width="194px"></asp:TextBox>
                </td>
                <td class="auto-style50">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style47">
                    <p class="auto-style51">
                        <strong><span class="auto-style41">Nombre Legal:</span></strong></p>
                </td>
                <td class="auto-style54">
                    <asp:TextBox ID="txtNombre" runat="server" Height="26px" Width="194px"></asp:TextBox>
                </td>
                <td class="auto-style40">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">
                        <strong>&nbsp;Correo Electrónico:</strong></td>
                <td class="auto-style54">
                    <asp:TextBox ID="txtcorreo" runat="server" Height="26px" Width="194px"></asp:TextBox>
                </td>
                <td class="auto-style40">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style48">
                        <strong>Dirección:</strong></td>
                <td class="auto-style33">
                    <asp:TextBox ID="txtdireccion" runat="server" Height="26px" Width="195px"></asp:TextBox>
                </td>
                <td class="auto-style53">
                    &nbsp;</td>
                <td class="auto-style18">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style49">
                        <strong>Contraseña:</strong></td>
                <td class="auto-style55">
                    <asp:TextBox ID="txtcontraseña" runat="server" Height="26px" Width="194px"></asp:TextBox>
                </td>
                <td class="auto-style34">
                    &nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style46"></td>
                <td class="auto-style43"></td>
                <td class="auto-style39"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style46"></td>
                <td class="auto-style43">
                    <strong>
                    <asp:Button ID="btnRegistrar" runat="server" Height="26px" Text="REGISTRAR" Width="190px" BackColor="#00FFCC" BorderStyle="None" CssClass="auto-style11" ForeColor=" #3366CC" OnClick="btnRegistrar_Click" />
                    </strong>
                </td>
                <td class="auto-style38"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style45">&nbsp;</td>
                <td class="auto-style44">&nbsp;</td>
                <td class="auto-style40">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style45">&nbsp;</td>
                <td class="auto-style44">&nbsp;</td>
                <td class="auto-style40">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>