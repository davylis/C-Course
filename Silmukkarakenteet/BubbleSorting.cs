using System;

class BubbleSorting
{
    static void Main(string[] args)
    {
        int[] numbers = Array.ConvertAll(args, int.Parse);

        // Bubble sort
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

    
        foreach (int num in numbers)
        {
            Console.Write(num + " "); 
        }

    }
}
