/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	13. Train Composition

	A TrainComposition is built by attaching and detaching wagons from the left and the right sides, efficiently with respect to time used.

	For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13, again from the left, we get a composition of two wagons (13 and 7 from left to right). 
	Now the first wagon that can be detached from the right is 7 and the first that can be detached from the left is 13.

	Implement a TrainComposition that models this problem.
*/
namespace TestDome.Tasks
{
	/// <summary>
	/// The train node.
	/// </summary>
	public class TrainNode
	{
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public int Value { get; set; }

		/// <summary>
		/// Gets or sets the left train.
		/// </summary>
		/// <value>
		/// The left train.
		/// </value>
		public TrainNode LeftTrain { get; set; }

		/// <summary>
		/// Gets or sets the rigth train.
		/// </summary>
		/// <value>
		/// The rigth train.
		/// </value>
		public TrainNode RigthTrain { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TrainNode"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public TrainNode(int value)
		{
			Value = value;
			LeftTrain = null;
			RigthTrain = null;
		}

		/// <summary>
		/// Sets the right train.
		/// </summary>
		/// <param name="right">The right.</param>
		public void SetRightTrain(TrainNode right)
		{
			RigthTrain = right;
		}

		/// <summary>
		/// Sets the left train.
		/// </summary>
		/// <param name="left">The left.</param>
		public void SetLeftTrain(TrainNode left)
		{
			LeftTrain = left;
		}
	}

	/// <summary>
	/// The train composition.
	/// </summary>
	public class TrainComposition
	{
		/// <summary>
		/// Gets or sets the leftmost.
		/// </summary>
		/// <value>
		/// The leftmost.
		/// </value>
		private TrainNode Leftmost { get; set; }

		/// <summary>
		/// Gets or sets the rightmost.
		/// </summary>
		/// <value>
		/// The rightmost.
		/// </value>
		private TrainNode Rightmost { get; set; }

		/// <summary>
		/// Attaches the wagon from left.
		/// </summary>
		/// <param name="wagonId">The wagon identifier.</param>
		public void AttachWagonFromLeft(int wagonId)
		{
			TrainNode tmp = new TrainNode(wagonId);

			if (Leftmost != null)
			{
				Leftmost.SetLeftTrain(tmp);
				tmp.SetRightTrain(Leftmost);
				Leftmost = tmp;
			}
			else
			{
				Leftmost = tmp;
				Rightmost = tmp;
			}
		}

		/// <summary>
		/// Attaches the wagon from right.
		/// </summary>
		/// <param name="wagonId">The wagon identifier.</param>
		public void AttachWagonFromRight(int wagonId)
		{
			TrainNode tmp = new TrainNode(wagonId);

			if (Rightmost != null)
			{
				Rightmost.SetRightTrain(tmp);
				tmp.SetLeftTrain(Rightmost);
				Rightmost = tmp;
			}
			else
			{
				Leftmost = tmp;
				Rightmost = tmp;
			}
		}

		/// <summary>
		/// Detaches the wagon from left.
		/// </summary>
		/// <returns></returns>
		public int DetachWagonFromLeft()
		{
			TrainNode tmp;

			if (Leftmost != null)
			{
				tmp = Leftmost;
				Leftmost = Leftmost.RigthTrain;
				int tmpValue = tmp.Value;
				return tmpValue;
			}
			else
			{
				return 0;
			}
		}

		/// <summary>
		/// Detaches the wagon from right.
		/// </summary>
		/// <returns></returns>
		public int DetachWagonFromRight()
		{
			TrainNode tmp;

			if (Rightmost != null)
			{
				tmp = Rightmost;
				Rightmost = Rightmost.LeftTrain;
				int tmpValue = tmp.Value;
				return tmpValue;
			}
			else
			{
				return 0;
			}
		}
	}
}