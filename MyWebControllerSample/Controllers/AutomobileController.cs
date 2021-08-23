using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebControllerSample.Models;
using MyWebControllerSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Controllers
{
	[ApiController]
	public class AutomobileController : ControllerBase
	{
		IAutomobileService _service;
		public AutomobileController(IAutomobileService service)
		{
			_service = service;
		}

		[HttpGet]
		[Route("api/[controller]/automobiles")]
		public List<Automobile> GetAutomobiles()
		{
			return _service.GetAll().ToList();
		}

		[HttpGet]
		[Route("api/[controller]/filtered")]
		public List<Automobile> GetFiltereddAuto(int price, int year)
		{
			return _service.GetFiltered(price, year).ToList();
		}

		[HttpGet]
		[Route("api/[controller]/identified")]
		public List<Automobile> GetIdentifiedAuto(int id)
		{
			return _service.GetIdentified(id).ToList();
		}

	}
}
