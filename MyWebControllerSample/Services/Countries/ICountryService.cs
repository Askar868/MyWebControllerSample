using MyWebControllerSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Services
{
	public interface ICountryService
	{
		public IEnumerable<Country> GetCountries();
		public IEnumerable<Region> GetRegions(int id);
	}
}
