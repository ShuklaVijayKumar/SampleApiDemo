using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SampleApiDemo.Helper;

namespace SampleApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public string Get()
        {
            var serviceName = this._configuration.GetValue<string>("ServiceSettings:ServiceTwo:Name");
            var dscr = new Descriptor(this._configuration);

            return $"ServiceOne Environment Name:{serviceName}, {dscr.GetEnvironmentDescription(serviceName)}";
        }
    }
}