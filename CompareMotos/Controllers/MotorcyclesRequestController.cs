using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompareMotos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompareMotos.Controllers
{
    [Route("api/motorcycle")]
    public class MotorcyclesRequestController : Controller
    {

        private readonly CompareMotosContext _context;

        public MotorcyclesRequestController(CompareMotosContext context)
        {
            _context = context;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var names = _context.Motorcycle.Where(p => p.ModelMotorcycle.Name.Contains(term)).Select(p => p.ModelMotorcycle.Name).ToList();
                return Ok(names);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}