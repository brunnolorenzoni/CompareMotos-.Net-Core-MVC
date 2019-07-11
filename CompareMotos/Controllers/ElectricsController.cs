﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompareMotos.Models;

namespace CompareMotos.Controllers
{
    public class ElectricsController : Controller
    {
        private readonly CompareMotosContext _context;

        public ElectricsController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Electrics
        public async Task<IActionResult> Index()
        {
            var compareMotosContext = _context.Electric.Include(e => e.Battery).Include(e => e.Ignition).Include(e => e.Start);
            return View(await compareMotosContext.ToListAsync());
        }

        // GET: Electrics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var electric = await _context.Electric
                .Include(e => e.Battery)
                .Include(e => e.Ignition)
                .Include(e => e.Start)
                .FirstOrDefaultAsync(m => m.ElectricId == id);
            if (electric == null)
            {
                return NotFound();
            }

            return View(electric);
        }

        // GET: Electrics/Create
        public IActionResult Create()
        {
            ViewData["BatteryId"] = new SelectList(_context.Battery, "BatteryId", "Name");
            ViewData["IgnitionId"] = new SelectList(_context.Ignition, "IgnitionId", "Name");
            ViewData["StartId"] = new SelectList(_context.Start, "StartId", "Name");
            return View();
        }

        // POST: Electrics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ElectricId,IgnitionId,StartId,BatteryId")] Electric electric)
        {
            if (ModelState.IsValid)
            {
                _context.Add(electric);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BatteryId"] = new SelectList(_context.Battery, "BatteryId", "Name", electric.BatteryId);
            ViewData["IgnitionId"] = new SelectList(_context.Ignition, "IgnitionId", "Name", electric.IgnitionId);
            ViewData["StartId"] = new SelectList(_context.Start, "StartId", "Name", electric.StartId);
            return View(electric);
        }

        // GET: Electrics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var electric = await _context.Electric.FindAsync(id);
            if (electric == null)
            {
                return NotFound();
            }
            ViewData["BatteryId"] = new SelectList(_context.Battery, "BatteryId", "Name", electric.BatteryId);
            ViewData["IgnitionId"] = new SelectList(_context.Ignition, "IgnitionId", "Name", electric.IgnitionId);
            ViewData["StartId"] = new SelectList(_context.Start, "StartId", "Name", electric.StartId);
            return View(electric);
        }

        // POST: Electrics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ElectricId,IgnitionId,StartId,BatteryId")] Electric electric)
        {
            if (id != electric.ElectricId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(electric);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElectricExists(electric.ElectricId))
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
            ViewData["BatteryId"] = new SelectList(_context.Battery, "BatteryId", "Name", electric.BatteryId);
            ViewData["IgnitionId"] = new SelectList(_context.Ignition, "IgnitionId", "Name", electric.IgnitionId);
            ViewData["StartId"] = new SelectList(_context.Start, "StartId", "Name", electric.StartId);
            return View(electric);
        }

        // GET: Electrics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var electric = await _context.Electric
                .Include(e => e.Battery)
                .Include(e => e.Ignition)
                .Include(e => e.Start)
                .FirstOrDefaultAsync(m => m.ElectricId == id);
            if (electric == null)
            {
                return NotFound();
            }

            return View(electric);
        }

        // POST: Electrics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var electric = await _context.Electric.FindAsync(id);
            _context.Electric.Remove(electric);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ElectricExists(int id)
        {
            return _context.Electric.Any(e => e.ElectricId == id);
        }
    }
}
