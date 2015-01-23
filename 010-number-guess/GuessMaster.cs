using System;

namespace Pettys.NumberGuess {

	public class GuessMaster {

		private static Random _random = new Random();
		
		public static void Main() {
			double sum = 0;
			int runCount = 100000;
			for(int i=0; i<runCount; i++) {
				var guesser = new StupidGuesser();
				sum += RunGame(guesser);
			}
			Console.WriteLine(runCount + " runs; average guess count = " + (sum/(double)runCount));
		}

		public static int RunGame(IGuesser guesser) {

			var myNumber = _random.Next(1, 11);
			var guessCount = 0;
			while(guessCount < 200) {
				
				int guess = guesser.Guess(1, 10);
				guessCount += 1;
				bool tooLow = guess < myNumber;
				bool tooHigh = guess > myNumber;
				guesser.Feedback(guess, tooLow, tooHigh);
				if(myNumber == guess) {
					break;
				}
				
			}
			return guessCount;
			
		}

	}

}
