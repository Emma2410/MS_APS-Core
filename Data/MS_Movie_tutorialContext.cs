using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MS_Movie_tutorial.Models;

namespace MS_Movie_tutorial.Data
{
    public class MS_Movie_tutorialContext : DbContext
    {
        public MS_Movie_tutorialContext (DbContextOptions<MS_Movie_tutorialContext> options)
            : base(options)
        {
        }

        public DbSet<MS_Movie_tutorial.Models.Movie> Movie { get; set; } = default!;
    }
}
