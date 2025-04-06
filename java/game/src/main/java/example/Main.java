package example;

public class Main {
    public static void main(String[] args) {
        Player p1 = new Player("Alex", 100);
        Enemy e1 = new Enemy("Goblin", 30);

        GameManager gm = new GameManager();
        gm.addCharacter(p1);
        gm.addCharacter(e1);

        gm.printAliveCharacters();

        Player p2 = (Player) gm.getCharacterByName("Alex");
        System.out.println("Found player: " + p2.getName());

        if (p2.getName() != null) {
            System.out.println(p2.getName().toUpperCase());
        }

        // Factory
        Character newChar = CharacterFactory.create("enemy", "Orc", 50);
        gm.addCharacter(newChar);
        gm.printAliveCharacters();
    }
}
