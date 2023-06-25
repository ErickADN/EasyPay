using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EasyPay
{
    
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {   
        
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        bool guardarUsuarioReniec(String dni, String nombre, String apellido, String contraseña, String celular, String direccion,String fechaNacimiento);

        [OperationContract]
        bool guardarEmpresaSunat(string ruc, string nombrelegal, string direccioncorreoelectronico, string direccion, string contraseña);

        [OperationContract]
        bool login(string dni, string pass);

        [OperationContract]
        bool eliminarCuentaBancaria(string ruc, string contraseña,string NumeroCuenta);
        [OperationContract]
        bool eliminarTarjetaEasyPay(string nrotarjeta, string dniusuario, string contra);
        [OperationContract]
        bool insertarCuentaBancaria(string NumeroCuenta, string TipoCuenta, string RUC, string Direccion, int CodigoSwift);
        [OperationContract]
        bool guardartarjeta(string nrotarjeta, string tipotarjeta, string fechavencimiento, string codigoseguridad, string direcciontarjeta, string dniusuario);
        [OperationContract]
        string saldo(string usuario);
        [OperationContract]
        string depositar(string nrotarjeta, string cantidad,string propietario);
        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
