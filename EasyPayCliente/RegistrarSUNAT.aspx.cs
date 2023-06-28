using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class RegistrarSUNAT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ServicioEasyPay.Service1Client EasyPay = new ServicioEasyPay.Service1Client();
            string ruc, nombre, correo, direccion, contraseña;

            ruc = txtruc.Text;
            nombre = txtNombre.Text;
            correo = txtcorreo.Text;
            direccion = txtcorreo.Text;
            contraseña = txtcontraseña.Text;

            bool registrado =EasyPay.guardarEmpresaSunat(ruc, nombre, correo, direccion, contraseña);
            if (registrado == true)
            {
                string script = "<script>alert('¡REGISTRADO CORRECTAMENTE!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
                Response.Redirect("Diseño_Login.aspx");
               
            }
            else
            {
                string script = "<script>alert('¡FALLO EN EL REGISTRO !');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }

        }
    }
}