package example;

public class Main {

    public static void main(String[] args) {
        Player p1 = new Player("Alex", 75);
        Enemy e1 = new Enemy("Goblin", 30);

        GameManager gm = new GameManager();
        gm.addCharacter(p1);
        gm.addCharacter(e1);

        gm.printAliveCharacters();
        
        gm.printCharacterByName("Alex");

        Character e2 = CharacterFactory.create("enemy", "Orc", 50);
        gm.addCharacter(e2);
        Character p2 = CharacterFactory.create("player", "Mark", 100);
        gm.addCharacter(p2);
        gm.printAliveCharacters();
    }
}
