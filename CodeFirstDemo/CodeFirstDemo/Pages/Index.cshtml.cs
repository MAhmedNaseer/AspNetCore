using CodeFirstDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext Context)
        {
            _logger = logger;
            _context = Context;
        }

        public void OnGet()
        {
            var list = _context.Students.ToList();

            ViewData["Students"] = list;
        }
    }
}
