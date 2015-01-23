namespace Pettys.NumberGuess {

	public interface IGuesser {
		int Guess(int minimum, int maximum);
		void Feedback(int yourGuess, bool tooLow, bool tooHigh);
	}

}
