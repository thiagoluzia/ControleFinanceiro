using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/revenues")]
    public class RevenuesControllers : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] CreateRevenueModel createRevenue)
        {
            // validate return BadRequest();
            return CreatedAtAction(nameof(GetById), new {id =  createRevenue.Id}, createRevenue);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // validate return NotFound();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] UpdateRevenueModel updateRevenue)
        {
            // validate return BadRequest();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // validate return BadRequest()
            return NoContent(); 
        }
    }
}