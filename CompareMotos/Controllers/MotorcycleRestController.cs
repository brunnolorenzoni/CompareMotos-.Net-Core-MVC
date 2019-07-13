using CompareMotos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Controllers
{
    [Route("api/motorcycle")]
    public class MotorcycleRestController : Controller
    {
        private readonly CompareMotosContext _context;

        public MotorcycleRestController(CompareMotosContext context)
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

        [Produces("application/json")]
        [HttpGet("compare")]
        public async Task<IActionResult> Compare(string nameA, string nameB )
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
