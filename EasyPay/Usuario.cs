using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EasyPay
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        private String dni;
        private String nombre;
        private String apellido;
        private int edad;
        private String contraseña;
        private String celular;
        private String direccion;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}