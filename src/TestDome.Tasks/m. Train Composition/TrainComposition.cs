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
	public class TrainNode
	{
		public int Value { get; set; }
		public TrainNode LeftTrain { get; set; }
		public TrainNode RigthTrain { get; set; }

		public TrainNode(int value)
		{
			this.Value = value;
			this.LeftTrain = null;
			this.RigthTrain = null;
		}

		public void SetRightTrain(TrainNode right)
		{
			this.RigthTrain = right;
		}

		public void SetLeftTrain(TrainNode left)
		{
			this.LeftTrain = left;
		}
	}
	public struct TrainComposition
	{
		private TrainNode Leftmost { get; set; }
		private TrainNode Rightmost { get; set; }

		public void AttachWagonFromLeft(int wagonId)
		{
			var tmp = new TrainNode(wagonId);

			if (this.Leftmost != null)
			{
				this.Leftmost.SetLeftTrain(tmp);
				tmp.SetRightTrain(this.Leftmost);
				this.Leftmost = tmp;
			}
			else
			{
				this.Leftmost = tmp;
				this.Rightmost = tmp;
			}
		}

		public void AttachWagonFromRight(int wagonId)
		{
			var tmp = new TrainNode(wagonId);

			if (this.Rightmost != null)
			{
				this.Rightmost.SetRightTrain(tmp);
				tmp.SetLeftTrain(this.Rightmost);
				this.Rightmost = tmp;
			}
			else
			{
				this.Leftmost = tmp;
				this.Rightmost = tmp;
			}
		}

		public int DetachWagonFromLeft()
		{
			TrainNode tmp;

			if (this.Leftmost != null)
			{
				tmp = this.Leftmost;
				this.Leftmost = this.Leftmost.RigthTrain;
				int tmpValue = tmp.Value;
				return tmpValue;
			}
			else
			{
				return 0;
			}
		}

		public int DetachWagonFromRight()
		{
			TrainNode tmp;

			if (this.Rightmost != null)
			{
				tmp = this.Rightmost;
				this.Rightmost = this.Rightmost.LeftTrain;
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