package example;

// This class showcases method overriding in Java.
// It extends the Character class and provides a specific implementation for the attack method.
public class Enemy extends Character {
    public Enemy(String name, int health) {
        super(name, health);
    }

    @Override
    public void attack() {
        System.out.println(name + " attacks with claws!");
    }
}

