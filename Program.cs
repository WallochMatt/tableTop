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
Weapon club = new Weapon("Wooden Club", 1, 8);

//                               name, weight, ac
Armor chainMail = new Armor("Chain Mail", 55, 16);
Armor studLeath = new Armor("Studded Leather", 13, 12); // Figure how to add dex modifier


MountainDwarf testDwarf = new MountainDwarf();


Goblin testGob = new Goblin("test");
Goblin pb = new Goblin("pb");

YoungRedDragon dw = new YoungRedDragon("Donkey's Wife");

dw.Breath(testGob);
Console.WriteLine("Goblin's hp: " + testGob.Health);
Console.ReadLine();