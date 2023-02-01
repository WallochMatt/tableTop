// See https://aka.ms/new-console-template for more information
using tableTop;
// note to self: Could add stats, Could add levels


Dice d4 = new Dice(4);
Dice d6 = new Dice(6);
Dice d8 = new Dice(8);
Dice d10 = new Dice(10);
Dice d12 = new Dice(12);


//                     name, rolls, Dice
Weapon fists = new Weapon("Unarmed", 2, d4);
Weapon club = new Weapon("Wooden Club", 1, d6);



//                               name, weaight, ac
Armor chainMail = new Armor("Chain Mail", 55, 16);








//                             hp,weapon,ac
Creature tester = new Creature(10, club, 8);
Creature punchingBag = new Creature(10, fists, 2);

Console.WriteLine("AC: " + punchingBag.ArmorClass);

punchingBag.ArmorClass = chainMail.armorClass;

Console.WriteLine("NEW AC: " + punchingBag.ArmorClass);



Console.WriteLine("PB Health: " + punchingBag.health);
Console.ReadLine();

//                 target, weapon for attack, advantageStatus
tester.Attack(punchingBag, tester.Weapon, true);
Console.WriteLine("Tester attacks with " + tester.Weapon.name);

Console.WriteLine("PB Health: " + punchingBag.health);
Console.ReadLine();