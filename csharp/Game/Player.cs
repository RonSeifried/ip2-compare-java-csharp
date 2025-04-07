namespace Game{

    public class Player(string name, int health) : Character(name, health){

        // In C#, the 'override' keyword is used to indicate that a method overrides a base class method.
        // This is similar to the @Override annotation in Java.
        public override void Attack(){
            Console.WriteLine($"{Name} attacks with a sword!");
        }
        
    }
}