using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationKeypad.Services
{
	public class StationService : IStationService
	{
		public List<Station> GetStationsOrderedByName()
		{
			return new List<Station>{
				new Station{
					Name="Test",
					Code = "T"
				},
				new Station{
					Name="Test 2",
					Code = "T2"
				}
			};
		}
	}
}
