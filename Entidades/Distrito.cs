﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Distrito
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion_Abrv { get; set; }
        public string Codigo_Pais { get; set; }
        public string Codigo_Departamento { get; set; }
        public string Codigo_Provincia { get; set; }
        public string Estado { get; set; }
        public string Usuario_Registro { get; set; }
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
    }
}
