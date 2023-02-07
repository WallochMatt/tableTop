// See https://aka.ms/new-console-template for more information
using tableTop;
// note to self: Could add levels
// a FEATS CLASS


Dice d4 = new Dice(4);
Dice d6 = new Dice(6);
Dice d8 = new Dice(8);
Dice d10 = new Dice(10);
Dice d12 = new Dice(12);


//                          name, rolls, Dice
//Weapon fists = new Weapon("Unarmed", d4, 0);
Weapon club = new Weapon("Wooden Club", 1, 8);



//                               name, weight, ac
Armor chainMail = new Armor("Chain Mail", 55, 16);
Armor studLeath = new Armor("Studded Leather", 13, 12); // Figure how to add dex modifier



Race dwarf = new Race("Dwarf", 25, true, "Artisan's Tools", new List<string> {"Common", "Dwarvish"});

//                               name  hp           languages                str dex con int wis cha ac



Goblin testGob = new Goblin("test");
Goblin pb = new Goblin("pb");
testGob.ScimtiarAttack(pb);

Console.WriteLine(pb.Health);
Console.ReadLine();