
// В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.WriteLine("Задача 3: в прямоугольной матрице найти строку с наименьшей суммой элементов. ");
Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine()!);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 50);
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

int[,] matr = new int[m, n];

FillArray(matr);
Console.WriteLine("Вот так выглядит исходный массив: ");
PrintArray(matr);
Console.WriteLine();

int sum;
int[] summa = new int[m];

for (int i = 0; i < matr.GetLength(0); i++)
{
    sum = 0;

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = sum + matr[i, j];
    }
    summa[i] = sum;
}
int min;
min = summa[0];
int index = 0;
for (int i = 0; i < m; i++)
{
    if (summa[i] < min)
    {
        min = summa[i];
        index = i;
    }
}
Console.Write("Минимальный результат: " + min + " в строке - " + (index + 1));


