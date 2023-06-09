﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class EasyPay_Principal : System.Web.UI.Page
    {
        ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = general.propietario;
            lblsaldo0.Text= serviceEasyPay.saldo(usuario);
            if(lblsaldo0.Text == null)
            {
                lblsaldo0.Text = "0";

            }
        }

        protected void btncerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnlogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("EasyPay_Principal.aspx");
        }

       

        protected void btntarjeta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Tarjeta.aspx");
        }

        protected void btncuenta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_CuentaBanc");
        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Enviar.aspx");
        }
    }
}