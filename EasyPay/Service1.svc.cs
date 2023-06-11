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
        SqlDataReader dr;
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
        public void conexionReniec()
        {
            cn = new SqlConnection("data source=DESKTOP-GVB16UV;" +
                    "initial catalog=RENIEC;" +
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

        public bool guardarUsuarioReniec(string dni, string nombre, string apellido, int edad, string contraseña, string celular, string direccion,string fechaNacimiento)
        {
            conexionReniec();
            SqlDataReader dr;
            string sql = "select * from Usuario where Dni=@Dni and Nombre=@Nombre and Apellido=@Apellido and Direccion =@Direccion and FechaNacimiento=@FechaNacimiento";
            cmd = new SqlCommand(sql, cn);
            reniec objReniec = new reniec();
            objReniec.Dni = dni;
            objReniec.Nombre = nombre;
            objReniec.Apellido = apellido;
            objReniec.Direccion = direccion;
            objReniec.FechaNacimiento = fechaNacimiento;

            cmd.Parameters.Add("@Dni", System.Data.SqlDbType.VarChar).Value = objReniec.Dni;
            cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = objReniec.Nombre;
            cmd.Parameters.Add("@Apellido", System.Data.SqlDbType.VarChar).Value = objReniec.Apellido;
            cmd.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar).Value = objReniec.Direccion;
            cmd.Parameters.Add("@FechaNacimiento", System.Data.SqlDbType.Date).Value = objReniec.FechaNacimiento;
            
            dr = cmd.ExecuteReader();
            bool insertado=false;
            if (dr.Read())
            {
                conexion();
                string sql2 = "insert into Usuario values(@Dni,@Nombre,@Apellido,@Edad,@Contraseña,@Celular,@Direccion)";
                cmd = new SqlCommand(sql2, cn);
                reniec objReniec2 = new reniec();
                objReniec2.Dni = dni;
                objReniec2.Nombre = nombre;
                objReniec2.Apellido = apellido;
                objReniec2.Edad = edad;
                objReniec2.Contraseña = contraseña;
                objReniec2.Celular = celular;
                objReniec2.Direccion = direccion;

                cmd.Parameters.Add("@Dni", System.Data.SqlDbType.VarChar).Value = objReniec2.Dni;
                cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = objReniec2.Nombre;
                cmd.Parameters.Add("@Apellido", System.Data.SqlDbType.VarChar).Value = objReniec2.Apellido;
                cmd.Parameters.Add("@Edad", System.Data.SqlDbType.Int).Value = objReniec2.Edad;
                cmd.Parameters.Add("@Contraseña", System.Data.SqlDbType.VarChar).Value = objReniec2.Contraseña;
                cmd.Parameters.Add("@Celular", System.Data.SqlDbType.VarChar).Value = objReniec2.Celular;
                cmd.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar).Value = objReniec2.Direccion;

                int registrado = cmd.ExecuteNonQuery();
                
                if (registrado > 0)
                {
                    insertado = true;
                }
                else
                {
                    insertado = false;
                }
                return insertado;
            }
            return insertado;
            
        }
    }
}
