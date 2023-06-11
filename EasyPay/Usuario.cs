using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EasyPay
{
    public class Usuario
    {
        [DataMember]
        private String dni;
        [DataMember]
        private String nombre;
        [DataMember]
        private String apellido;
        [DataMember]
        private int edad;
        [DataMember]
        private String contraseña;
        [DataMember]
        private String celular;
        [DataMember]
        private String direccion;

        public Usuario() { }

        [DataMember]
        public string Dni { get => dni; set => dni = value; }
        [DataMember]
        public string Nombre { get => nombre; set => nombre = value; }
        [DataMember]
        public string Apellido { get => apellido; set => apellido = value; }
        [DataMember]
        public int Edad { get => edad; set => edad = value; }
        [DataMember]
        public string Contraseña { get => contraseña; set => contraseña = value; }
        [DataMember]
        public string Celular { get => celular; set => celular = value; }
        [DataMember]
        public string Direccion { get => direccion; set => direccion = value; }
    }
}