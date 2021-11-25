using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
#pragma warning disable CS8618
#pragma warning disable CS8604
  public class IndexModel : PageModel
  {
    private readonly RazorPagesMovieContext _context;

    public IndexModel(RazorPagesMovieContext context)
    {
      _context = context;
    }

    public IList<Movie> Movie { get; set; }

    public async Task OnGetAsync()
    {
      Movie = await _context.Movie.ToListAsync();
    }
  }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
