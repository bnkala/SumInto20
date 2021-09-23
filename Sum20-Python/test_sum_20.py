import unittest
import sum_20

class TestSum(unittest.TestCase):
    def test_input(self):
        self.assertTrue(sum_20.is_input_valid("972"))
    
    def test_input_false(self):
        self.assertFalse(sum_20.is_input_valid("2w3"))
    
    """def test_input_length(self):
        self.assertEqual(3, len(sum_20.get_input()))"""
    
    def test_sum(self):
        self.assertEqual(20, sum_20.total_20("974"))
    
    def test_sum_not_equal_20(self):
        self.assertNotEqual(20, sum_20.total_20("365"))

if __name__ == "__main__":
    unittest.main()