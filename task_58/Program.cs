// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = 2;
int n = 2;
Random rand = new Random();
int[,] matrix1 = new int[n, m];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = rand.Next(1, 11);
        Console.Write($"{matrix1[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] matrix2 = new int[n, m];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = rand.Next(1, 11);
        Console.Write($"{matrix2[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

if (matrix1.GetLength(1)!= matrix2.GetLength(0))
{
    Console.WriteLine("Матрицы перемножать нельзя");
}
int[,] matrix3 = new int[n, m];
for (int i=0; i<matrix1.GetLength(0); i++)
{
    for(int j=0; j<matrix2.GetLength(1); j++)
    {
        for (int k=0; k<matrix2.GetLength(1); k++)
        {
            matrix3[i,j] += matrix1[i,k]*matrix2[k,j];            
        }
        Console.Write($"{matrix3[i, j]} ");
    }
    Console.WriteLine();
}