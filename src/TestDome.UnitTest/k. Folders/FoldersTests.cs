namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System.Collections.Generic;
	using System.Linq;

	[TestClass]
	public class FoldersTests
	{
		[TestMethod]
		public void Folders_FolderNames()
		{
			// Arrange.
			string xml =
				"<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
				"<folder name=\"c\">" +
					"<folder name=\"program files\">" +
						"<folder name=\"uninstall information\" />" +
					"</folder>" +
					"<folder name=\"users\" />" +
				"</folder>";
			var expectedNames = new List<string> { "users", "uninstall information" };

			// Act.
			var actualNames = Folders.FolderNames(xml, 'u').Select(_ => _).ToList();

			// Assert.
			CollectionAssert.AreEqual(expectedNames, actualNames);
		}
	}
}