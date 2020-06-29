using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smith_week4.Models
{
    public class Categories
    {
        [Key]
        public string CategoryId { get; set; }
        public string Name { get; set; }
    }
}
