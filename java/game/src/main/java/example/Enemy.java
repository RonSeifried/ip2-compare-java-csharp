package example;

public class Enemy extends Character {
    public Enemy(String name, int health) {
        super(name, health);
    }

    @Override
    public void attack() {
        System.out.println(name + " attacks with claws!");
    }
}

