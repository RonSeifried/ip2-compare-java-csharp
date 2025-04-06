package example;

public class Player extends Character {
    public Player(String name, int health) {
        super(name, health);
    }

    @Override
    public void attack() {
        System.out.println(name + " attacks with sword!");
    }

}

