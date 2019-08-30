namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using TestDome.Tasks;

	[TestClass]
	public class TrainCompositionTests
	{
		[TestMethod]
		public void TrainComposition_DetachWagonFromRight_DetachWagonFromLeft()
		{
			// Arrange.
			var trainComposition = new TrainComposition();
			trainComposition.AttachWagonFromLeft(7);
			trainComposition.AttachWagonFromLeft(13);

			// Act.
			var actualRight = trainComposition.DetachWagonFromRight(); // 7 
			var actualLeft = trainComposition.DetachWagonFromLeft(); // 13

			// Assert.
			Assert.AreEqual(7, actualRight);
			Assert.AreEqual(13, actualLeft);
		}
	}
}