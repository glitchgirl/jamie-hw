using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Smith_week4.Models;

namespace Smith_week4.Controllers
{
    public class HomeController : Controller
    {
        
        private FAQContext context { get; set; }

        public HomeController(FAQContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List","Home");
        }
        //list route controller/id/id2
        [Route("[Controller]s/{id?}/{id2?}")]
        public IActionResult List(string id = "All",string id2 = "All")
        {
            /*
            var categories = context.Categories
                .OrderBy(c => c.CategoryId).ToList();
            var topics = context.Topics
                .OrderBy(c => c.TopicId).ToList();*/
            List<FAQs> fAQs;
            if (id == "All")
            {
                if (id2 == "All")
                {
                    Console.WriteLine(context.FAQs);
                    fAQs = context.FAQs.OrderBy(f => f.Id).ToList();
                }
                else
                {
                    fAQs = context.FAQs.Where(p => p.CategoryId == id2).OrderBy(p => p.Id).ToList();
                }
            }
            else
            {
                if (id2 == "All")
                {
                    fAQs = context.FAQs.Where(p => p.CategoryId == id).OrderBy(p => p.Id).ToList();
                }
                else
                {
                    fAQs = context.FAQs.Where(p => p.CategoryId == id2).OrderBy(p => p.Id).ToList();
                }
            }
            return View(fAQs);
        }
    }
}
