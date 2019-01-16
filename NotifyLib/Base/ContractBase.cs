

using NotifyLib.Interfaces;
using System.Collections.Generic;

namespace NotifyLib.Base
{
	public abstract class ContractBase : IContractBase
	{
		private List<IRuleBase> rules;

		public ContractBase()
		{
			rules = new List<IRuleBase>();
		}

		public IContractBase AddRule(IRuleBase rule)
		{
			rules.Add(rule);
			return this;
		}

		public void Validate(INotifiableBase obj)
		{
			foreach (var item in rules)
			{
				var test = item.Test(obj);
				if (!test)
					obj.AddNotification(item.Message);
			}
		}
		
	}
}
