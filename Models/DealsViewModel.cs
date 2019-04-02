using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace kloud.Models
{
    public class DealsViewModel
    {
        public List<Categories> categories { get; set; }
        public Categories category { get; set; }
    }
}