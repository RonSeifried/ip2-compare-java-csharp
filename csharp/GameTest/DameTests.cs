// Yoou first need to create a reference via dotnet add reference ../Game/Game.csproj
using Game;

namespace GameTest
{
    public class DemoTests
    {
        [Test]
        public void PlayerShouldBeAlive()
        {
            // In C#, NUnit is used for testing, which is similar to JUnit in Java.
            // The Assert class provides methods like IsTrue, which is equivalent to assertTrue in JUnit.
            var player = new Player("Test", 100);
            Assert.That(player.IsAlive(), Is.True);
        }

        [Test]
        public void PlayerShouldHaveCorrectName()
        {
            var player = new Player("Alex", 100);
            Assert.That(player.Name, Is.EqualTo("Alex"));
        }

        [Test]
        public void FactoryShouldCreateEnemy()
        {
            var character = CharacterFactory.Create("enemy", "Goblin", 30);
            Assert.That(character, Is.TypeOf<Enemy>()); // TypeOf is used to check the type, similar to instanceof in Java.
            Assert.That(character.Name, Is.EqualTo("Goblin"));
        }
    }
}