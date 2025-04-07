namespace Game {
    public abstract class Character(string name, int health)
    {
        // In C#, properties are used instead of getter methods like getName() in Java.
        // The 'Name' and 'Health' properties are read-only and initialized via the constructor.
        // This is different from Java, where fields are typically private and accessed via methods.
        public string Name { get; } = name;
        public int Health { get; } = health;
        

        public abstract void Attack();

        public bool IsAlive() => Health > 0;

    }
}