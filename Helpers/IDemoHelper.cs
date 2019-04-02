using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using kloud.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data;

namespace kloud.Helpers
{
    public interface IDemoHelper
    {
		string getRole(string email);
		List<Categories> getCategories();
		Categories getCategory(string q);
		string getDB();
		
    }
}