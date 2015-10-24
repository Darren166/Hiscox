using System;
namespace StationKeypad.Services
{
	public interface IStationService
	{
		System.Collections.Generic.List<Station> GetStationsOrderedByName();
	}
}
