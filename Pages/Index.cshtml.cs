using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SelectListMvc_Load_Static_Dynamic.Models.Enums;
using SelectListMvc_Load_Static_Dynamic.Models.Services.Application;
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
        public SelectList PeopleList { get; set; }

        public ListViewModel<UserViewModel> Users { get; set; }

        public async Task<IActionResult> OnGetAsync([FromServices] IUserService userService)
        {
            List<UserViewModel> listUsers = await userService.GetUsersFromDatabase();

            List<UserViewModel> listPeople = await userService.GetUsersFromDatabase();

            UsersList = new SelectList(listUsers, "Id", "Nominativo");

            PeopleList = new SelectList(listPeople, "Id", "Nominativo");

            Users = await userService.GetListaUtenti();
            
            return Page();
        }
    }
}