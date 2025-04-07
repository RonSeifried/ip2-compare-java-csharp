namespace Game
{
    public static class CharacterFactory
    {
        // In C#, the factory method uses a switch expression, which is more concise than the Java switch-case syntax.
        // Additionally, C# uses 'throw new ArgumentException' for error handling, while Java uses 'throw new IllegalArgumentException'.
        public static Character Create(string type, string name, int health) =>
            type.ToLower() switch
            {
                "player" => new Player(name, health),
                "enemy" => new Enemy(name, health),
                _ => throw new ArgumentException($"Unknown type: {type}")
            };
    }
}