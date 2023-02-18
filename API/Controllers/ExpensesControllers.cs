using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/expenses")]
    public class ExpensesControllers : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] CreateExpenseModel createExpense)
        {
            // validate return BadRequest();
            return CreatedAtAction(nameof(GetById), new {id = createExpense.Id, createExpense});
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // validade return NotFound();
            return Ok();
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateExpenseModel updateExpense)
        {
            // Validate return NotFound()
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