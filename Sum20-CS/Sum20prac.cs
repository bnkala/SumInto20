using System;

namespace Sum20
{
    public class Sum20
    {
        public string GetInput()
        {
            Console.Write("Enter 3 digits that sum up 20: ");
            return Console.ReadLine();
        }


        public bool IsInputValid(string num)
        {
            int value =0;
            if (num.length != 3)
            {
                return false;
            }
            return true;
        }

        public static void Main()
        {
            Sum20 sum = new Sum20();
            String num;
            /*do 
            {
                num = sum.GetInput();
            }*/ 
        }
    }
}