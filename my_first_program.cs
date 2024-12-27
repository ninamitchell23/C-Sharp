using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number=2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'a';// enclose a character in single quotes
            string firstName = "Mitchell"; // enclose a string in double quotes
            //Using var
            var Number = 1;
            var Count = 10;
            var Totalprice = 20.95f;
            var Character = 'a';
            Console.WriteLine(character);
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(firstName);
            Console.WriteLine(Number);
            Console.WriteLine(Count);
            Console.WriteLine(Totalprice);
            Console.WriteLine(Character);
            
        }
    }
}
