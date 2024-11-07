using DiceRollGame.Game;

var random = new Random();
var dice = new Dice(random);
var guessing = new Guessing(dice);

GameResult gameResult = guessing.Play();
Guessing.PrintResult(gameResult);

Console.ReadKey();

