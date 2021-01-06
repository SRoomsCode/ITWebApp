using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITWebApp.Data;
using ITWebApp.Models;

namespace ITWebApp.Views.Home.Games
{
    public class IndexModel : PageModel
    {
        private readonly ITWebApp.Data.AppDBContext _context;

        public IndexModel(ITWebApp.Data.AppDBContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
