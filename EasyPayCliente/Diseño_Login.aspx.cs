﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class Diseño_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string contraseña, usuario;
            contraseña = txtpass.Text;
            usuario = txtnumero.Text;

            ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();

            bool existe = serviceEasyPay.login(usuario, contraseña);

            if (existe == true)
            {

                general.propietario = usuario;
                Response.Redirect("EasyPay_Principal.aspx");
            }
            else
            {
                string script = "<script>alert('¡DATOS INCORRECTOS!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
        }
    }
}