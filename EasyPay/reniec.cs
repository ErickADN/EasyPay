﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EasyPay
{   
    [DataContract]
    public class reniec
    {
        [DataMember]
        private String dni;
        private String nombre;
        private String apellido;
 
        private String contraseña;
        private String celular;
        private String direccion;
        private String fechaNacimiento;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}