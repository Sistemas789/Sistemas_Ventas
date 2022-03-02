﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public string Usuario_Registro { get; set; }
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
        public Nullable<int> IdRol { get; set; }
    }
}
