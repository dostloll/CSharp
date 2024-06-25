using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is a palindrome:");
        int number;
        bool isValid = int.TryParse(Console.ReadLine(), out number);

        if (!isValid)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        bool isPalindrome = IsPalindrome(number);

        if (isPalindrome)
        {
            Console.WriteLine($"{number} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} is not a palindrome.");
        }
    }

    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = (reversedNumber * 10) + remainder;
            number /= 10;
        }

        return originalNumber == reversedNumber;
    }
}
