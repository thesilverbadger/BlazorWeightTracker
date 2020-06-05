using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorWeightTracker.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWeightTracker.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WeightController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<WeightDto> Get()
        {
            return new List<WeightDto>()
            {
                new WeightDto()
                {
                    WeightId=1,
                    Created=DateTime.UtcNow,
                    KgValue=80,
                    Unit= WeightUnit.Kg,
                    UserId= Guid.NewGuid()
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
