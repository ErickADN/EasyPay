using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class Depositar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string cantidad, tarjeta,propietario;
            propietario = general.propietario;
            cantidad = txtCantidad.Text;
            tarjeta = txtNroTarjeta.Text;
            string mensaje =serviceEasyPay.depositar(tarjeta, cantidad, propietario);

            string script = "<script>alert('¡"+mensaje+"!');</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);

            
        }
    }
}