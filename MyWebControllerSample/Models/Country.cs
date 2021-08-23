using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Models
{
	public class Country
	{
		/// <summary>
		/// свойство содержит название страны
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Свойсвто содержит список регионов
		/// </summary>
		public List<Region> region { get; set; }
		/// <summary>
		/// свойсвто содержит id страны
		/// </summary>
		public int ID { get; set; }
		/// <summary>
		/// свойство содержит количесвто регионов
		/// </summary>
		public int QuantityOfRegions { get; set; }

	}
	
}
