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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btningresar_Click(object sender, EventArgs e)
        {
            string contraseña, usuario;
            contraseña = txtpass.Text;
            usuario = txtusuario.Text;

            ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();

            bool existe =serviceEasyPay.login(usuario, contraseña);

            if (existe == true)
            {

                Response.Redirect("Reg_User_Reniec.aspx");
            }
            else
            {
                string script = "<script>alert('¡DATOS INCORRECTOS!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
        }
    }
}