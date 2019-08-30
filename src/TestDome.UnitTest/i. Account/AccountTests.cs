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
			bool writerDelete = Account.Access.Writer.HasFlag(Account.Access.Delete);
			bool writerSubmit = Account.Access.Writer.HasFlag(Account.Access.Submit);
			bool writerModify = Account.Access.Writer.HasFlag(Account.Access.Modify);

			bool editorDelete = Account.Access.Editor.HasFlag(Account.Access.Delete);
			bool editorPublish = Account.Access.Editor.HasFlag(Account.Access.Publish);
			bool editorComment = Account.Access.Editor.HasFlag(Account.Access.Comment);

			bool ownerWriter = Account.Access.Owner.HasFlag(Account.Access.Writer);
			bool ownerEditor = Account.Access.Owner.HasFlag(Account.Access.Editor);

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