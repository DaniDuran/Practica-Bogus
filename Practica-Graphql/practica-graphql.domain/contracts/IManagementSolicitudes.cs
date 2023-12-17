using practica_graphql.domain.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_graphql.domain.contracts
{
    public interface IManagementSolicitudes
    {
        List<SolicitudesCredito> GetSolicitudes();
    }
}
