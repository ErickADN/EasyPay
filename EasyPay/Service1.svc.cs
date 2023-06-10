using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EasyPay
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter ada;
        public void conexion()
        {
            //SqlConnection("DataSource=MIGUEL-PC;Initial Catalog=BDEasyPay;User ID=sa; Password = 123");
            //Data Source=DESKTOP-PRPBOIM; Initial Catalog = BDEasyPay; User ID =sa; Password=12345678 Henry
            //Data Source=DESKTOP-DCDV5K7; Initial Catalog = BDEasPay; User ID =sa; Password=12345678 Alvaro
            //("Data Source=DESKTOP-SS5KA63;Initial Catalog=BDEasyPay;Integrated Security=True")Nazer
            cn = new SqlConnection("data source=DESKTOP-GVB16UV;" +
                    "initial catalog=BDEasyPay;" +
                    "User ID= usuario1;Password= 1234");//Erick
            cn.Open();
        }
        public void desconexion()
        {

            cn.Close();
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
