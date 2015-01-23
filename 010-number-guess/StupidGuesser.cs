using System;

namespace Pettys.NumberGuess {

	public class StupidGuesser : IGuesser {

		private Random _random = new Random();

		public int Guess(int minimum, int maximum) {
			return _random.Next(minimum, maximum+1);
		}

		public void Feedback(int yourGuess, bool tooLow, bool tooHigh) {
		}

	}

}
