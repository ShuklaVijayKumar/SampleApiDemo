using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChannelController : ControllerBase
    {
        // GET: api/<ChannelController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            try
            {
                throw new Exception();
                return new string[] { "value1", "value2" };
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured on GET");
            }
        }

        // GET api/<ChannelController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            try
            {
                int i = 0;
                int x = 8 / i;
                return $"value {id}";
            }
            catch (Exception ex)
            {
                throw ex;// new Exception("Error occured on GET(Id)");
            }
        }

        // POST api/<ChannelController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            try
            {
                throw new ArgumentException();
                return new OkObjectResult($"{value} added")
                {
                    StatusCode = (int)HttpStatusCode.OK,
                };
            }
            catch (Exception ex)
            {
                throw ex;// new Exception("Error occured on POST");
            }
        }
    }
}