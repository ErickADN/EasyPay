using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class Reg_User_Reniec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();

            string dni, nombre, apellido, contraseña, celular, direccion,fechaNacimiento;
            

            dni = txtdni.Text;
            nombre = txtnombre.Text;
            apellido = txtapellido.Text;
            contraseña = txtcontraseña.Text;
            celular = txtcelular.Text;
            direccion = txtdireccion.Text;
            fechaNacimiento = txtfechanacimiento.Text;

            bool registrado = serviceEasyPay.guardarUsuarioReniec(dni, nombre, apellido, contraseña, celular, direccion, fechaNacimiento);
            if (registrado == true)
            {
                string script = "<script>alert('¡REGISTRO CORRECTO!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
                Response.Redirect("Login.aspx");
            }
            else
            {
                string script = "<script>alert('¡NO SE LOGRO REGISTRARTE VUELVE A INTENTAR!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
            

        }
    }
}