// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку c наименьшей суммой элементов.



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

int SumRow(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum = array[i,j] + sum;
    }
    return sum;
}

void MinSum (int [,] arrey)
{
    int minSum = 1;
    int sum = SumRow(arrey, 0);
    for (int i = 1; i < arrey.GetLength(0); i++)
    {
        if (sum > SumRow(arrey, i))
        {
            sum = SumRow(arrey, i);
            minSum = i+1;
        }
    }
Console.WriteLine($"The row with the smallest sum of elements: {minSum}");
}

int [,] newArrey = Create2DArrey();
PrintArrey (newArrey);
MinSum (newArrey);