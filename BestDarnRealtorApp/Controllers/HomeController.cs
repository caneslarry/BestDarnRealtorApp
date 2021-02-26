
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BestDarnRealtorApp.Models;
using BestDarnRealtorApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BestDarnRealtorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BestDarnRealtorAppContext _context;

        public HomeController(ILogger<HomeController> logger, BestDarnRealtorAppContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View(new SearchForm());
        }

        [HttpPost]
        public async Task<IActionResult> SearchAsync(SearchForm model)
        {
            IQueryable<Listing> query = _context.Listing;

            query = this.buildContextQuery(model, query);

            await query.ToListAsync();

            model.Listings = query;

            return View(model);
        }

        private IQueryable<Listing> buildContextQuery(SearchForm form, IQueryable<Listing> query)
        {
            if (form.mls != null)
            {
                query = query.Where(l => l.Mls == form.mls);
            }
            if (form.city != null)
            {
                query = query.Where(l => l.City == form.city);
            }
            if (form.state != null)
            {
                query = query.Where(l => l.State == form.state);
            }
            if (form.zip != null)
            {
                query = query.Where(l => l.Zip == form.zip);
            }
            if (form.bedrooms_min > 0)
            {
                query = query.Where(l => l.Bedrooms >= form.bedrooms_min);
            }
            if (form.bathrooms_min > 0)
            {
                query = query.Where(l => l.Bathrooms >= form.bathrooms_min);
            }
            if (form.squarefeet_min > 0)
            {
                query = query.Where(l => l.SquareFeet >= form.squarefeet_min);
            }

            if (form.bedrooms_max > 0)
            {
                query = query.Where(l => l.Bedrooms <= form.bedrooms_max);
            }
            if (form.bathrooms_max > 0)
            {
                query = query.Where(l => l.Bathrooms <= form.bathrooms_max);
            }
            if (form.squarefeet_max > 0)
            {
                query = query.Where(l => l.SquareFeet <= form.squarefeet_max);
            }
            return query;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
