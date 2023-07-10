// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



Console.WriteLine("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of collumns: ");
int userColls = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min possible value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max possible value: ");
int userMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] CreateFirstArrey()
{
    int[,] created1Arrey = new int[userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created1Arrey[i, j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created1Arrey;
}

int[,] CreateSecondArrey()
{
    int[,] created2Arrey = new int[userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2Arrey[i, j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2Arrey;
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

// void TotalArrey(int[,] firstArrey, int[,] secondArrey, int[,] totalArrey)
// {
//   for (int i = 0; i < totalArrey.GetLength(0); i++)
//   {
//     for (int j = 0; j < totalArrey.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstArrey.GetLength(1); k++)
//       {
//         sum += firstArrey[i,k] * secondArrey[k,j];
//       }
//       totalArrey[i,j] = sum;
//     }
//   }
//   Console.WriteLine("Product of two arrays: ");
//   Console.WriteLine();
// }

int[,] TotalArrey(int[,] firstArrey, int[,] secondArrey, int[,] totalArrey)
{
    int[,] totArrey = new int[firstArrey.GetLength(0), secondArrey.GetLength(1)];
    if (firstArrey.GetLength(1) == secondArrey.GetLength(0))
    {
        for (int i = 0; i < totalArrey.GetLength(0); i++)
        {
            for (int j = 0; j < totalArrey.GetLength(1); j++)
                {
                    totalArrey[i,j] = 0;
                    for (int k = 0; k < firstArrey.GetLength(1); k++)
                        {
                           totalArrey[i,j] += firstArrey[i,k] * secondArrey[k,j];
                        }
                }    
        }
    }
  return totArrey;
}

int [,] newArrey = CreateFirstArrey();
PrintArrey (newArrey);
int [,] new1Arrey = CreateSecondArrey();
PrintArrey (new1Arrey);
PrintArrey (TotalArrey);