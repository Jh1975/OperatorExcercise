using System;

namespace MedthodExercise
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is a name for your dog?");
            string userDogName = Console.ReadLine();

            Console.WriteLine("What color is your dog?");
            string color = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{userName} wants to eat cupcakes");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"My dog {userDogName} loves treats.");
            Console.WriteLine($"Hi, my name is {userName}I have a {color} that smells like Oranges");

            Console.WriteLine("give me a number to have add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number to have add");
            int num2 = int.Parse(Console.ReadLine());
            Add(num1, num1);

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");
        }
        public static int Sum(int num1, int num2)
        {
            //int sum = num1 + num2;

            //return sum;

            return num1 + num2;
            
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }


    }
  
}

