// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] Create2DArrey()
{
    Console.WriteLine("Enter count of userRows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of userColls: ");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] created2DArrey = new int[userRows, userColls];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= created2DArrey.GetLength(0) * created2DArrey.GetLength(1))
    {
        created2DArrey[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < created2DArrey.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= created2DArrey.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > created2DArrey.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return created2DArrey;
}

void PrintArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArrey = Create2DArrey();
PrintArrey(newArrey);

