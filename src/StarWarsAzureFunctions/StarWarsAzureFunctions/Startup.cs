using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StarWarsAzureFunctions;

[assembly: FunctionsStartup(typeof(Startup))]

namespace StarWarsAzureFunctions
{
    public class Startup : FunctionsStartup 
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            throw new NotImplementedException();
        }
    }
}
