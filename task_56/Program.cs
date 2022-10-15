// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = 4;
int n = 3;
int[,] array = new int[m, n];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(1, 11);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[] arraySumm = new int[m];

for (int i = 0; i < array.GetLength(0); i++)
{
    int summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summ = summ + array[i, j];
                
    }
    arraySumm[i] = summ;
}

int min = arraySumm[0];
int index = 0;

for (int i = 1; i < arraySumm.Length; i++)

    if (min > arraySumm[i])
    {
        min = arraySumm[i];
        index = i;
    }
Console.WriteLine($"Строка с наименьшей суммой элементов: {index + 1} строка");