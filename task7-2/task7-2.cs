// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).
Console.WriteLine("Задача 2: написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная)");
Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine()!);
if (m != n)
{
    Console.WriteLine("Фокус не получится: матрица НЕ КВАДРАТНАЯ... ");
}
else
{
    void FillArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(0, 99);
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
        int temp;
        int count = 0;
        for (int i = count; i < matrix.GetLength(0); i++)
        {
            for (int j = count; j < matrix.GetLength(1); j++)
            {
                if (i != j)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
            count++;

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
}


