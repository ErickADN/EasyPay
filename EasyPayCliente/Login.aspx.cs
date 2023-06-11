using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceReference1.Service1Client easypay = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btningresar_Click(object sender, EventArgs e)
        {
            string contraseña, dni;
            bool ingresa;
            contraseña = txtpass.Text;
            dni = txtusuario.Text;
            ingresa = easypay.login(contraseña,dni);
            if (ingresa == true)
            {
                Response.Redirect("AddUsuario.aspx");
            }
            else
            {
                Response.Write("USUARIOS INCORRECTOS");
            }
        }
    }
}