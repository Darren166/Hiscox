using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StationKeypad.Services;

namespace StationKeypad.Controllers
{
    public class StationsController : ApiController
    {
		public StationsController(IStationService stationService)
		{
			this.stationService = stationService;
		}

		IStationService stationService;

		public IEnumerable<string> GetAllStationsInOrder()
		{
			return stationService.GetStationsOrderedByName().Select(station=>station.Name);
		}
	}
}
