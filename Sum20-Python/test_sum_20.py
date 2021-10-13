import unittest
import io
import sys
import sum_20

class TestSum(unittest.TestCase):
    def test_input(self):
        self.assertTrue(sum_20.is_input_valid("972"))
    
    def test_input_false(self):
        text = io.StringIO()
        sys.stdout = text
        self.assertFalse(sum_20.is_input_valid("2w3"))
        sys.stdout = sys.__stdout__


    def test_input_length(self):
        text = io.StringIO()
        sys.stdout = text
        self.assertFalse(sum_20.is_input_valid("2637"))
        sys.stdout = sys.__stdout__

    def test_sum(self):
        self.assertEqual(20, sum_20.total_20("974"))
    
    def test_sum_not_equal_20(self):
        self.assertNotEqual(20, sum_20.total_20("365"))

    def test_display_20(self):
        text = io.StringIO()
        sys.stdout = text
        tot = sum_20.total_20("875")
        self.assertEqual("875 sum up 20", sum_20.check_20_or_not("875", tot))
        sys.stdout = sys.__stdout__

    def test_display_not_20(self):
        text = io.StringIO()
        sys.stdout = text
        tot = sum_20.total_20("973")
        self.assertEqual("973 don't sum up 20", sum_20.check_20_or_not("973",tot))
        sys.stdout = sys.__stdout__

if __name__ == "__main__":
    unittest.main()