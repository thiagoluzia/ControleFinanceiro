using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/banks")]
    public class BanksControllers : ControllerBase
    {
  
        [HttpPost]
        public IActionResult Post([FromBody] CreateBankModel createBank)
        {
            //validate return ReturnBadRequest();

            return CreatedAtAction(nameof(GetById), new {id  = createBank.Id}, createBank);
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //validate return NotFound();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateBankModel updateBank)
        {
            //validade return BadRequest();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //validade return BadRequest();

            return NoContent();
        }
    }
}