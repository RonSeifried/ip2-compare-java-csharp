namespace Game
{
    public class CharacterFactory(){
        private CharacterFactory(){

        }

        public static CharacterFactory create(string type, string name, int health) =>
            type.ToLower() switch
            {
                "player" => new Player(name, health),
                "enemy" => new Enemy (name,health),
                _ => throw new ArgumentException("Unknown Type")
            }
    }
}