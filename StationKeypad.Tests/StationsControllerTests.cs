using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using StationKeypad.Controllers;
using StationKeypad.DataModel;
using StationKeypad.Services;

namespace StationKeypad.Tests
{
	[TestFixture]
	public class StationsControllerTests
	{
		private StationsController createStationsControllerWithMockStationService()
		{
			var stations = createStations();
			var mockStationService = new Mock<IStationService>();
			mockStationService.Setup(service => service.GetStationsOrderedByName()).Returns(stations);
			var stationsController = new StationsController(mockStationService.Object);
			return stationsController;
		}

		private List<Station> createStations()
		{
			return new List<Station>
			{
				new Station
				{
					Name = "Abbey Wood",
					Code = "ABW"
				},
				new Station
				{
					Name = "Berkhamsted",
					Code = "BKM"
				},
				new Station
				{
					Name = "Hanwell",
					Code = "HAN"
				},
				new Station
				{
					Name = "Marlow",
					Code = "MLW"
				}
			};
		}

		[Test]
		public void Returns_All_Stations()
		{
			// Given a stations controller with an injected mock StationService
			var stationsController = createStationsControllerWithMockStationService();

			//// When a list of all stations is requested
			var stationNames = stationsController.GetAllStationsInOrder().ToList();

			//// Then it has 4 stations
			Assert.AreEqual(4, stationNames.Count);
		}

		[Test]
		public void Returns_Stations_In_Order()
		{
			// Given a stations controller with an injected mock StationService
			var stationsController = createStationsControllerWithMockStationService();

			//// When a list of all stations is requested
			var stationNames = stationsController.GetAllStationsInOrder().ToList();

			//// Then the stations are correctly ordered
			Assert.AreEqual("Abbey Wood", stationNames[0]);
			Assert.AreEqual("Berkhamsted", stationNames[1]);
			Assert.AreEqual("Hanwell", stationNames[2]);
			Assert.AreEqual("Marlow", stationNames[3]);
		}
	}
}