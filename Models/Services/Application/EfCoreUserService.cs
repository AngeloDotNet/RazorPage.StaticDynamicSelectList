using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SelectListMvc_Load_Static_Dynamic.Models.Entities;
using SelectListMvc_Load_Static_Dynamic.Models.Services.Infrastructure;
using SelectListMvc_Load_Static_Dynamic.Models.ViewModels;

namespace SelectListMvc_Load_Static_Dynamic.Models.Services.Application
{
    public class EfCoreUserService : IUserService
    {
        private readonly ILogger<DemoDbContext> logger;
        private readonly DemoDbContext dbContext;

        public EfCoreUserService(ILogger<DemoDbContext> logger, DemoDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        public async Task<List<UserViewModel>> GetUsersFromDatabase()
        {
            ListViewModel<UserViewModel> lista = await GetListaUtenti();
            
            return lista.Results;
        }

        public async Task<ListViewModel<UserViewModel>> GetListaUtenti()
        {
            IQueryable<User> queryLinq = dbContext.Utenti
                .AsNoTracking();
            
            List<UserViewModel> listUsers = await queryLinq
                .Select(user => UserViewModel.FromEntity(user))
                .ToListAsync();

            ListViewModel<UserViewModel> result = new()
            {
                Results = listUsers
            };

            return result;
        }
    }
}