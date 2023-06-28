<%@ Register Src="Arriba.ascx" TagName="cabecera" TagPrefix="cabe" %>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_CuentaBanc.aspx.cs" Inherits="EasyPayCliente.Insert_CuentaBanc" %>

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
        </style>
</head>
<body style="text-align:center; height: 374px;">
    <form id="form1" runat="server">
                        <cabe:cabecera runat="server" ID="MiControl" />

        <div><H1 style="background-color: #3366CC; color: #FFFFFF">INSERTAR CUENTA DE BANCARIA</H1>
        </div>

        <div >
            <p>
                    
                    <asp:TextBox placeholder="Ingrese el numero" ID="txtnumero" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese el tipo de cuenta" ID="txttipo" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese el RUC" ID="txtruc" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese su direccion" ID="txtdireccion" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese el codigo swift" ID="txtswift" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>

        </div>

        <asp:Button ID="btnguardar" runat="server" BackColor="#3366CC" Font-Bold="True" Font-Names="Arial Black" ForeColor="White" Height="60px" OnClick="btnguardar_Click" Text="GUARDAR" Width="140px" />

    </form>
</body>
</html>