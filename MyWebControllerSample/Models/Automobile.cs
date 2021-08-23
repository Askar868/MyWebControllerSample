using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Models
{
	public class Automobile
	{
		//public List<string> CarColor { get; set; } // свойство CarColor определяет цвет авто
		/// <summary>
		/// свойство содержит марку авто
		/// </summary>
		public string CarName { get; set; }
		/// <summary>
		/// свойство содержит год презентации авто
		/// </summary>
		public int Present_year { get; set; }
		/// <summary>
		/// свойтсво содержит цену авто
		/// </summary>
		public int Price { get; set; } 
		/// <summary>
		/// id автомобиля
		/// </summary>
		public int ID { get; set; } // id автомобиля
	}
}
