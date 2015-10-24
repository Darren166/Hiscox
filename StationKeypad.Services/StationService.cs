using System.Collections.Generic;
using StationKeypad.Data;
using StationKeypad.DataModel;

namespace StationKeypad.Services
{
	public class StationService : IStationService
	{
		private readonly IStationRepository stationRepository;

		public StationService(IStationRepository stationRepository)
		{
			this.stationRepository = stationRepository;
		}

		public List<Station> GetStationsOrderedByName()
		{
			return stationRepository.GetAllInOrder();
		}
	}
}