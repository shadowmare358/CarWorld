using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarWorld.Data;
using CarWorld.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Security.Claims;

namespace CarWorld.Controllers
{
    public class RatingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly IHttpContextAccessor _contextHttp;

        public RatingsController(ApplicationDbContext context, IWebHostEnvironment env, IHttpContextAccessor contextHttp)
        {
            _context = context;
            _env = env;
            _contextHttp = contextHttp;
        }

        // GET: Ratings
        public async Task<IActionResult> Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var contextSearch = _context.Ratings.Include(r => r.Car).Include(r => r.User).Where(x => x.Car.Title == searchString);
                return View(await contextSearch.ToListAsync());
            }
            else
            {
                var context = _context.Ratings.Include(r => r.Car).Include(r => r.User);
                return View(await context.ToListAsync());
            }
        }

        // GET: Ratings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Ratings
                .Include(r => r.Car)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // GET: Ratings/Create
        public IActionResult Create()
        {
            ViewData["CarID"] = new SelectList(_context.CarModel, "Id", "Title");
            return View();
        }

        // POST: Ratings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CarID,Score,UserID")] Rating rating)
        {
            var userId = _contextHttp.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            rating.UserID = userId;
            if (ModelState.IsValid)
            {
                _context.Add(rating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarID"] = new SelectList(_context.CarModel, "Id", "Title", rating.CarID);
            return View(rating);
        }

        // GET: Ratings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }
            ViewData["CarID"] = new SelectList(_context.CarModel, "Id", "Title", rating.CarID);
            return View(rating);
        }

        // POST: Ratings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CarID,Score,UserID")] Rating rating)
        {
            var userId = _contextHttp.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            rating.UserID = userId;
            if (id != rating.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RatingExists(rating.Id))
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
            ViewData["CarID"] = new SelectList(_context.CarModel, "Id", "Title", rating.CarID);
            return View(rating);
        }

        // GET: Ratings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Ratings
                .Include(r => r.Car)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // POST: Ratings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            _context.Ratings.Remove(rating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RatingExists(int id)
        {
            return _context.Ratings.Any(e => e.Id == id);
        }
    }
}
