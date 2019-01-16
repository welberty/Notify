
namespace NotifyLib.Interfaces
{
	public interface IContractBase
	{	
		void Validate(INotifiableBase obj);
		IContractBase AddRule(IRuleBase rule);
	}
}
