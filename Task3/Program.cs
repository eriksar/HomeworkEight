/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] InitMatrix()
{
    int[,] matrix = new int[2,2];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] matrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[2,2];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {           
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
            resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    return resultMatrix;
}



int[,] matrix = InitMatrix();
int[,] secondMatrix = InitMatrix();

PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();

int[,] resultMatrix = MultiplyMatrix(matrix, secondMatrix);
PrintMatrix(resultMatrix);