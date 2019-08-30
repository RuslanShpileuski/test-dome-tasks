namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
	using System.Collections.Generic;
	using TestDome.Tasks;

	[TestClass]
	public class AlertServiceTests
	{
		[TestMethod]
		[ExpectedException(typeof(KeyNotFoundException))]
		public void AlertService_GetAlertTime()
		{
			// Arrange.
			IAlertDAO alertDAO = new AlertDAO();
			AlertService alertService = new AlertService(alertDAO);

			// Act.
			alertService.RaiseAlert();
			alertService.GetAlertTime(Guid.NewGuid());

			// Assert.
		}
	}
}