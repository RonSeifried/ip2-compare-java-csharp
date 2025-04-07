package example;

import java.util.Comparator;
import java.util.List;
import java.util.Optional;
import java.util.ArrayList;

// This class showcases the use of Java Streams for filtering and sorting characters.
// It also demonstrates the use of Optional for null safety and modern Java features like method references.
// Additionally, it highlights the use of Comparator for custom sorting logic.
public class GameManager {

    private final List<Character> characters;

    public GameManager() {
        this.characters = new ArrayList<>();
    }

    public void addCharacter(Character c) {
        characters.add(c);
    }

    public void printCharacterByName(String name) {

        System.out.println("Output of: printCharacterByName()");

        Optional<Character> character = characters.stream()
                .filter(c -> c.getName().equals(name))
                .findFirst();

        character.ifPresentOrElse(
                c -> System.out.println("Character found: " + c.getName()),
                () -> System.out.println("Character not found.")
        );
    }

    public void printAliveCharacters() {

        System.out.println("Output of: printAliveCharacters()");

        // Adding a stream example to filter and sort characters
        List<Character> aliveCharacters = characters.stream()
                .filter(Character::isAlive)
                .sorted(Comparator.comparingInt(Character::getHealth).reversed())
                .toList();

        aliveCharacters.forEach(c -> System.out.println(c.getName() + " has " + c.getHealth() + " HP."));
    }

}
