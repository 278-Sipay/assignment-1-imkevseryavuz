using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;
using FluentValidation.Results;



namespace SipayApi.Controllers
{


    [ApiController]
    [Route("api/[controller]")]

    public class PersonController : ControllerBase
    {
        public PersonController() { }

        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {
            if (!ModelState.IsValid)
            {
                var messages = ModelState.ToList();
                return BadRequest("Post operation failed");
            }
            return Ok(person);
        }
    }

}
