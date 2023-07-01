using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyPayCliente
{
    public partial class EliminarTarjeta : System.Web.UI.Page
    {
        ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();
        string  dni = general.propietario;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable tarjetas = new DataTable();
            tarjetas.Columns.Add("NroTarjeta");
            DataSet data = serviceEasyPay.tarjetas(dni);
            if (data != null && data.Tables.Count > 0)
            {
                DataTable dataTable = data.Tables[0]; 

                foreach (DataRow row in dataTable.Rows)
                {
                    tarjetas.Rows.Add(row["NroTarjeta"].ToString());
                }
            }
            dpdTarjetas.DataSource = tarjetas;
            dpdTarjetas.DataTextField = "NroTarjeta";
            dpdTarjetas.DataBind();
        }

        
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string  contraseña, numeroTarjeta;
            numeroTarjeta = dpdTarjetas.Text;
            
            contraseña = txtContra.Text;

            bool eliminado = serviceEasyPay.eliminarTarjetaEasyPay(numeroTarjeta, dni, contraseña);

            if (eliminado == true)
            {
                string script = "<script>alert('¡ELIMINADO CORRECTAMENTE!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
            else
            {
                string script = "<script>alert('¡NO SE LOGRO ELIMINAR VERIFIQUE SUS DATOS!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
        }
    }
}