using Moq;
using NotifyLib.Base;
using Xunit;

namespace NotifyLib.Test
{
	public class NotifiableBaseTest
	{
		[Fact]
		public void NotifiableBase_AddNotification(){
			var sut = new Mock<NotifiableBase>();
			sut.Object.AddNotification("Test");
			Assert.True(sut.Object.Notifications().Contains("Test"), "Notification not added.");
		}

		[Fact]
		public void NotifiableBase_Is_Not_Valid()
		{
			var sut = new Mock<NotifiableBase>();
			sut.Object.AddNotification("Test");
			Assert.False(sut.Object.Valid(), "Class is valid.");
		}
		[Fact]
		public void NotifiableBase_Is_Valid()
		{
			var sut = new Mock<NotifiableBase>();
			Assert.True(sut.Object.Valid(), "Class is not valid.");
		}
		[Fact]
		public void NotifiableBase_ClearNotifications()
		{
			var sut = new Mock<NotifiableBase>();
			sut.Object.AddNotification("Test");
			sut.Object.ClearNotifications();
			Assert.True(sut.Object.Valid(), "Notifications not cleaned.");
		}


	}
}
