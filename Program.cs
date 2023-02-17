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



Vocation fighter = new Vocation(10, "Strength", "Constitution");


Race mountainDwarf = new Race("Mountain Dwarf", "medium", 25, true, "Artisan's Tools", new List<string> {"Common", "Dwarvish"}, 2, 0, 2, 0, 0, 0);

Background acolyte = new Background("Acolyte", new List<string> { "Draconic", "Deep Speech" });


//                                           name,  str dex con int wis cha,background     race,    weapon  armor     vocation
Adventurer tetstAdventurer = new Adventurer("Krok", 14, 10, 14, 10, 12, 13, acolyte,  mountainDwarf, club, studLeath, fighter);


Creature.PrintCharacterSheet(tetstAdventurer);





//Goblin testGob = new Goblin("test");
//Goblin pb = new Goblin("pb");

//YoungRedDragon dw = new YoungRedDragon("Donkey's Wife");

//testGob.ScimtiarAttack(dw);
//Console.WriteLine("Dragon's hp: " + dw.Health);
//Console.ReadLine();


//dw.Breath(testGob);
//Console.WriteLine("Goblin's hp: " + testGob.Health);
//Console.ReadLine();