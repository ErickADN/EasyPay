using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace EasyPayCliente
{
    public partial class Eliminar_CuentaBancaria : System.Web.UI.Page
    {
        ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();
        string ruc = general.propietario;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable tarjetas = new DataTable();
            tarjetas.Columns.Add("NroTarjeta");
            DataSet data = serviceEasyPay.tarjetas(ruc);
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

            string  contraseña,numeroCuenta;
            numeroCuenta = dpdTarjetas.Text;
            
            contraseña = txtContra.Text;

            bool eliminado = serviceEasyPay.eliminarCuentaBancaria(ruc, contraseña, numeroCuenta);

            if (eliminado == true)
            {
                string script = "<script>alert('¡ELIMINADO CORRECTAMENTE!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }
            else {
                string script = "<script>alert('¡NO SE LOGRO ELIMINAR VERIFIQUE SUS DATOS!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
            }

        }
    }
}