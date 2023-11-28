using System;

Console.WriteLine("Wrtie amount of numbers");
int input = int.Parse(Console.ReadLine());
if (input <= 100 && 1 <= input)
{

    int[] arrr = new int[input];
    Console.WriteLine("Write numbers");

    for (int i = 0; i < arrr.Length; i++)
    {
        arrr[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < arrr.Length; i++)
    {
        for (int j = 0; j < arrr.Length; j++)
        {
            if (arrr[i] + arrr[j] == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}
