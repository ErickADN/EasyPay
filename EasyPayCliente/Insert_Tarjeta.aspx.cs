using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class Insert_Tarjeta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();
        protected void btnguardar_Click(object sender, EventArgs e)
        {
            string tipo, dni,codigoSeguridad,numeroTarjeta,direccion,FechaVencimiento;
            tipo = txttipo.Text;
            dni = txtDni.Text;
            codigoSeguridad = txtCodiigoSeguridad.Text;
            numeroTarjeta = txtnumero.Text;
            direccion = txtDireccion.Text;
            FechaVencimiento = txtFechaVencimiento.Text;

            bool ingresado =serviceEasyPay.guardartarjeta(numeroTarjeta, tipo, FechaVencimiento, codigoSeguridad, direccion, dni);
            if(ingresado==true){
                string script = "<script>alert('¡TARJETA GUARDADA!');</script>";
                
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
                Response.Redirect("Login.aspx");
            }
            else {
                string script = "<script>alert('¡ERROR VERIFIQUE SUS DATOS!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
        }

        

    }
}