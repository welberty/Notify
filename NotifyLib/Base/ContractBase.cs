

using NotifyLib.Interfaces;
using System.Collections.Generic;

namespace NotifyLib.Base
{
	public abstract class ContractBase : IContractBase
	{
		public abstract IList<IRuleBase> Rules();
		
		public void Validate(INotifiableBase obj)
		{
			foreach (var item in Rules())
			{
				var test = item.Test(obj);
				if (!test)
					obj.AddNotification(item.Message);
			}
		}
		
	}
}
