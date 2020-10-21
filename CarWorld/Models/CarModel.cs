
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarWorld.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual IdentityUser User { get; set; }
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Upload file")]
        public IFormFile ImageFile { get; set; }
    }
}
