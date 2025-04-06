package example;

import java.util.ArrayList;
import java.util.List;

public class GameManager {
    private final List<Character> characters = new ArrayList<>();

    public void addCharacter(Character c) {
        characters.add(c);
    }

    public void printAliveCharacters() {
        for (Character c : characters) {
            if (c.isAlive()) {
                System.out.println(c.getName() + " is alive with " + c.getHealth() + " HP.");
            }
        }
    }

    public Character getCharacterByName(String name) {
        for (Character c : characters) {
            if (c.getName().equals(name)) {
                return c;
            }
        }
        return null;
    }
}

