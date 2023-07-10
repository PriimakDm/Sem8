// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



Console.WriteLine("Enter count of rows of first arrey: ");
int user1Rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of collumns of first arrey (rows of second arrey): ");
int user12Colls = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of collumns of second arrey: ");
int user2Colls = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min possible value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max possible value: ");
int userMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] CreateFirstArrey()
{
    int[,] created1Arrey = new int[user1Rows, user12Colls];

    for (int i = 0; i < user1Rows; i++)
    {
        for (int j = 0; j < user12Colls; j++)
        {
            created1Arrey[i, j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created1Arrey;
}

int[,] CreateSecondArrey()
{
    int[,] created2Arrey = new int[user12Colls, user2Colls];

    for (int i = 0; i < user12Colls; i++)
    {
        for (int j = 0; j < user12Colls; j++)
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

int[,] TotalArrey(int[,] firstArrey, int[,] secondArrey)
{
    int[,] totalArrey = new int[firstArrey.GetLength(0), secondArrey.GetLength(1)];
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
  return totalArrey;
}

int [,] newArrey = CreateFirstArrey();
PrintArrey (newArrey);
int [,] new1Arrey = CreateSecondArrey();
PrintArrey (new1Arrey);
int [,] new2Arrey = TotalArrey(newArrey, new1Arrey);
Console.WriteLine("Product of two arrays: ");
Console.WriteLine("");
PrintArrey (new2Arrey);