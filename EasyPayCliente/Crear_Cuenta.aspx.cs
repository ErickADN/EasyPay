using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class Crear_Cuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Interfaces para crear cuenta
        protected void btnregistrarpers_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reg_User_Reniec.aspx");
        }

        protected void btnregistraremp_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarSUNAT.aspx");
        }
    }
}