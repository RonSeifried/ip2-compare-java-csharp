package example;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;


class DemoTests {

    @Test
    void playerShouldBeAlive() {
        Player p = new Player("Test", 100);
        assertTrue(p.isAlive());
    }

    @Test
    void playerShouldHaveCorrectName() {
        Player p = new Player("Alex", 100);
        assertEquals("Alex", p.getName());
    }

    @Test
    void factoryShouldCreateEnemy() {
        Character c = CharacterFactory.create("enemy", "Goblin", 30);
        assertTrue(c instanceof Enemy);
        assertEquals("Goblin", c.getName());
    }
}
