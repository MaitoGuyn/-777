using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

bool isMatrixSymmetric()
{
    bool triger;
    int input = Convert.ToInt32(Console.ReadLine());
    if (input <= 100)
    {

        int[,] array = new int[input, input]; ;


        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] != array[j, i])
                {
                    return false;

                }




            }

        }



    }
    else
    {
        Console.WriteLine("Too much massive");
    }


    return true;



}
if (isMatrixSymmetric()) { Console.WriteLine("Yes"); }
else { Console.WriteLine("No"); }
