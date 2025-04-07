package example;

// This class showcases the Factory design pattern in Java.
// It demonstrates the use of a static method to create objects based on a type parameter.
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

