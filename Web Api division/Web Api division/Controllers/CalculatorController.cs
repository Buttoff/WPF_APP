using Microsoft.AspNetCore.Mvc;
using System;
using Web_Api_division.Models;

namespace WebApiDivision.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] CalcRequest request)
        {
            if (request == null)
            {
                return BadRequest("Request body is required");
            }


            double result = request.A / request.B;

            return Ok(new { result = result, operation = "addition" });
        }


    }
}