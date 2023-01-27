// See https://aka.ms/new-console-template for more information
using tableTop;
// note to self, create a weapon class

Creature test = new Creature(Dice.RollD12(3), 16);

Creature goblin = new Creature(Dice.RollD12(2), 8);
Console.WriteLine("Goblin health: " + goblin.health);
Console.ReadLine();

test.attack(goblin, Dice.RollD10(), true);
Console.WriteLine("Goblin health: " + goblin.health);
Console.ReadLine() ;    