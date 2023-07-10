// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] Create3DArrey ()
{
    int [,,] created3DArrey = new int [2, 2, 2];

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int c = 0; c < 2; c++)
            {
                created3DArrey[i,j,c] = new Random().Next(10, 100);
            }
        }
    }
    return created3DArrey;
}

void PrintArrey(int [,,] arrey)
{
    for (int i = 0; i <  arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            for (int c = 0; c < arrey.GetLength(2); c++)
            {
                Console.Write(arrey[i,j,c] + " ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,,] arrey3d = Create3DArrey ();
PrintArrey (arrey3d);