using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace EasyPayCliente
{
    public partial class Depositar : System.Web.UI.Page
    {

        ServicioEasyPay.Service1Client serviceEasyPay = new ServicioEasyPay.Service1Client();
        string dni = general.propietario;
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
        
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string cantidad, tarjeta,propietario;
            propietario = general.propietario;
            cantidad = txtCantidad.Text;
            tarjeta = dpdTarjetas.Text;
            string mensaje =serviceEasyPay.depositar(tarjeta, cantidad, propietario);

            string script = "<script>alert('¡"+mensaje+"!');</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);

            
        }
    }
}