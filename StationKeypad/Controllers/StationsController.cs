using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using StationKeypad.Services;

namespace StationKeypad.Controllers
{
	public class StationsController : ApiController
	{
		private readonly IStationService stationService;

		public StationsController(IStationService stationService)
		{
			this.stationService = stationService;
		}

		public IEnumerable<string> GetAllStationsInOrder()
		{
			return stationService.GetStationsOrderedByName().Select(station => station.Name);
		}
	}
}