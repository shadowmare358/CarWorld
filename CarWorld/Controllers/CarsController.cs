using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarWorld.Data;
using CarWorld.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Query;

namespace CarWorld.Controllers
{
    [Authorize]
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly IHttpContextAccessor _contextHttp;


        public CarsController(ApplicationDbContext context, IWebHostEnvironment env, IHttpContextAccessor contextHttp)
        {
            _context = context;
            _env = env;
            _contextHttp = contextHttp;
        }
        // GET: Images
        public async Task<IActionResult> Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
               var contextSearch = _context.CarModel.Include(i => i.User).Where(x => x.Title == searchString);
                return View(await contextSearch.ToListAsync());
            }
            else
            {
                var context = _context.CarModel.Include(i => i.User);
                return View(await context.ToListAsync());
            }
            
        }

        // GET: Images/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carModel = await _context.CarModel
                .Include(i => i.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carModel == null)
            {
                return NotFound();
            }

            return View(carModel);
        }

        // GET: Images/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Images/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,ImageFile")] CarModel carModel)
        {
            var userId = _contextHttp.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            carModel.UserID = userId;
            if (ModelState.IsValid)
            {
                string wwwRootPath = _env.WebRootPath;
                await UploadImage(carModel, wwwRootPath);
                _context.Add(carModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carModel);
        }

        private static async Task UploadImage(CarModel carModel, string wwwRootPath)
        {
            if (carModel.ImageFile != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(carModel.ImageFile.FileName);
                string extension = Path.GetExtension(carModel.ImageFile.FileName);
                string fileStoreageName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                carModel.ImageName = fileStoreageName;
                string path = Path.Combine(wwwRootPath + "/images/", fileStoreageName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await carModel.ImageFile.CopyToAsync(fileStream);
                }
            }
            else
            {
                carModel.ImageName = "placeholder.jpg";
            }

        }

        // GET: Images/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carModel = await _context.CarModel.FindAsync(id);
            if (carModel == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", carModel.UserID);
            return View(carModel);
        }

        // POST: Images/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,UserID,ImageFile")] CarModel carModel)
        {
            if (id != carModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string wwwRootPath = _env.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(carModel.ImageFile.FileName);
                    string extension = Path.GetExtension(carModel.ImageFile.FileName);
                    string fileStoreageName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    carModel.ImageName = fileStoreageName;
                    string path = Path.Combine(wwwRootPath + "/images/", fileStoreageName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await carModel.ImageFile.CopyToAsync(fileStream);
                    }
                    _context.Update(carModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarModelExists(carModel.Id))
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
            return View(carModel);
        }

        // GET: Images/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carModel = await _context.CarModel
                .Include(i => i.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carModel == null)
            {
                return NotFound();
            }

            return View(carModel);
        }

        // POST: Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carModel = await _context.CarModel.FindAsync(id);
            var imagePath = Path.Combine(_env.WebRootPath, "images", carModel.ImageName);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            _context.CarModel.Remove(carModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarModelExists(int id)
        {
            return _context.CarModel.Any(e => e.Id == id);
        }
    }
}
