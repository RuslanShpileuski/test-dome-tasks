namespace TestDome.UnitTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using TestDome.Tasks.Flags;

	[TestClass]
	public class AccountTests
	{
		[TestMethod]
		public void Account_Access()
		{
			// Arrange.
			// Act.
			var writerDelete = Account.Access.Writer.HasFlag(Account.Access.Delete);
			var writerSubmit = Account.Access.Writer.HasFlag(Account.Access.Submit);
			var writerModify = Account.Access.Writer.HasFlag(Account.Access.Modify);

			var editorDelete = Account.Access.Editor.HasFlag(Account.Access.Delete);
			var editorPublish = Account.Access.Editor.HasFlag(Account.Access.Publish);
			var editorComment = Account.Access.Editor.HasFlag(Account.Access.Comment);

			var ownerWriter = Account.Access.Owner.HasFlag(Account.Access.Writer);
			var ownerEditor = Account.Access.Owner.HasFlag(Account.Access.Editor);

			// Assert.
			Assert.IsFalse(writerDelete);
			Assert.IsTrue(writerSubmit);
			Assert.IsTrue(writerModify);

			Assert.IsTrue(editorDelete);
			Assert.IsTrue(editorPublish);
			Assert.IsTrue(editorComment);

			Assert.IsTrue(ownerWriter);
			Assert.IsTrue(ownerEditor);
		}
	}
}