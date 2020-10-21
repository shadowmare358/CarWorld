using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CarWorld.Data;
using CarWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;

namespace CarWorld.Controllers
{
    public class RatingSortedController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RatingSortedController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var averageScores =
              from rating in _context.Ratings
              join car in _context.CarModel on rating.CarID equals car.Id
              group rating by rating.CarID into carScores
              select new 
              {
                  CarId = carScores.Key,
                  Score = carScores.Average(x => x.Score),
              };
            List<RatingSort> ratingList = new List<RatingSort>();
          foreach(var item in averageScores)
            {
                var carId = item.CarId;
                var car = _context.CarModel.Where(c => c.Id == carId).FirstOrDefault();
                ratingList.Add(new RatingSort
                {
                   CarId =  item.CarId,
                   Score = item.Score,
                   CarTitle = car.Title,
                   CarImage = car.ImageName
                });
            }
            return View(ratingList.ToList());
        }
    }
}
