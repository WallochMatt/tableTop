// See https://aka.ms/new-console-template for more information
using tableTop;
// note to self, create a weapon class


Dice d4 = new Dice(4);
Dice d6 = new Dice(6);
Dice d8 = new Dice(8);
Dice d10 = new Dice(10);
Dice d12 = new Dice(12);

Weapon fists = new Weapon(2, d4);
Weapon club = new Weapon(1, d6);




Creature tester = new Creature(10, 8, club);
Creature punchingBag = new Creature(10, 8, fists);

Console.WriteLine("PB Health: " + punchingBag.health);
Console.ReadLine();

tester.Attack(punchingBag, tester.GetWeapon(), true);

Console.WriteLine("PB Health: " + punchingBag.health);
Console.ReadLine();