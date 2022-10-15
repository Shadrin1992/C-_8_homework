// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int m = 4;
int n = 3;
int[,] array = new int[n, m];
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

int tmp, pos;

for (int i = 0; i < n; ++i)
{ // i - номер текущей строки
    for (int j = 0; j < m; ++j) // j - номер текущего шага
    {
        pos = j;
        tmp = array[i,j];
        for (int h = j + 1; h < array.GetLength(1); ++h) // цикл выбора наименьшего элемента
        {
            if (array[i,h] > tmp)
            {
                pos = h;
                tmp = array[i,h];
            }
        }
        array[i,pos] = array[i,j];
        array[i,j] = tmp; // меняем местами наименьший с a[i]
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}


