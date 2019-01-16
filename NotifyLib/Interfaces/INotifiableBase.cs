
using System.Collections.Generic;

namespace NotifyLib.Interfaces
{
	public interface INotifiableBase
	{
		IList<string> Notifications();
		void AddNotification(string notification);
		void ClearNotifications();
		bool Valid();
	}
}
