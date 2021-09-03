using MyWebControllerSample.Models;
using MyWebControllerSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Services
{
	public class CategoryService : ICategoryService
	{
		public IEnumerable<Category> GetCategories()
		{
			var context = new NorthwindContext();
			var categories = context.Categories.ToList();
			return categories;
		}

		public IEnumerable<Product> GetProduct(int id)
		{
			var context = new NorthwindContext();
			var products = context.Products.ToList();
			var product = from prod in products
						  where prod.CategoryId == id
						  select prod;
			return product;
		}

	}
}
