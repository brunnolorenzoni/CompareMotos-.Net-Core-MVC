using CompareMotos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                string _nameA = HttpContext.Request.Query["nameA"].ToString();
                string _nameB = HttpContext.Request.Query["nameB"].ToString();

                var return_list = new List<object>();

                var motorcycleA =
                    _context.Motorcycle
                    .Where(p => p.ModelMotorcycle.Name.Contains(_nameA))
                    .Include(p => p.ModelMotorcycle)
                    .Include(p => p.Brand)
                    .Include(p => p.Displacement)
                    .Include(p => p.TypeMotorcycle);

                return_list.Add(motorcycleA);

                var motorcycleB =
                    _context.Motorcycle
                    .Where(p => p.ModelMotorcycle.Name.Contains(_nameB))
                    .Include(p => p.ModelMotorcycle)
                    .Include(p => p.Brand)
                    .Include(p => p.Displacement)
                    .Include(p => p.TypeMotorcycle);

                return_list.Add(motorcycleB);


                return Ok(return_list);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
