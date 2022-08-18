using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CalorieAppTrack.Data;
using CalorieAppTrack.Models;

namespace CalorieAppTrack.Controllers
{
    public class IdealWeightCalculatorModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IdealWeightCalculatorModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IdealWeightCalculatorModels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.IdealWeightCalculatorModel.Include(i => i.UserModel);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: IdealWeightCalculatorModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idealWeightCalculatorModel = await _context.IdealWeightCalculatorModel
                .Include(i => i.UserModel)
                .FirstOrDefaultAsync(m => m.WeightId == id);
            if (idealWeightCalculatorModel == null)
            {
                return NotFound();
            }

            return View(idealWeightCalculatorModel);
        }

        // GET: IdealWeightCalculatorModels/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.UserModel, "UserId", "UserId");
            return View();
        }

        // POST: IdealWeightCalculatorModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WeightId,ActualWeight,Height,IdealWeight,UserId")] IdealWeightCalculatorModel idealWeightCalculatorModel)
        {
            idealWeightCalculatorModel.IdealWeight = 0.75 * idealWeightCalculatorModel.Height - 62.5;
            if (ModelState.IsValid)
            {
                _context.Add(idealWeightCalculatorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.UserModel, "UserId", "UserId", idealWeightCalculatorModel.UserId);
            return View(idealWeightCalculatorModel);
        }

        // GET: IdealWeightCalculatorModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idealWeightCalculatorModel = await _context.IdealWeightCalculatorModel.FindAsync(id);
            if (idealWeightCalculatorModel == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.UserModel, "UserId", "UserId", idealWeightCalculatorModel.UserId);
            return View(idealWeightCalculatorModel);
        }

        // POST: IdealWeightCalculatorModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WeightId,ActualWeight,Height,IdealWeight,UserId")] IdealWeightCalculatorModel idealWeightCalculatorModel)
        {
            if (id != idealWeightCalculatorModel.WeightId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(idealWeightCalculatorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IdealWeightCalculatorModelExists(idealWeightCalculatorModel.WeightId))
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
            ViewData["UserId"] = new SelectList(_context.UserModel, "UserId", "UserId", idealWeightCalculatorModel.UserId);
            return View(idealWeightCalculatorModel);
        }

        // GET: IdealWeightCalculatorModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idealWeightCalculatorModel = await _context.IdealWeightCalculatorModel
                .Include(i => i.UserModel)
                .FirstOrDefaultAsync(m => m.WeightId == id);
            if (idealWeightCalculatorModel == null)
            {
                return NotFound();
            }

            return View(idealWeightCalculatorModel);
        }

        // POST: IdealWeightCalculatorModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var idealWeightCalculatorModel = await _context.IdealWeightCalculatorModel.FindAsync(id);
            _context.IdealWeightCalculatorModel.Remove(idealWeightCalculatorModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IdealWeightCalculatorModelExists(int id)
        {
            return _context.IdealWeightCalculatorModel.Any(e => e.WeightId == id);
        }
    }
}
