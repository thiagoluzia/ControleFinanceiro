using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/profiles")]
    public class ProfilesControllers :ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] CreateProfileModel creteProfile)
        {
            // validade return BadRequest()
            return CreatedAtAction(nameof(GetById), new{id = creteProfile.Id}, creteProfile);
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
        public IActionResult Put(int id, [FromBody] UpdateProfileModel updateProfile)
        {
            //validate return NotFound()
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