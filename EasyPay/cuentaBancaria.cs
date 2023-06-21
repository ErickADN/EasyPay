using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EasyPay
{
    [DataContract]
    public class cuentaBancaria
    {
        [DataMember]
        string nroCuenta;
        string codigoSwift;
        string TipoCuenta;
        string RUC;
        string Direccion;
        string propietario;
        string contraseña;

        public string NroCuenta { get => nroCuenta; set => nroCuenta = value; }
        public string CodigoSwift { get => codigoSwift; set => codigoSwift = value; }
        public string TipoCuenta1 { get => TipoCuenta; set => TipoCuenta = value; }
        public string RUC1 { get => RUC; set => RUC = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Propietario { get => propietario; set => propietario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}