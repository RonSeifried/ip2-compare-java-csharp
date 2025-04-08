namespace Game
{

    public class GameManager
    {
        private readonly List<Character> Characters = [];

        public void AddCharacter(Character c)
        {
            Characters.Add(c);
        }

        // In C#, LINQ is used for filtering and sorting, which is similar to Java Streams but has a different syntax.
        public void PrintAliveCharacters()
        {
            Console.WriteLine("Output of: PrintAliveCharacters()");
            var aliveCharacters = Characters
                .Where(c => c.IsAlive())
                .OrderByDescending(c => c.Health)
                .ToList();

            aliveCharacters.ForEach(c => Console.WriteLine($"{c.Name} has {c.Health} HP."));
        }

        // Adding a nullable example to handle null safety (C# equivalent to Java Optional)
        // The 'FirstOrDefault' method is used instead of Java's Optional to handle null values.
        public void PrintCharacterByName(string name)
        {
            Console.WriteLine("Output of: PrintCharacterByName()");
            var character = Characters.FirstOrDefault(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(character != null
            ? $"Character found: {character.Name}"
            : "Character not found.");
        }

    }
}