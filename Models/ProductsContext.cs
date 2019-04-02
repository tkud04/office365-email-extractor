using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace kloud.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options)
		     : base(options)
			 {
				 
			 }
		
		public DbSet<kloud.Models.Products> Products {get; set;}
    }
}