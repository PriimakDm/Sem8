// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] Create2DArrey ()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collumns: ");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int [,] created2DArrey = new int [userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2DArrey[i,j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2DArrey;
}

void PrintArrey(int [,] arrey)
{
    for (int i = 0; i <  arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortRows (int[,] rows)
{
    for (int i = 0; i < rows.GetLength(0); i++)
    {
        for (int j = 0; j < rows.GetLength(1); j++)
        {
            for (int k = 0; k < rows.GetLength(1) - 1; k++)
            {
                if (rows[i, k] < rows[i, k + 1])
                {
                    int temp = rows[i, k + 1];
                    rows[i, k + 1] = rows[i, k];
                    rows[i, k] = temp;
                }
            }
        }
    }
    for (int i = 0; i <  rows.GetLength(0); i++)
    {
        for (int j = 0; j < rows.GetLength(1); j++)
        {
            Console.Write(rows[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] newArrey = Create2DArrey();
PrintArrey (newArrey);
SortRows (newArrey);


