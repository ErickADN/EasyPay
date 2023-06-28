<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Arriba.ascx.cs" Inherits="EasyPayCliente.Arriba" %>
<!DOCTYPE html>


<style>
        .botones {     
            background-color:cornflowerblue;
            border-style:none;
        }
        
</style>
<body>
        <div style="background-color:cornflowerblue">
            <asp:Panel ID="Panel1" runat="server">
                <div>
                    <asp:Button ID="Button1" runat="server" Text="INICIO" Height="40px" Width="118px" class="botones" OnClick="btnInicio" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnTrasnferir" runat="server" Text="Transferir Fondos" Height="40px" Width="118px" class="botones" OnClick="btnTrasnferir_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Height="40px" Text="Insertar Tarjeta" Width="102px"  CssClass="botones" OnClick="btnTarjeta"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="40px" Text="Insertar Cuenta Bancaria" Width="145px" class="botones" OnClick="Button2_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" Height="40px" Text="Quitar Tarjeta" Width="102px" class="botones" OnClick="Button5_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button6" runat="server" Height="40px" Text="Quitar Cuenta Bancaria" Width="136px" class="botones" OnClick="Button6_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="botonSuperior" runat="server" Height="40px" Text="Cerrar Sesion" Width="102px" Class="botones" OnClick="Button7_Click" />
                </div>
                
            </asp:Panel>
        </div>
</body>