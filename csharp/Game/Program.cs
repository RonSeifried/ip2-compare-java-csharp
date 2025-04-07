using Game;

Player p1 = new("Alex", 75);
Enemy e1 = new("Goblin", 30);

GameManager gm = new();

gm.AddCharacter(p1);
gm.AddCharacter(e1);


gm.PrintAliveCharacters();


gm.PrintCharacterByName("Alex");

Character e2 = CharacterFactory.Create("enemy", "Orc", 50);
gm.AddCharacter(e2);
Character p2 = CharacterFactory.Create("player", "Mark", 100);
gm.AddCharacter(p2);

gm.PrintAliveCharacters();