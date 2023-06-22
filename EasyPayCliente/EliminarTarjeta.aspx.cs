using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class EliminarTarjeta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string dni, contraseña, numeroTarjeta;
            numeroTarjeta = txtNroTarjeta.Text;
            dni = txtDNI.Text;
            contraseña = txtContra.Text;

            bool eliminado = serviceEasyPay.eliminarTarjetaEasyPay(numeroTarjeta, dni, contraseña);

            if (eliminado == true)
            {
                string script = "<script>alert('¡ELIMINADO CORRECTAMENTE!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
            else
            {
                string script = "<script>alert('¡NO SE LOGRO ELIMINAR VERIFIQUE SUS DATOS!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
        }
    }
}