// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = new int[2,2]
                    {
                        {2, 4},
                        {3, 2}
                    };
int[,] matrix2 = new int[2,2]
                    {
                        {3, 4},
                        {3, 3},
                    };

if(matrix1.GetLength(1) != matrix2.GetLength(0))
{
   Console.WriteLine("Данные матрицы невозможно перемножить.");
}
else
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int m = 0; m < resultMatrix.GetLength(0); m++)
    {
        for(int n = 0; n < resultMatrix.GetLength(1); n++)
        {
            resultMatrix[m, n] = 0;
            for(int j = 0; j < matrix1.GetLength(0); j++)
            {
                resultMatrix[m, n] += matrix1[m, j] * matrix2[j, n];
            }
        }
    }
    PrintArray(resultMatrix);
}

// метод печати двумерного масива на консоль:
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}