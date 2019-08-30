/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18
	
	1. Alert Service
	
	Refactor the AlertService and AlertDAO classes:

		Create a new interface, named IAlertDAO, that contains the same methods as AlertDAO.
		AlertDAO should implement the IAlertDAO interface.
		AlertService should have a constructor that accepts IAlertDAO.
		The RaiseAlert and GetAlertTime methods should use the object passed through the constructor.
*/

namespace TestDome.Tasks
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// The alert service.
	/// </summary>
	public class AlertService
	{
		private readonly IAlertDAO alertDao;

		/// <summary>
		/// Initializes a new instance of the <see cref="AlertService"/> class.
		/// </summary>
		/// <param name="alertDao">The alert DAO.</param>
		public AlertService(IAlertDAO alertDao)
		{
			this.alertDao = alertDao;
		}

		/// <summary>
		/// Raises the alert.
		/// </summary>
		/// <returns></returns>
		public Guid RaiseAlert()
		{
			return alertDao.AddAlert(DateTime.Now);
		}

		/// <summary>
		/// Gets the alert time.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns>The datetime value.</returns>
		public DateTime GetAlertTime(Guid id)
		{
			return alertDao.GetAlert(id);
		}
	}

	/// <summary>
	/// The alert DAO.
	/// </summary>
	/// <seealso cref="TestDome.Tasks.IAlertDAO" />
	public class AlertDAO : IAlertDAO
	{
		private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

		/// <inheritdoc />
		public Guid AddAlert(DateTime time)
		{
			Guid id = Guid.NewGuid();
			alerts.Add(id, time);
			return id;
		}

		/// <inheritdoc />
		public DateTime GetAlert(Guid id)
		{
			return alerts[id];
		}
	}

	/// <summary>
	/// The alert DAO interface.
	/// </summary>
	public interface IAlertDAO
	{
		/// <summary>
		/// Adds the alert.
		/// </summary>
		/// <param name="time">The time.</param>
		/// <returns></returns>
		Guid AddAlert(DateTime time);

		/// <summary>
		/// Gets the alert.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		DateTime GetAlert(Guid id);
	}
}