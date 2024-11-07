using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game
{
    public class Guessing
    {
        private readonly Dice _dice;
        private const int _numberOfTries = 3;

        public Guessing(Dice dice)
        {
            _dice = dice;
        }
        public GameResult Play()
        {
            var rolledNumber = _dice.Roll();
            Console.WriteLine($"Dice rolled. Guess the number in {_numberOfTries} tries.");

            int tries = _numberOfTries;

            while (tries > 0)
            {
                var guess = Validator.ReadNumber("Enter a number:");
                if (guess == rolledNumber)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong number");
                tries--;
            }
            return GameResult.Loss;
        }
        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory ? message = "You win!" : message = "You lose!";
            Console.WriteLine(message);
        }
    }
}
