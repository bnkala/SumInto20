// See https://aka.ms/new-console-template for more information
using System;
namespace SumInto20NS
{
    public class SumInto20
    {
        public string GetInput()
        {
            Console.Write("Enter 3 digits that sum up 20: ");
            return Console.ReadLine();
        }

        public bool IsInputValid(string num)
        {
            int value = 0;
            if (num.Length != 3)
            {
                Console.WriteLine("Invalid Input! Input should only have 3 digits");
                return false;
            }

            if(!int.TryParse(num, out value))
            {
                Console.WriteLine("Invalid Input! Input should only have digits");
                return false;
            }
            return true;
        }

        public int Total20(string num)
        {
            int total=0;
            for (int x=0; x< num.Length; x++)
            {
                total += (num[x]-'0');
            }
            return total;
        }

        public string Check20OrNot(string num, int total)
        {
            string display;
            Console.WriteLine(total);
            if(total == 20)
            {
                display = num + " sum up 20";
            }  else
            {
                display = num + " don't sum up 20";
            }
            return display;
        }

        public static void Main()
        {
            SumInto20 sum = new SumInto20();
            String num;
            do
            {
                num = sum.GetInput();
            } while (!sum.IsInputValid(num));
            int total = sum.Total20(num);
            Console.WriteLine(sum.Check20OrNot(num, total));
        }


    }
}
