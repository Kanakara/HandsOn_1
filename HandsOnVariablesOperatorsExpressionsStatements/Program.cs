using System;

namespace HandsOn
{

//Main method demonstrates the use of variables, operators, expressions, and statements
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int sum = x + y;
            Console.WriteLine(sum);

            bool results = (sum == 7) ? true : false;

            Console.WriteLine(results);


            string text1 = "Hello";
            string text2 = "Nurse!";

            string message = "Message: " + text1 + text2;
            Console.WriteLine(message);

        }
    }
}
