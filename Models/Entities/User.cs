using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SelectListMvc_Load_Static_Dynamic.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        
        public string Cognome { get; set; }

        public string Nome { get; set; }
    }
}