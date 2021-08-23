using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebControllerSample.Models;
using MyWebControllerSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using static MyWebControllerSample.Models.Country;

namespace MyWebControllerSample.Controllers
{
	[ApiController]
	public class CountryController : ControllerBase
	{
		ICountryService _service2;
		public CountryController(ICountryService service)
		{
			_service2 = service;
		}

		[Route("api/[controller]/countries")]
		[HttpGet]
		public List<Country> GetCountries()
		{
			return _service2.GetCountries().ToList();
		}

		[Route("api/[controller]/regions")]
		[HttpGet]
		public List<Region> GetRegions(int id)
		{
			return _service2.GetRegions(id).ToList();
		}
	}
}