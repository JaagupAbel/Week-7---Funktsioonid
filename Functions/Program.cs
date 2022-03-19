using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta esimest arvu:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teist arvu:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe (sisesta '+','-','*,'/'.').");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch(userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo) ;
                    break;

                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SubtTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
            

        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }
        private static void MultiTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        private static void SubtTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }
    }
}
