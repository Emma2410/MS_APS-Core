using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MS_Movie_tutorial.Data;
using MS_Movie_tutorial.Models;

namespace MS_Movie_tutorial.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MS_Movie_tutorial.Data.MS_Movie_tutorialContext _context;

        public IndexModel(MS_Movie_tutorial.Data.MS_Movie_tutorialContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
