using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace kloud.Models
{
    public class IndexViewModel
    {
        public List<Categories> categories { get; set; }        
    }
}