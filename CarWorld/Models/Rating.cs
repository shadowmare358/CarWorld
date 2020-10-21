using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarWorld.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public double Score { get; set; }
        [ForeignKey("CarID")]
        public virtual CarModel Car { get; set; }
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual IdentityUser User { get; set; }
    }
}
