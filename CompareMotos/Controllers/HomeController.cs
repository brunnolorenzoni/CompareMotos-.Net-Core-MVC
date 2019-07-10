using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CompareMotos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CompareMotos.Controllers
{
    public class HomeController : Controller
    {

        private readonly CompareMotosContext _context;

        public HomeController(CompareMotosContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var compareMotosContext = _context.Motorcycle.Include(m => m.Brake).Include(m => m.Brand).Include(m => m.Electric).Include(m => m.Engine).Include(m => m.Fuel).Include(m => m.ModelMotorcycle).Include(m => m.Transmission).Include(m => m.TypeMotorcycle);
            return View(await compareMotosContext.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
