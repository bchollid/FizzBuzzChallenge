using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        Console.WriteLine(FizzBuzzMethod(3));
        Console.WriteLine(FizzBuzzMethod(5));
        Console.WriteLine(FizzBuzzMethod(15));
    }

    static string FizzBuzzMethod(float number)
    {
        if (number % 3 == 0 && number % 5 != 0)
        {
            return "Fizz";
        }
        else if (number % 5 == 0 && number % 3 != 0)
        {
            return "Buzz";
        }
        else if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        else
        {
            return "Does not exist.";
        }
    }
}