using System.Collections.Generic;
using StationKeypad.DataModel;

namespace StationKeypad.Data
{
	public class StationRepository : IStationRepository
	{
		public List<Station> GetAllInOrder()
		{
			return new List<Station>
			{
				new Station
				{
					Name = "Test",
					Code = "T"
				},
				new Station
				{
					Name = "Test 2",
					Code = "T2"
				}
			};
		}
	}
}