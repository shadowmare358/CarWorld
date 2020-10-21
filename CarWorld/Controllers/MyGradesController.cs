using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CarWorld.Data;
using CarWorld.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarWorld.Controllers
{
    [Authorize]
    public class MyGradesController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly IHttpContextAccessor _contextHttp;
        public MyGradesController(ApplicationDbContext context, IWebHostEnvironment env, IHttpContextAccessor contextHttp)
        {
            _context = context;
            _env = env;
            _contextHttp = contextHttp;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _contextHttp.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = _context.Ratings.Include(r => r.Car).Where(r => r.UserID == userId);
            return View(await applicationDbContext.ToListAsync());
        }
    }
}
