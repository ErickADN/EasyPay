using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class Insert_CuentaBanc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();
        protected void btnguardar_Click(object sender, EventArgs e)
        {
            string tipo, ruc, codigoSwift, numeroCuentaBancaria, direccion;
            tipo = txttipo.Text;
            ruc = txtruc.Text;
            codigoSwift = txtswift.Text;
            numeroCuentaBancaria = txtnumero.Text;
            direccion = txtdireccion.Text;
           

            bool ingresado = serviceEasyPay.insertarCuentaBancaria(numeroCuentaBancaria, tipo, ruc, direccion,int.Parse(codigoSwift));
            if (ingresado == true)
            {
                string script = "<script>alert('¡TARJETA GUARDADA!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
            else
            {
                string script = "<script>alert('¡ERROR VERIFIQUE SUS DATOS!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
        }

        

    }
}