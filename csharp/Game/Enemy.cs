namespace Game {

public class Enemy : Character {
    public Enemy(string name, int health) : base(name, health) {
    }

    public override void Attack() {
        Console.WriteLine($"{Name} attacks with a claw!");
    }
}

}
