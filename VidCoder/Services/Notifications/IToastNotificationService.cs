using System.Collections.Generic;
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications;

namespace VidCoder.Services.Notifications
{
	public interface IToastNotificationService
	{
		/// <summary>
		/// Shows the given toast content.
		/// </summary>
		void ShowToast(ToastContent toastContent);

		/// <summary>
		/// Removes all notifications sent by this app from action center.
		/// </summary>
		void Clear();

		/// <summary>
		/// Gets all notifications sent by this app that are currently still in Action Center.
		/// </summary>
		/// <returns>A collection of toasts.</returns>
		IReadOnlyList<ToastNotification> GetHistory();

		/// <summary>
		/// Removes an individual toast, with the specified tag label, from action center.
		/// </summary>
		/// <param name="tag">The tag label of the toast notification to be removed.</param>
		void Remove(string tag);

		/// <summary>
		/// Removes a toast notification from the action using the notification's tag and group labels.
		/// </summary>
		/// <param name="tag">The tag label of the toast notification to be removed.</param>
		/// <param name="group">The group label of the toast notification to be removed.</param>
		void Remove(string tag, string group);

		/// <summary>
		/// Removes a group of toast notifications, identified by the specified group label, from action center.
		/// </summary>
		/// <param name="group">The group label of the toast notifications to be removed.</param>
		void RemoveGroup(string group);
	}
}