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
    public class RecipesModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipesModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RecipesModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.RecipesModel.ToListAsync());
        }

        // GET: RecipesModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipesModel = await _context.RecipesModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipesModel == null)
            {
                return NotFound();
            }

            return View(recipesModel);
        }

        // GET: RecipesModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RecipesModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RecipeName,RecipeDescription,Ingredients,PreparationTime")] RecipesModel recipesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipesModel);
        }

        // GET: RecipesModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipesModel = await _context.RecipesModel.FindAsync(id);
            if (recipesModel == null)
            {
                return NotFound();
            }
            return View(recipesModel);
        }

        // POST: RecipesModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RecipeName,RecipeDescription,Ingredients,PreparationTime")] RecipesModel recipesModel)
        {
            if (id != recipesModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipesModelExists(recipesModel.Id))
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
            return View(recipesModel);
        }

        // GET: RecipesModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipesModel = await _context.RecipesModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipesModel == null)
            {
                return NotFound();
            }

            return View(recipesModel);
        }

        // POST: RecipesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipesModel = await _context.RecipesModel.FindAsync(id);
            _context.RecipesModel.Remove(recipesModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipesModelExists(int id)
        {
            return _context.RecipesModel.Any(e => e.Id == id);
        }
    }
}
