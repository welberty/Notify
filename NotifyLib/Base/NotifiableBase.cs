
using System.Collections.Generic;
using NotifyLib.Interfaces;

namespace NotifyLib.Base
{
	public abstract class NotifiableBase : INotifiableBase
	{
		private List<string> _Notifications;

		public NotifiableBase()
		{
			_Notifications = new List<string>();
		}

		public void AddNotification(string notification)
		{
			_Notifications.Add(notification);
		}

		public void ClearNotifications()
		{
			_Notifications.Clear();
		}

		public IList<string> Notifications()
		{
			return _Notifications;
		}

		public bool Valid()
		{
			return _Notifications.Count == 0;
		}
	}
}
