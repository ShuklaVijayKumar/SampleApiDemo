using System;
using Microsoft.Extensions.Configuration;

namespace SampleApiDemo.Helper
{
    public class Descriptor
    {
        private IConfiguration _configuration;

        public Descriptor(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string GetEnvironmentDescription(string envName)
        {
            switch (envName)
            {
                case "Audit-Prod":
                    return this._configuration.GetSection($"ServiceSettings:ServiceOne:Description").Value;
                    break;

                case "Security-Prod":
                    return this._configuration.GetSection($"ServiceSettings:ServiceTwo:Description").Value;
                    break;

                default:
                    return "No match";
            }
        }
    }
}