using System;
using System.ComponentModel.DataAnnotations;

namespace kloud.Models
{
    public class Products
    {
        public string Id { get; set; }
        
		[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
		[Required]
		public string Name { get; set; }
		
		[Required]
		public string Description { get; set; }
		
		[Required]
		[Display(Name = "Current Price(&#8358;)")]
		[DataType(DataType.Currency)]
		public string Price { get; set; }
        
		[Display(Name = "Upload Date")]
		[DataType(DataType.Date)]
        public DateTime DateAdded{ get; set; }
    }
}