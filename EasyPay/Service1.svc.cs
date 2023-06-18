using System;
using System.Collections.Generic;
using System.Data;
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
            //cn = new SqlConnection("Data Source=MIGUEL-PC;Initial Catalog=BDEasyPay;User ID=sa; Password = 123");
            //Data Source=DESKTOP-PRPBOIM; Initial Catalog = BDEasyPay; User ID =sa; Password=12345678 Henry
            //Data Source=DESKTOP-DCDV5K7; Initial Catalog = BDEasPay; User ID =sa; Password=12345678 Alvaro
            cn= new SqlConnection("Data Source=DESKTOP-SS5KA63;Initial Catalog=BDEasyPay;Integrated Security=True");
            /*cn = new SqlConnection("data source=DESKTOP-GVB16UV;" +
                    "initial catalog=BDEasyPay;" +
                    "User ID= usuario1;Password= 1234");//Erick */
            cn.Open();
        }
        public void conexionReniec()
        {
            cn = new SqlConnection("data source=DESKTOP-GVB16UV;" +
                    "initial catalog=RENIEC;" +
                    "User ID= usuario1;Password= 1234");//Erick
            cn.Open();
        }
        public void conexionSunat()
        {
            cn = new SqlConnection("data source=DESKTOP-GVB16UV;" +
                    "initial catalog=SUNAT;" +
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

        public bool guardarUsuarioReniec(string dni, string nombre, string apellido, string contraseña, string celular, string direccion,string fechaNacimiento)
        {
            conexionReniec();
            
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
                string sql2 = "insert into Usuario values(@Dni,@Nombre,@Apellido,@Contraseña,@Celular,@Direccion)";
                cmd = new SqlCommand(sql2, cn);
                reniec objReniec2 = new reniec();
                objReniec2.Dni = dni;
                objReniec2.Nombre = nombre;
                objReniec2.Apellido = apellido;
                objReniec2.Contraseña = contraseña;
                objReniec2.Celular = celular;
                objReniec2.Direccion = direccion;

                cmd.Parameters.Add("@Dni", System.Data.SqlDbType.VarChar).Value = objReniec2.Dni;
                cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = objReniec2.Nombre;
                cmd.Parameters.Add("@Apellido", System.Data.SqlDbType.VarChar).Value = objReniec2.Apellido;
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
        public bool guardarEmpresaSunat(string ruc, string nombrelegal, string direccioncorreoelectronico, string direccion, string contraseña)
        {
            conexionSunat();
            string sql = "select * from EMPRESA where ruc=@ruc and Nombrelegal=@Nombrelegal and direccioncorreoelectronico=@direccioncorreoelectronico and Direccion =@Direccion";
            cmd = new SqlCommand(sql, cn);
            sunat objSunat = new sunat();
            objSunat.Ruc = ruc;
            objSunat.Nombrelegal = nombrelegal;
            objSunat.Direccioncorreoelectronico = direccioncorreoelectronico;
            objSunat.Direccion = direccion;
           

            cmd.Parameters.Add("@ruc", System.Data.SqlDbType.VarChar).Value = objSunat.Ruc;
            cmd.Parameters.Add("@Nombrelegal", System.Data.SqlDbType.VarChar).Value = objSunat.Nombrelegal;
            cmd.Parameters.Add("@direccioncorreoelectronico", System.Data.SqlDbType.VarChar).Value = objSunat.Direccioncorreoelectronico;
            cmd.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar).Value = objSunat.Direccion;


            dr = cmd.ExecuteReader();
            bool insertado = false;
            if (dr.Read())
            {
                conexion();
                string sql2 = "insert into EMPRESA values(@Ruc,@Nombrelegal,@Direccioncorreoelectronico,@Direccion,@Contraseña)";
                cmd = new SqlCommand(sql2, cn);
                sunat objSunat2 = new sunat();
                objSunat2.Ruc = ruc;
                objSunat2.Nombrelegal = nombrelegal;
                objSunat2.Direccioncorreoelectronico = direccioncorreoelectronico;
                objSunat2.Direccion = direccion;
                objSunat2.Contraseña = contraseña;


                cmd.Parameters.Add("@Ruc", System.Data.SqlDbType.VarChar).Value = objSunat2.Ruc;
                cmd.Parameters.Add("@Nombrelegal", System.Data.SqlDbType.VarChar).Value = objSunat2.Nombrelegal;
                cmd.Parameters.Add("@Direccioncorreoelectronico", System.Data.SqlDbType.VarChar).Value = objSunat2.Direccioncorreoelectronico;
                cmd.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar).Value = objSunat2.Direccion;
                cmd.Parameters.Add("@Contraseña", System.Data.SqlDbType.VarChar).Value = objSunat2.Contraseña;


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

        public bool login(string dni, string pass)
        {
            //gfg
            conexion();
            DataTable tablita = new DataTable();
            string sentencia = "select * from Usuario where Dni=@Dni and Contraseña=@Contraseña";
            cmd = new SqlCommand(sentencia, cn);
            Usuario objUsuario = new Usuario();
            objUsuario.Dni = dni;
            objUsuario.Contraseña = pass;
            cmd.Parameters.Add("@Dni", System.Data.SqlDbType.VarChar).Value = objUsuario.Dni;
            cmd.Parameters.Add("@Contraseña", System.Data.SqlDbType.VarChar).Value = objUsuario.Contraseña;
            ada = new SqlDataAdapter(cmd);
            ada.Fill(tablita);
            bool ingresa = false;
            if (tablita.Rows.Count > 0)
            {
                ingresa = true;
               
            }
            else
            {
                ingresa = false;
               
            }
            return ingresa;
        }

        public bool eliminarTarjetaEasyPay(string nrotarjeta, string dniusuario, string contra)
        {
            conexion();
            string consulta1 = "SELECT * FROM Usuario where Contraseña=@Contraseña";
            cmd = new SqlCommand(consulta1,cn);
            Usuario objUsuario = new Usuario();
            objUsuario.Contraseña = contra;
            cmd.Parameters.Add("@Contraseña ", System.Data.SqlDbType.VarChar).Value = objUsuario.Contraseña;
            dr = cmd.ExecuteReader();
            bool consultado = false;
            if(dr.Read())
            {
                conexion();
                string consulta2= "DELETE FROM tarjeta where NroTarjeta=@NroTarjeta AND dniUsuario=@dniUsuario";
                cmd = new SqlCommand(consulta2, cn);
                TarjetaEasyPay objTarjetaEasyPay = new TarjetaEasyPay();
                objTarjetaEasyPay.Nrotarjeta = nrotarjeta;
                objTarjetaEasyPay.Dniusuario = dniusuario;
                cmd.Parameters.Add("@dniUsuario", System.Data.SqlDbType.VarChar).Value = objTarjetaEasyPay.Dniusuario;
                cmd.Parameters.Add("@NroTarjeta", System.Data.SqlDbType.VarChar).Value = objTarjetaEasyPay.Nrotarjeta;
                int eliminado = cmd.ExecuteNonQuery();
                if(eliminado > 0)
                {
                    consultado = true;
                }
                else
                {
                    consultado = false;
                }
                
            }
            return consultado;
        }
    }
}
    

