package example;

public class CharacterFactory {

    private CharacterFactory() {
    }
    public static Character create(String type, String name, int health) {
        switch (type.toLowerCase()) {
            case "player" -> {
                return new Player(name, health);
            }
            case "enemy" -> {
                return new Enemy(name, health);
            }
            default -> throw new IllegalArgumentException("Unknown type: " + type);
        }
    }
}

