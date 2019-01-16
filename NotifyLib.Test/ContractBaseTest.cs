using Moq;
using NotifyLib.Base;
using NotifyLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NotifyLib.Test
{
	public class ContractBaseTest
	{
		[Fact]
		void ContractBase_AddRule(){
			var sut = new Mock<ContractBase>();
			var sutRule = new Mock<IRuleBase>();
			var sutNotifiableBase = new Mock<NotifiableBase>();

			sutRule
			.Setup(r => r.Message)
			.Returns(() => "Test");

			sutRule
			.Setup(r => r.Test(sutNotifiableBase.Object))
			.Returns(() => false);

			sut
			.Setup(c => c.Rules())
			.Returns(() => new List<IRuleBase>() { sutRule.Object });

			sut.Object.Validate(sutNotifiableBase.Object);

			Assert
			.False(sutNotifiableBase.Object.Valid(), "Rule not added or not running.");
			Assert
			.True(sutNotifiableBase.Object.Notifications().Contains("Test"), "Notification \"Test\" not found.");
		}
	}
}
