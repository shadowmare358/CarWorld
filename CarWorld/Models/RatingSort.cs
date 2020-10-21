using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarWorld.Models
{
    public class RatingSort
    {
        [Key]
        public int CarId { get; set; }
        public double Score { get; set; }
        public string CarTitle { get; set; }
        public string CarImage { get; set; }
    }
}
