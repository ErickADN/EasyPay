using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EasyPay
{
     [DataContract]
    public class sunat
    {
        [DataMember]
        private String ruc;
        private String nombrelegal;
        private String direccioncorreoelectronico;
        private String direccion;
        private String contraseña;
    

        public String Ruc { get => ruc; set => ruc = value; }
        public String Nombrelegal { get => nombrelegal; set => nombrelegal = value; }
        public String Direccioncorreoelectronico { get => direccioncorreoelectronico; set => direccioncorreoelectronico = value; }
        public String Direccion { get => direccion; set => direccion = value; }
        public String Contraseña { get => contraseña; set => contraseña = value; }
    }
}