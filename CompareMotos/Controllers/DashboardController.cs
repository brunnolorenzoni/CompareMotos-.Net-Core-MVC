using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompareMotos.Models;

namespace CompareMotos.Controllers
{
    public class DashboardController : Controller
    {
        private readonly CompareMotosContext _context;

        public DashboardController(CompareMotosContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
