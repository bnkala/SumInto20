import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Test;

class Sum20Test {
    @Test
    void testInput(){
        assertTrue(Sum20.isInputValid("972"));
    }

    @Test
    void testInputFalse(){
        assertFalse(Sum20.isInputValid("2w3"));
    }

    @Test
    void testInputLength(){
        assertFalse(Sum20.isInputValid("2637"));
    }

    @Test
    void testSum(){
        assertEquals(20, Sum20.total20("974"));
    }

    @Test
    void testSumNotEqual20(){
        assertNotEquals(20, Sum20.total20("365"));
    }

    @Test
    void testDisplay20(){
        int tot = Sum20.total20("875");
        assertEquals("The numbers sum up 20", Sum20.check20OrNot(tot));
    }

    @Test
    void testDisplayNot20(){
        int tot = Sum20.total20("973");
        assertEquals("The numbers don't sum up 20", Sum20.check20OrNot(tot));
    }
}