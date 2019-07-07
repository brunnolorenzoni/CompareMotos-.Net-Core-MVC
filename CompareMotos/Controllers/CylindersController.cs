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
    public class CylindersController : Controller
    {
        private readonly CompareMotosContext _context;

        public CylindersController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Cylinders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cylinder.ToListAsync());
        }

        // GET: Cylinders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cylinder = await _context.Cylinder
                .FirstOrDefaultAsync(m => m.CylinderId == id);
            if (cylinder == null)
            {
                return NotFound();
            }

            return View(cylinder);
        }

        // GET: Cylinders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cylinders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CylinderId,Name")] Cylinder cylinder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cylinder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cylinder);
        }

        // GET: Cylinders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cylinder = await _context.Cylinder.FindAsync(id);
            if (cylinder == null)
            {
                return NotFound();
            }
            return View(cylinder);
        }

        // POST: Cylinders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CylinderId,Name")] Cylinder cylinder)
        {
            if (id != cylinder.CylinderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cylinder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CylinderExists(cylinder.CylinderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cylinder);
        }

        // GET: Cylinders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cylinder = await _context.Cylinder
                .FirstOrDefaultAsync(m => m.CylinderId == id);
            if (cylinder == null)
            {
                return NotFound();
            }

            return View(cylinder);
        }

        // POST: Cylinders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cylinder = await _context.Cylinder.FindAsync(id);
            _context.Cylinder.Remove(cylinder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CylinderExists(int id)
        {
            return _context.Cylinder.Any(e => e.CylinderId == id);
        }
    }
}
