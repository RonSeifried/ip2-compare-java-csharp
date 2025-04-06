using Game;

Player p1 = new Player("Alex", 100);
Enemy e1 = new Enemy("Goblin", 30);

GameManager gm = new GameManager();

gm.AddCharacter(p1);
gm.AddCharacter(e1);

gm.PrintAliveCharacters();


Player p2 = (Player) gm.GetCharacterByName("Alex");
Console.WriteLine($"Found player ${p2.Name}");