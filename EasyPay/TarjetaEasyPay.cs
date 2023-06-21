using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EasyPay
{
    [DataContract]
    public class TarjetaEasyPay
    {
        [DataMember]
        private String nrotarjeta;
        private String tipotarjeta;
        private String fechavencimiento;
        private String codigoseguridad;
        private String direcciontarjeta;
        private String dniusuario;

        public TarjetaEasyPay() { }

        public string Nrotarjeta { get => nrotarjeta; set => nrotarjeta = value; }
        public string Tipotarjeta { get => tipotarjeta; set => tipotarjeta = value; }
        public string Fechavencimiento { get => fechavencimiento; set => fechavencimiento = value; }
        public string Codigoseguridad { get => codigoseguridad; set => codigoseguridad = value; }
        public string Direcciontarjeta { get => direcciontarjeta; set => direcciontarjeta = value; }
        public string Dniusuario { get => dniusuario; set => dniusuario = value; }
    }
}