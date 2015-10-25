using Ninject.Modules;
using StationKeypad.Services;

namespace StationKeypad.IOC
{
	public class ServicesModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IStationService>().To<StationService>();
		}
	}
}