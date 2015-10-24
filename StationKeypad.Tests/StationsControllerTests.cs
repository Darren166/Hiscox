using NUnit.Framework;
using StationKeypad.Controllers;
using StationKeypad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Moq;


namespace StationKeypad.Tests
{
	[TestFixture]
	public class StationsControllerTests
	{
		[Test]
		public void Returns_All_Stations()
		{
			// Given a stations controller with an injected mock StationService
			StationsController stationsController = createStationsControllerWithMockStationService();

			//// When a list of all stations is requested
			List<string> stationNames = stationsController.GetAllStationsInOrder().ToList();

			//// Then it has 4 stations
			Assert.AreEqual(2, stationNames.Count);
		}

		private StationsController createStationsControllerWithMockStationService()
		{
			var stations = createStations();
			var mockStationService = new Mock<IStationService>();
			mockStationService.Setup(service => service.GetStationsOrderedByName()).Returns(stations);
			StationsController stationsController = new StationsController(new StationService());
			return stationsController;
		}

		private List<Station> createStations()
		{
			return new List<Station>{
			new Station{
			Name="Berkhamsted",
			Code="Ber"
				},
				new Station{
			Name="Watford",
			Code="Wat"
				}};
		}
	}
}
