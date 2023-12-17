using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_graphql.domain.dto
{
    public class SolicitudesCredito
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string lastname { get; set; } = string.Empty;
        public string cedula { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        public string telefono { get; set; } = string.Empty;
        public DateTime fechasolicitud { get; set; }
        public Producto productosolicitado { get; set; }
        public List<Documento> documentos { get; set; } = new List<Documento>();

    }
}
