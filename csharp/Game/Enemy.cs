namespace Game {

public class Enemy(string name, int health) : Character(name, health) {

        // Similar to the Player class, the 'override' keyword is used in C# to override the base class method.
        // This is equivalent to the @Override annotation in Java.
        public override void Attack() {
        Console.WriteLine($"{Name} attacks with a claw!");
    }
}

}
