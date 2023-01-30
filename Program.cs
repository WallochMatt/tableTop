// See https://aka.ms/new-console-template for more information
using tableTop;
// note to self, create a weapon class


Dice d4 = new Dice(4);
Dice d6 = new Dice(6);
Dice d8 = new Dice(8);
Dice d10 = new Dice(10);
Dice d12 = new Dice(12);




Creature tester = new Creature(10, 8);
Creature punchingBag = new Creature(10, 8);

Console.WriteLine("PB Health: " + punchingBag.health);
Console.ReadLine();

tester.attack(punchingBag, true);

Console.WriteLine("PB Health: " + punchingBag.health);
Console.ReadLine();