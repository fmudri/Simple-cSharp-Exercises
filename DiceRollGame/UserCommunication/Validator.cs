﻿namespace DiceRollGame.UserCommunication
{
    public static class Validator
    {
        public static int ReadNumber(string message)
        {
            int result;
            do
            {
                Console.WriteLine(message);
            }
            while (!int.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }
}
