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
    public class AmountGearsController : Controller
    {
        private readonly CompareMotosContext _context;

        public AmountGearsController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: AmountGears
        public async Task<IActionResult> Index()
        {
            return View(await _context.AmountGear.ToListAsync());
        }

        // GET: AmountGears/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amountGear = await _context.AmountGear
                .FirstOrDefaultAsync(m => m.AmountGearId == id);
            if (amountGear == null)
            {
                return NotFound();
            }

            return View(amountGear);
        }

        // GET: AmountGears/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AmountGears/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AmountGearId,Amount")] AmountGear amountGear)
        {
            if (ModelState.IsValid)
            {
                _context.Add(amountGear);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(amountGear);
        }

        // GET: AmountGears/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amountGear = await _context.AmountGear.FindAsync(id);
            if (amountGear == null)
            {
                return NotFound();
            }
            return View(amountGear);
        }

        // POST: AmountGears/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AmountGearId,Amount")] AmountGear amountGear)
        {
            if (id != amountGear.AmountGearId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amountGear);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmountGearExists(amountGear.AmountGearId))
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
            return View(amountGear);
        }

        // GET: AmountGears/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amountGear = await _context.AmountGear
                .FirstOrDefaultAsync(m => m.AmountGearId == id);
            if (amountGear == null)
            {
                return NotFound();
            }

            return View(amountGear);
        }

        // POST: AmountGears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var amountGear = await _context.AmountGear.FindAsync(id);
            _context.AmountGear.Remove(amountGear);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmountGearExists(int id)
        {
            return _context.AmountGear.Any(e => e.AmountGearId == id);
        }
    }
}
