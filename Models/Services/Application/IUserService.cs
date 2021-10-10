using System.Collections.Generic;
using System.Threading.Tasks;
using SelectListMvc_Load_Static_Dynamic.Models.ViewModels;

namespace SelectListMvc_Load_Static_Dynamic.Models.Services.Application
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetUsersFromDatabase();
        Task<ListViewModel<UserViewModel>> GetListaUsers(int id);
    }
}