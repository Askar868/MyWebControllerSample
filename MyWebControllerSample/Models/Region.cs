using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Models
{
	public class Region
	{
		/// <summary>
		/// свойство содержит название региона
		/// </summary>
		public string RegionName { get; set; }
		/// <summary>
		/// свойство содержит id страны 
		/// </summary>
		public int CountryId { get; set; }
		/// <summary>
		/// свойство содержит площадь региона
		/// </summary>
		public string RegionArea { get; set; }
		/// <summary>
		/// свойство содержит численность региона
		/// </summary>
		public string RegionPopulation { get; set; }
	}
}
