using System.Collections.Generic;
using StationKeypad.DataModel;

namespace StationKeypad.Services
{
	public interface IStationService
	{
		List<Station> GetStationsOrderedByName();
	}
}