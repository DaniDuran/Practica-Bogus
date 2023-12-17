using Bogus;
using Bogus.Extensions.UnitedStates;
using practica_graphql.domain.contracts;
using practica_graphql.domain.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_graphql.infraestructure.services
{
    public class ManagementSolicitudes : IManagementSolicitudes
    {
        private readonly Faker<Documento> _documentofaker;
        private readonly Faker<SolicitudesCredito> _solcreditofaker;

        public ManagementSolicitudes()
        {
            Randomizer.Seed = new Random(4);
            _documentofaker = new Faker<Documento>()
                                .RuleFor(d=> d.tipodocumento,f=> f.PickRandom(Constantes.Tiposdocumento))
                                .RuleFor(d=> d.rutasft, f => f.Internet.UrlWithPath("sftp",null,"tiff"))
                                .RuleFor(d=> d.fechaemisiondocumento, f=> f.Date.Past(1));

            _solcreditofaker = new Faker<SolicitudesCredito>()
                                .RuleFor(s => s.id, f => f.Random.Int(1, 100000))
                                .RuleFor(s=> s.name, f=> f.Name.FirstName())
                                .RuleFor(s=> s.lastname, f=> f.Name.LastName())
                                .RuleFor(s=> s.cedula, f=> f.Person.Ssn())
                                .RuleFor(s=> s.correo, (f,s )=> f.Internet.Email(s.name,s.lastname))
                                .RuleFor(s=> s.telefono, f=> f.Phone.PhoneNumber())
                                .RuleFor(s=> s.fechasolicitud, f=> f.Date.Recent(1))
                                .RuleFor(s=> s.productosolicitado, f=> f.PickRandom<Producto>())
                                .RuleFor(s=> s.documentos, f=> _documentofaker.Generate(2));
        }

        public List<SolicitudesCredito> GetSolicitudes()
        {
            return _solcreditofaker.Generate(5);
        }
    }
}
