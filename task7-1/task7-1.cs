// задачи домашки
// Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.
Console.WriteLine("Задача 1: написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.");
Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите левый предел диапазона элементов массива ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите правый предел диапазона элементов массива ");
int max = int.Parse(Console.ReadLine()!);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] matrix)
{
    int k;
    int largest;
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        k = 0;
        while (k != n)
        {
            for (int j = k; j < matrix.GetLength(1); j++)
            {
                largest = matrix[i, k];
                if (matrix[i, j] > largest)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = largest;
                    matrix[i, k] = temp;
                }
            }
            k++;
        }

    }
}

int[,] matr = new int[m, n];

FillArray(matr);
Console.WriteLine("Вот так выглядит исходный массив: ");
PrintArray(matr);
Console.WriteLine();

ChangeArray(matr);
Console.WriteLine("Вот так выглядит изменённый массив: ");
PrintArray(matr);
Console.WriteLine();

