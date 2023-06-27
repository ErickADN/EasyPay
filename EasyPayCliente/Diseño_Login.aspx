<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Diseño_Login.aspx.cs" Inherits="EasyPayCliente.Diseño_Login" %>

<!DOCTYPE html>
<html>
<head>
    <title>Iniciar sesión</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }
        
        /* Estilos para pantallas pequeñas (celulares) */
        @media only screen and (max-width: 600px) {
            body {
                font-size: 14px;
            }
        }
        
        /* Estilos para pantallas medianas (tablets) */
        @media only screen and (min-width: 601px) and (max-width: 1024px) {
            body {
                font-size: 16px;
            }
        }
        
        /* Estilos para pantallas grandes (computadoras de escritorio) */
        @media only screen and (min-width: 1025px) {

            body {
                font-size: 18px;
            }
        }

        .login-container {
            max-width: 400px;
            margin: 0 auto;
            margin-top: 100px;
            padding: 20px;
            background-color: white;
            border-radius: 5px;
            box-shadow: 0 0 5px rgba(0, 0, 0, 0.1);
        }

        .login-frame {
            border: 2px solid #ccc;
            padding: 20px;
            text-align: center;
            background-color:white;
        }

        .login-logo {
            max-width: 150px;
            margin-bottom: 20px;
        }
        .auto-style1 {
            font-weight: bold;
        }
    </style>
</head>
<body 
        <div class="login-container">
            <div class="login-frame">
                <img src="https://1000marcas.net/wp-content/uploads/2021/06/EasyPay-Logo.png" class="login-logo" alt="Logo">
                <h2 class="text-center">Iniciar sesión</h2>
                <form id="form1" runat="server">
                    <div class="form-group">
                        <label for="usuario">Usuario:</label>
                        <div>
                        <asp:TextBox  ID="txtnumero" runat="server" Height="25px" Width="300px"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="password">Contraseña:</label>
                        <div>
                        <asp:TextBox  ID="txtpass" runat="server" Height="25px" Width="300px"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Crear_Cuenta.aspx">NO TIENES CUENTA ENTRA AQUI</asp:HyperLink>
                    </div>
                    <%--<button type="submit" class="btn btn-primary btn-block" OnClick="btningresar_Click">Iniciar sesión</button>--%><strong>
                    <asp:Button ID="btnIngresar" runat="server" Text="Iniciar sesión" BackColor="#0066CC" CssClass="auto-style1" ForeColor="White" Height="36px" Width="199px" OnClick="btnIngresar_Click" />
 
                    </strong>
 
                </form>
            </div>
        </div>
    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</body>
</html>
