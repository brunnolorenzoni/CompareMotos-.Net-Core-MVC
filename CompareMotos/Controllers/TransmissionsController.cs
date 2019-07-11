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
    public class TransmissionsController : Controller
    {
        private readonly CompareMotosContext _context;

        public TransmissionsController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Transmissions
        public async Task<IActionResult> Index()
        {
            var compareMotosContext = _context.Transmission.Include(t => t.AmountGear).Include(t => t.TypeTransmission);
            return View(await compareMotosContext.ToListAsync());
        }

        // GET: Transmissions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transmission = await _context.Transmission
                .Include(t => t.AmountGear)
                .Include(t => t.TypeTransmission)
                .FirstOrDefaultAsync(m => m.TransmissionId == id);
            if (transmission == null)
            {
                return NotFound();
            }

            return View(transmission);
        }

        // GET: Transmissions/Create
        public IActionResult Create()
        {
            ViewData["AmountGearId"] = new SelectList(_context.AmountGear, "AmountGearId", "AmountGearId");
            ViewData["TypeTransmissionId"] = new SelectList(_context.TypeTransmission, "TypeTransmissionId", "Name");
            return View();
        }

        // POST: Transmissions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransmissionId,TypeTransmissionId,AmountGearId")] Transmission transmission)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transmission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AmountGearId"] = new SelectList(_context.AmountGear, "AmountGearId", "AmountGearId", transmission.AmountGearId);
            ViewData["TypeTransmissionId"] = new SelectList(_context.TypeTransmission, "TypeTransmissionId", "Name", transmission.TypeTransmissionId);
            return View(transmission);
        }

        // GET: Transmissions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transmission = await _context.Transmission.FindAsync(id);
            if (transmission == null)
            {
                return NotFound();
            }
            ViewData["AmountGearId"] = new SelectList(_context.AmountGear, "AmountGearId", "AmountGearId", transmission.AmountGearId);
            ViewData["TypeTransmissionId"] = new SelectList(_context.TypeTransmission, "TypeTransmissionId", "Name", transmission.TypeTransmissionId);
            return View(transmission);
        }

        // POST: Transmissions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransmissionId,TypeTransmissionId,AmountGearId")] Transmission transmission)
        {
            if (id != transmission.TransmissionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transmission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransmissionExists(transmission.TransmissionId))
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
            ViewData["AmountGearId"] = new SelectList(_context.AmountGear, "AmountGearId", "AmountGearId", transmission.AmountGearId);
            ViewData["TypeTransmissionId"] = new SelectList(_context.TypeTransmission, "TypeTransmissionId", "Name", transmission.TypeTransmissionId);
            return View(transmission);
        }

        // GET: Transmissions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transmission = await _context.Transmission
                .Include(t => t.AmountGear)
                .Include(t => t.TypeTransmission)
                .FirstOrDefaultAsync(m => m.TransmissionId == id);
            if (transmission == null)
            {
                return NotFound();
            }

            return View(transmission);
        }

        // POST: Transmissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transmission = await _context.Transmission.FindAsync(id);
            _context.Transmission.Remove(transmission);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransmissionExists(int id)
        {
            return _context.Transmission.Any(e => e.TransmissionId == id);
        }
    }
}
