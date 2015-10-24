using System.Collections.Generic;
using StationKeypad.DataModel;

namespace StationKeypad.Data
{
	public interface IStationRepository
	{
		List<Station> GetAllInOrder();
	}
}