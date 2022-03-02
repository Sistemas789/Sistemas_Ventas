using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Abrev { get; set; }
        public string Numero_Ruc { get; set; }
        public string Direccion { get; set; }
        public string Codigo_Pais { get; set; }
        public string Codigo_Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Referencia { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string Usuario_Registro { get; set; }
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
    }
}
