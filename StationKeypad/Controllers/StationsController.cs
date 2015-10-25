using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using StationKeypad.Services;
using WebApi.OutputCache.V2;

namespace StationKeypad.Controllers
{
	public class StationsController : ApiController
	{
		private readonly IStationService stationService;

		public StationsController(IStationService stationService)
		{
			this.stationService = stationService;
		}

		[CacheOutput(ClientTimeSpan = 300, ServerTimeSpan = 300)]
		public IEnumerable<string> GetAllStationsInOrder()
		{
			return stationService.GetStationsOrderedByName().Select(station => station.Name);
		}
	}
}