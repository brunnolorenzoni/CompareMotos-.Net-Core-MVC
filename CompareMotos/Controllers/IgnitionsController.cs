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
    public class IgnitionsController : Controller
    {
        private readonly CompareMotosContext _context;

        public IgnitionsController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Ignitions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ignition.ToListAsync());
        }

        // GET: Ignitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ignition = await _context.Ignition
                .FirstOrDefaultAsync(m => m.IgnitionId == id);
            if (ignition == null)
            {
                return NotFound();
            }

            return View(ignition);
        }

        // GET: Ignitions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ignitions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IgnitionId,Name")] Ignition ignition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ignition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ignition);
        }

        // GET: Ignitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ignition = await _context.Ignition.FindAsync(id);
            if (ignition == null)
            {
                return NotFound();
            }
            return View(ignition);
        }

        // POST: Ignitions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IgnitionId,Name")] Ignition ignition)
        {
            if (id != ignition.IgnitionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ignition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IgnitionExists(ignition.IgnitionId))
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
            return View(ignition);
        }

        // GET: Ignitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ignition = await _context.Ignition
                .FirstOrDefaultAsync(m => m.IgnitionId == id);
            if (ignition == null)
            {
                return NotFound();
            }

            return View(ignition);
        }

        // POST: Ignitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ignition = await _context.Ignition.FindAsync(id);
            _context.Ignition.Remove(ignition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IgnitionExists(int id)
        {
            return _context.Ignition.Any(e => e.IgnitionId == id);
        }
    }
}
