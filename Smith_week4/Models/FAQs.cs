using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Smith_week4.Models
{
    public class FAQs
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public string TopicId { get; set; }
        public Topics Topics { get; set; }

        public string CategoryId { get; set; }
        public Categories Categories { get; set; }
    }
}
