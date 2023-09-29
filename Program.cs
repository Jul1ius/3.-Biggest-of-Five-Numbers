using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                i--;
            }
        }

        int biggest = numbers[0];

        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > biggest)
            {
                biggest = numbers[i];
            }
        }

        Console.WriteLine(biggest);
    }
}
