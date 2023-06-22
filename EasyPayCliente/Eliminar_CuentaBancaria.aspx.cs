using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class Eliminar_CuentaBancaria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();
        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            string ruc, contraseña,numeroCuenta;
            numeroCuenta = txtNroCuenta.Text;
            ruc = txtRuc.Text;
            contraseña = txtContra.Text;

            bool eliminado = serviceEasyPay.eliminarCuentaBancaria(ruc, contraseña, numeroCuenta);

            if (eliminado == true)
            {
                string script = "<script>alert('¡ELIMINADO CORRECTAMENTE!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
            else {
                string script = "<script>alert('¡NO SE LOGRO ELIMINAR VERIFIQUE SUS DATOS!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }

        }
    }
}