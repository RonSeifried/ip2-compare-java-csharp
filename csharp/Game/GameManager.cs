namespace Game {

    public class GameManager{
        private readonly List<Character> Characters = new List<Character>();

        public void AddCharacter(Character c){
            Characters.Add(c);
        }

        public void PrintAliveCharacters(){
            foreach (int health in Characters.Where(c => c.IsAlive()).Select(c => c.Health))
            {
                Console.WriteLine($"{health} is alive with {health} HP.");
            }
        }

        public Character GetCharacterByName(string name){
            return Characters.FirstOrDefault(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase)) 
                   ?? throw new InvalidOperationException($"Character with name '{name}' not found.");
        }
    }
}