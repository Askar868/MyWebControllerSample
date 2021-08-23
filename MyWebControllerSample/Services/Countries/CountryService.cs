using MyWebControllerSample.Models;
using MyWebControllerSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebControllerSample.Services
{
	public class CountryService : ICountryService
	{
		public IEnumerable<Country> GetCountries()
		{
			var Country = new List<Country>
			{
				new Country()
				{
					Name = "Узбекистан",
					ID = 1,
					QuantityOfRegions = 12,
				},
				new Country()
				{
					Name = "Россия",
					ID = 2,
					QuantityOfRegions = 8,
				},
				new Country()
				{
					Name = "Германия",
					ID = 3,
					QuantityOfRegions = 17,
				},
		};
			return Country;
		}]]]]]

		public IEnumerable<Region> GetRegions(int id)
		{
			var Country = new List<Country>
			{
				new Country()
				{
					ID = 1,
					region = new List<Region>{ new Region(){RegionName = "Навоийская область", CountryId = 1, RegionArea = "110 тысяч км", RegionPopulation = "122 тысячи человек" },
				new Region(){RegionName = "Андижанская область", CountryId = 1, RegionArea = "4.2 тысяч км", RegionPopulation = "352 тысячи человек" },
				new Region(){RegionName = "Бухарская область", CountryId = 1, RegionArea = "39,4 тысяч км", RegionPopulation = "237 тысяч человек" },
				new Region(){RegionName = "Джизакская область", CountryId = 1, RegionArea = "20,5 тысяч км", RegionPopulation = "136 тысяч человек" } },
				},
				new Country()
				{
					ID = 2,
					region = new List<Region>{  new Region(){RegionName = "Центральный федеральный округ", CountryId = 2, RegionArea = "650 205 км", RegionPopulation = "39 250 960 человек"},
				new Region(){RegionName = "Северо-Западный федеральный округ", CountryId = 2, RegionArea = "1 686 972 км", RegionPopulation = "13 941 959 человек" },
				new Region(){RegionName = "Южный федеральный округ", CountryId = 2, RegionArea = "447 821 км", RegionPopulation = "16 482 488 человек" },
				new Region(){RegionName = "Приволжский федеральный округ", CountryId = 2, RegionArea = "1 036 975 км", RegionPopulation = "29 070 827 человек" }, }
				},
				new Country()
				{
					ID = 3,
					region = new List<Region>{new Region(){RegionName = "Баден-Вюртемберг", CountryId = 3, RegionArea = "35 748,22 км", RegionPopulation = "11 069 533 человек" },
				new Region(){RegionName = "Свободное государство Бавария", CountryId = 3, RegionArea = "70 541,57 км", RegionPopulation = "13 076 721 человек" },
				new Region(){RegionName = "Берлин", CountryId = 3, RegionArea = "891,12 км", RegionPopulation = "3 644 826 человек" },
				new Region(){RegionName = "Бранденбург", CountryId = 3, RegionArea = "29 654,48 км", RegionPopulation = "2 511 917 человек" } }
				},
		};

			var region = Country.Where(Country => Country.ID == id).SelectMany(Country => Country.region);

			return region;
		}
	}


	//var regions = new List<Region>
	//{
	//	new Region(){RegionName = "Республика Каракалпакстан", id = 1 },
	//	new Region(){RegionName = "Андижанская область", id = 1 },
	//	new Region(){RegionName = "Бухарская область", id = 1 },
	//	new Region(){RegionName = "Джизакская область", id = 1 },
	//	new Region(){RegionName = "Центральный федеральный округ", id = 2 },
	//	new Region(){RegionName = "Северо-Западный федеральный округ", id = 2 },
	//	new Region(){RegionName = "Южный федеральный округ", id = 2 },
	//	new Region(){RegionName = "Приволжский федеральный округ", id = 2 },
	//	new Region(){RegionName = "Баден-Вюртемберг", id = 3 },
	//	new Region(){RegionName = "Свободное государство Бавария", id = 3 },
	//	new Region(){RegionName = "Берлин", id = 3 },
	//	new Region(){RegionName = "Бранденбург", id = 3 },
	//};
	//return regions;
	//List<Country> con;
	//con = GetCountries().ToList();
	//var coun = from c in con
	//		   where c.ID == id
	//		   select c;
	//return coun;
}


//public IEnumerable<Country> GetAll()
//{
//	List<Country> c1 = GetCountries().ToList();
//	List<Region> r1 = GetRegions().ToList();

//	var result = c1.GroupJoin(
//		r1,
//		c => c.ID,
//		r => r.id,
//		(c1, r1) => new
//		{
//			region = r1.Select(rr => rr.RegionName)
//		});

//	return result;

//}


//var result2 = teams.GroupJoin(
//				players, // второй набор
//				t => t.Name, // свойство-селектор объекта из первого набора
//				pl => pl.Team, // свойство-селектор объекта из второго набора
//				(team, pls) => new  // результирующий объект
//				{
//					Name = team.Name,
//					Country = team.Country,
//					Players = pls.Select(p => p.Name)
//				});



//public IEnumerable<Region> GetRegions(int id)
//{
//	var regions = new List<Region>
//	{
//		new Region(){RegionName = "Республика Каракалпакстан", id = 1 },
//		new Region(){RegionName = "Андижанская область", id = 1 },
//		new Region(){RegionName = "Бухарская область", id = 1 },
//		new Region(){RegionName = "Джизакская область", id = 1 },
//		new Region(){RegionName = "Центральный федеральный округ", id = 2 },
//		new Region(){RegionName = "Северо-Западный федеральный округ", id = 2 },
//		new Region(){RegionName = "Южный федеральный округ", id = 2 },
//		new Region(){RegionName = "Приволжский федеральный округ", id = 2 },
//		new Region(){RegionName = "Баден-Вюртемберг", id = 3 },
//		new Region(){RegionName = "Свободное государство Бавария", id = 3 },
//		new Region(){RegionName = "Берлин", id = 3 },
//		new Region(){RegionName = "Бранденбург", id = 3 },
//	};
//	return regions;

//	var regionss = from region in regions
//				   where region.id == id
//				   select region;
//	return regionss;



//List<Country> countries = GetCountries().ToList();

//var result2 =  regions.GroupJoin(
//			countries, // второй набор
//			t => t.id, // свойство-селектор объекта из первого набора
//			pl => pl.ID, // свойство-селектор объекта из второго набора
//			(t, pl) => new { t, pl} // результирующий объект
//			     );
//return (IEnumerable<Region>)result2;

//var result3 = from reg in countries
//			  where reg.ID == id
//			  select reg;
//return (IEnumerable<Region>)result3;