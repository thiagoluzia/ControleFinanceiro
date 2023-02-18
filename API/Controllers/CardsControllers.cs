using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/cards")]
    public class CardsControllers : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] CreateCardModel createCard)
        {
            //validade return  BadRequest();
            return CreatedAtAction(nameof(GetById), new {i = createCard.Id}, createCard);
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
        public IActionResult Put(int id, [FromBody] UpdateCardModel updteCard)
        {
            // validate return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // validade return BadRequest()
            return NoContent();
        }

    }
}