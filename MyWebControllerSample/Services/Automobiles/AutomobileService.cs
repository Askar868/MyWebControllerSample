using MyWebControllerSample.Models;
using MyWebControllerSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Services
{
	public class AutomobileServiceFake : IAutomobileService
	{

		public IEnumerable<Automobile> GetAll()
		{
			var automobiles = new List<Automobile> // Создание и заполнение коллекции 
			{
			new Automobile() { CarName = "Toyota", Present_year = 2015, ID = 1,  Price = 100 },
			new Automobile() { CarName = "Nissan", Present_year = 2021, ID = 2,  Price = 50 },
			new Automobile() { CarName = "KIA", Present_year = 2019, ID = 3,  Price = 200},
			new Automobile() { CarName = "Chevrolet", Present_year = 2014, ID = 4,  Price = 150 },
			new Automobile() { CarName = "Hyundai", Present_year = 2020, ID = 5, Price = 100 },
		};
			return automobiles;
		}

		public IEnumerable<Automobile> GetIdentified(int id)
		{
			List<Automobile> auto2;
			auto2 = GetAll().ToList();
			var automobiles = from auto in auto2
							  where auto.ID == id
							  select auto;
			return automobiles;
		}

		public IEnumerable<Automobile> GetFiltered(int year = 0, int price = 0)
		{
			List<Automobile> auto1;
			auto1 = GetAll().ToList();
			var automobil = from auto in auto1
							where auto.Present_year >= year && auto.Price >= price
							select auto;
			return automobil;
		}
	}


	//public class AutomobileServiceReal : IAutomobileService
	//{
	//	public IEnumerable<Automobile> GetAll()
	//	{
	//		return new List<Automobile>();
	//	}
	//}
}

