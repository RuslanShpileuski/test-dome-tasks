namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using TestDome.Tasks;

	[TestClass]
	public class BinarySearchTreeTests
	{
		[TestMethod]
		public void BinarySearchTree_Contains()
		{
			// Arrange.
			Node n1 = new Node(1, null, null);
			Node n3 = new Node(3, null, null);
			Node n2 = new Node(2, n1, n3);

			BinarySearchTree bst = new BinarySearchTree();

			// Act.
			bool firstActual = bst.Contains(n2, 3);
			bool secondActual = bst.Contains(n2, 4);

			// Assert.
			Assert.IsTrue(firstActual);
			Assert.IsFalse(secondActual);
		}
	}
}