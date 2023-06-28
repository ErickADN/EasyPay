using System;
using System.Web.UI;

namespace EasyPayCliente
{
    public partial class Arriba : UserControl
    {
        // Aquí puedes agregar tus métodos y lógica adicional
        // Puedes suscribirte a eventos, manipular los controles dentro del control de usuario, etc.

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnTrasnferir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Depositar.aspx");
        }

        protected void btnTarjeta(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Tarjeta.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_CuentaBanc.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Diseño_Login.aspx");
            general.propietario = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarTarjeta.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Eliminar_CuentaBancaria.aspx");
        }

        protected void btnInicio(object sender, EventArgs e)
        {
            Response.Redirect("EasyPay_Principal.aspx");
        }
    }
}