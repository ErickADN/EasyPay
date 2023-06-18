<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg_User_Reniec.aspx.cs" Inherits="EasyPayCliente.Reg_User_Reniec" %>

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
        <div><H1 style="background-color: #3366CC; color: #FFFFFF">REGISTRO DE USUARIOS - RENIEC</H1>
        </div>

        <div >
            <p>
                    
                    <asp:TextBox placeholder="Ingrese su DNI" ID="txtdni" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese su Nombre" ID="txtnombre" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese su Apellido" ID="txtapellido" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese su Contraseña" ID="txtcontraseña" runat="server" Height="25px" Width="270px" TextMode="Password"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese su Celular" ID="txtcelular" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese su Direccion" ID="txtdireccion" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>
            <p>
                    <asp:TextBox placeholder="Ingrese su Fecha de Nacimiento DD/MM/YYYY" ID="txtfechanacimiento" runat="server" Height="25px" Width="270px"></asp:TextBox>
                </p>

            <asp:Button ID="btnRegister" runat="server" Height="60px" Text="REGISTRARSE" Width="140px" BackColor="#3366CC" Font-Bold="True" Font-Names="Arial Black" ForeColor="White" OnClick="btnRegister_Click" />
        </div>

    </form>
</body>
</html>