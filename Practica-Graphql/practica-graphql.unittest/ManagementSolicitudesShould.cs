using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using practica_graphql.domain.contracts;
using practica_graphql.domain.dto;
using practica_graphql.infraestructure.services;
using System.Linq;
using Xunit.Abstractions;

namespace practica_graphql.unittest
{
    public class ManagementSolicitudesShould
    {
        private readonly ITestOutputHelper _outputHelper;

        public ManagementSolicitudesShould(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }


        private void BuildRequired(out ManagementSolicitudes managementSolicitudes)
        {
            var host = Host.CreateDefaultBuilder()
                        .ConfigureServices((context, services) =>
                        {
                            services.AddTransient<ManagementSolicitudes>();
                        })
                        .Build();
            managementSolicitudes = ActivatorUtilities.CreateInstance<ManagementSolicitudes>(host.Services);
        }

        [Fact]
        public void GetSolicitudes_Ok() 
        { 
        //Arg

        //Act
        BuildRequired(out ManagementSolicitudes managementSolicitudes);
        var result = managementSolicitudes.GetSolicitudes();
        
        //Assert
        Assert.True(result.Count>0);
        _outputHelper.WriteLine(JsonConvert.SerializeObject(result));

        }
    }
}