﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_graphql.domain.dto
{
    public class Documento
    {
        public string tipodocumento { get; set; }
        public string rutasft{ get; set; }
        public DateTime fechaemisiondocumento{ get; set; }
    }
}