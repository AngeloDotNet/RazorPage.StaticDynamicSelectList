using System.Collections.Generic;
using SelectListMvc_Load_Static_Dynamic.Models.Entities;

namespace SelectListMvc_Load_Static_Dynamic.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<User> Users { get; set; }

        public int Id { get; private set; }
        public string Cognome { get; private set; }
        public string Nome { get; private set; }

        public static HomeViewModel FromEntity(User user)
        {
            return new HomeViewModel {
                Id = user.Id,
                Cognome = user.Cognome,   
                Nome = user.Nome
            };
        }
    }
}