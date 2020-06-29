using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smith_week4.Models
{
    public class Topics
    {
        [Key]
        public string TopicId { get; set; }
        public string Name { get; set; }
    }
}
