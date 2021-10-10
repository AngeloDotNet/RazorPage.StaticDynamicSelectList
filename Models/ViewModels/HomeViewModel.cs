using System.Collections.Generic;
using SelectListMvc_Load_Static_Dynamic.Models.Entities;

namespace SelectListMvc_Load_Static_Dynamic.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<UserViewModel> UsersFromDatabase { get; set; }
    }
}