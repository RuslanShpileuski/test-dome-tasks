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
	using System.Collections.Generic;
	using System;

	public class AlertService
	{
		private readonly IAlertDAO alertDao;

		public AlertService(IAlertDAO alertDao)
		{
			this.alertDao = alertDao;
		}

		public Guid RaiseAlert()
		{
			return this.alertDao.AddAlert(DateTime.Now);
		}

		public DateTime GetAlertTime(Guid id)
		{
			return this.alertDao.GetAlert(id);
		}
	}

	public class AlertDAO : IAlertDAO
	{
		private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

		public Guid AddAlert(DateTime time)
		{
			Guid id = Guid.NewGuid();
			this.alerts.Add(id, time);
			return id;
		}

		public DateTime GetAlert(Guid id)
		{
			return this.alerts[id];
		}
	}

	public interface IAlertDAO
	{
		Guid AddAlert(DateTime time);
		DateTime GetAlert(Guid id);
	}
}