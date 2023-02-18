using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/users")]
    public class UsersControllers :ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUser)
        {
            // validate return BadRequest();
            return CreatedAtAction(nameof(GetById), new {id = createUser.Id }, createUser);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // validate return NotFound()
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateUserModel updateUser)
        {
            // validate return BadRequest();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // validate return BadRequest();
            return NoContent();
        }      
    }
}