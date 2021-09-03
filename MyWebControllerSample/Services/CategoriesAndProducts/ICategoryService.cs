using MyWebControllerSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Services
{
	public interface ICategoryService
	{
		public IEnumerable<Category> GetCategories();
		public IEnumerable<Product> GetProduct(int id);
	}
}
