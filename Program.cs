// See https://aka.ms/new-console-template for more information
using tableTop;

Creature test = new Creature(Dice.RollD12(3), 16);
Console.WriteLine(test.health);
