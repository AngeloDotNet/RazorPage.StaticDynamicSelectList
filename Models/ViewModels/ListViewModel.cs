using System.Collections.Generic;

namespace SelectListMvc_Load_Static_Dynamic.Models.ViewModels
{
    public class ListViewModel<T>
    {
        public List<T> Results { get; set; }
    }
}