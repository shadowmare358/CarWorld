using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarWorld.Models;

namespace CarWorld.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CarWorld.Models.CarModel> CarModel { get; set; }
        public DbSet<CarWorld.Models.Rating> Ratings { get; set; }
        public DbSet<CarWorld.Models.RatingSort> RatingSort { get; set; }
    }
}
