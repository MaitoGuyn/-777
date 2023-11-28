int input = Convert.ToInt32(Console.ReadLine());
int[] amountofdays = new int[input];

for (int i = 0; i < amountofdays.Length; i++)
{
    amountofdays[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 1; i < amountofdays.Length; i++)
{
    if (amountofdays[i] > amountofdays[i - 1] && amountofdays[i] > amountofdays[i + 1])
    {
        Console.WriteLine("Day " + (i) + " temperature was higher than the neighboring days");
    }
    else if (amountofdays[i] < amountofdays[i - 1] && amountofdays[i] < amountofdays[i + 1])
    {
        Console.WriteLine("Day " + (i) + " temperature was lower than the neighboring days");
    }
}

