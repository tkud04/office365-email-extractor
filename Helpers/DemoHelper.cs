using System;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using kloud.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace kloud.Helpers
{
    public class DemoHelper : IDemoHelper
    {	
       private readonly string[] _categories = {
			                       "Phones & Tablets",
			                       "TV & Electronics",
								   "Fashion",
								   "Computers",
								   "Groceries",
								   "Unique Bundles",
								   "Health & Beauty",
								   "Home & Office",
								   "Babies, Kids & Toys",
								   "Games & Consoles",
								   "Watches & Sunglasses",
								   "Other Categories"
			};
			
			private readonly string[] _qs = {
			                       "phones-ablets",
			                       "tv-electronics",
								   "fashion",
								   "computers",
								   "groceries",
								   "unique-bundles",
								   "health-beauty",
								   "home-office",
								   "babies-kids-toys",
								   "games-consoles",
								   "watches-sunglasses",
								   "others"
			};
			
			private List<Categories> _cats; 
			
			private string DbConfig = "server=us-cdbr-iron-east-05.cleardb.net;user=b4318af64bea35;database=heroku_1e574819c23f64c;port=3306;password=9d6ecea4";
			
           public DemoHelper()
           {
             _cats = new List<Categories>();
             
             for(int i = 0; i < _categories.Length; i++)
			  {
				_cats.Add(new Categories{Name = _categories[i], q = _qs[i]});
			  }
           }
			
		
		public string getRole(string email)
		{
			string ret = "NoRole";
		
			return ret;
		}
		
		public List<Categories> getCategories()
		{
			List<Categories> ret = _cats;
			return ret;
			
		}
		
		public Categories getCategory(string q)
		{
			Categories ret = _cats.FirstOrDefault(m => m.q == q);
			return ret;
			
		}
		
		public string getDB()
		{
			string ret = "";
            MySqlConnection conn = new MySqlConnection(DbConfig);
           
            try
            {
              conn.Open();
              string sql = "select version()";
              MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ret = rdr[0].ToString();
            }
            rdr.Close();
            
           }
            catch(Exception ex)
            {
               ret = ex.ToString();
            }
			
			conn.Close();
			return ret; 
		}
	}
}