<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginEasyPay.aspx.cs" Inherits="EasyPayCliente.LoginEasyPay" %>

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
<body style="text-align:center">
    <form id="form1" runat="server">
        <div >
            <H1>EASYPAY</H1></div>
        </br>
 
        <div >
            <p>
                    <asp:TextBox placeholder="Ingrese su correo electrónico o su Dni" ID="TextBox2" runat="server" Height="38px" Width="290px"></asp:TextBox>
                </p>
            <p>
                    &nbsp;</p>
            <p>
                    <asp:TextBox placeholder="Ingrese su contraseña" ID="TextBox3" runat="server" Height="38px" Width="290px"></asp:TextBox>
                </p>
            <asp:Button ID="btnLogin" runat="server" Height="53px" Text="Iniciar Sesión" Width="139px" OnClick="btnLogin_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" Height="53px" Text="Registrarse" Width="139px" />
        </div>
    </form>
    </body>
</html>
