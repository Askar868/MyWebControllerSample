using MyWebControllerSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Services
{
	/// <summary>
	/// класс, который реализует данный интерфейс,
	/// является сервисом работы с данными для модели Automobile
	/// </summary>
	public interface IAutomobileService
	{
		public IEnumerable<Automobile> GetAll();
		public IEnumerable<Automobile> GetFiltered(int year, int price);
		public IEnumerable<Automobile> GetIdentified(int id);
	}

}
