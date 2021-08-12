using System.ComponentModel.DataAnnotations;

namespace SelectListMvc_Load_Static_Dynamic.Models.Enums
{
    public enum Utenti
    {
        [Display(Name = "Rossi Mario")]
        Rossi,

        [Display(Name = "Verdi Giuseppe")]
        Verdi,

        [Display(Name = "Neri Francesco")]
        Neri,

        [Display(Name = "Gialli Giorgio")]
        Gialli,

        [Display(Name = "Bianchi Carlo")]
        Bianchi
    }
}