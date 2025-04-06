package example;

public abstract class Character {
    protected String name;
    protected int health;

    protected Character(String name, int health) {
        this.name = name;
        this.health = health;
    }

    public abstract void attack();

    public boolean isAlive() {
        return this.health > 0;
    }

    public String getName() {
        return name;
    }

    public int getHealth() {
        return health;
    }
}
