using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SelectListMvc_Load_Static_Dynamic.Models.Entities;
using SelectListMvc_Load_Static_Dynamic.Models.Enums;
using SelectListMvc_Load_Static_Dynamic.Models.Services.Infrastructure;
using SelectListMvc_Load_Static_Dynamic.Models.ViewModels;

namespace SelectListMvc_Load_Static_Dynamic.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DemoDbContext dbContext;
        public IndexModel(DemoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Utenti Utenti { get; set; }

        public SelectList UsersList { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            IQueryable<User> queryLinq = dbContext.Utenti
                .AsNoTracking();
            
            List<HomeViewModel> listUsers = await queryLinq
                .Select(user => HomeViewModel.FromEntity(user))
                .ToListAsync();

            UsersList = new SelectList(listUsers, "Id", "Nominativo");
            
            return Page();
        }
    }
}