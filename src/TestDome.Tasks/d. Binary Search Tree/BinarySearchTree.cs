/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	4. Binary Search Tree
	
	Binary search tree (BST) is a binary tree where the value of each node is larger or equal to the values in all the nodes in that node's left subtree and is smaller than the values in all the nodes in that node's right subtree.

	Write a function that, efficiently with respect to time used, checks if a given binary search tree contains a given value.

	For example, for the following tree:

		n1 (Value: 1, Left: null, Right: null)
		n2 (Value: 2, Left: n1, Right: n3)
		n3 (Value: 3, Left: null, Right: null)
		Call to Contains(n2, 3) should return true since a tree with root at n2 contains number 3.
*/

namespace TestDome.Tasks
{
	/// <summary>
	/// The tree node.
	/// </summary>
	public class Node
	{
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public int Value { get; set; }

		/// <summary>
		/// Gets or sets the left.
		/// </summary>
		/// <value>
		/// The left.
		/// </value>
		public Node Left { get; set; }

		/// <summary>
		/// Gets or sets the right.
		/// </summary>
		/// <value>
		/// The right.
		/// </value>
		public Node Right { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Node"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		public Node(int value, Node left, Node right)
		{
			Value = value;
			Left = left;
			Right = right;
		}
	}

	/// <summary>
	/// The binary search tree.
	/// </summary>
	public class BinarySearchTree
	{
		/// <summary>
		/// Determines whether this root contains the value.
		/// </summary>
		/// <param name="root">The root.</param>
		/// <param name="value">The value.</param>
		/// <returns>
		///   <c>true</c> if [contains] [the specified root]; otherwise, <c>false</c>.
		/// </returns>
		public bool Contains(Node root, int value)
		{
			if (root.Value == value)
			{
				return true;
			}
			else if (value < root.Value)
			{
				if (root.Left == null)
				{
					return false;
				}

				return Contains(root.Left, value);
			}
			else if (value > root.Value)
			{
				if (root.Right == null)
				{
					return false;
				}

				return Contains(root.Right, value);
			}

			return false;
		}
	}
}