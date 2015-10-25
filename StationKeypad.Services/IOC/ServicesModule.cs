using Ninject.Modules;
using StationKeypad.Data;

namespace StationKeypad.Services.IOC
{
	public class ServicesModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IStationRepository>().To<StationRepository>();
		}
	}
}