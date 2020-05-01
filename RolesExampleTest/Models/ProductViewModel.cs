using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesExampleTest.Models
{
    public class ProductViewModel
    {
       
        public string PartNumber { get; set; }
        public string PartDesc { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public IFormFile Photo { get; set; }
    }
}
