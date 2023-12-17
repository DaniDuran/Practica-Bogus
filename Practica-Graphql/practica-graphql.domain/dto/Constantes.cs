using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_graphql.domain.dto
{
    public static class Constantes
    {
        private static readonly string[] _documentos = {"Referencia Laboral", "Referencia Personal", "Pagare", "Certificacion Bancaria", "Cedula"};
        public static string[] Tiposdocumento => _documentos; 
    }
}
