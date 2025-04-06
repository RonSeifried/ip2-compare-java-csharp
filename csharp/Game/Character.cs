namespace Game {
    public abstract class Character(string name, int health)
    {
        public string Name { get; } = name;
        public int Health { get; } = health;
        

        public abstract void Attack();

        public bool IsAlive() => Health > 0;

    }
}