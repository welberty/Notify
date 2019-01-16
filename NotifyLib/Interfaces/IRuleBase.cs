
namespace NotifyLib.Interfaces
{
	public interface IRuleBase
	{
		string Message { get; set; }
		bool Test(INotifiableBase obj);
	}
}
