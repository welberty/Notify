
using System.Collections.Generic;

namespace NotifyLib.Interfaces
{
	public interface IContractBase
	{	
		void Validate(INotifiableBase obj);
		IList<IRuleBase> Rules();

		//IContractBase AddRule(IRuleBase rule);
	}
}
