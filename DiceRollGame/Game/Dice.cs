namespace DiceRollGame.Game
{
    public class Dice
    {
        private readonly Random randomNumber = new Random();
        private const int _sides = 6;

        public Dice(Random rolledNumber)
        {
            randomNumber = rolledNumber;
        }
        public int Roll()
        {
            return randomNumber.Next(1, _sides + 1);
        }
    }
}
