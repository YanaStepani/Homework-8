/*  Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07  */

Console.WriteLine("Введите количество строк в массиве: ");
int size = int.Parse(Console.ReadLine());

int[,] array = FillArrayInSpiral(size);
PrintArray(array);


//  Метод заполнения квадратного массива по спирали:
int[,] FillArrayInSpiral(int size)
{
    int[,] spiralArray = new int[size, size];

    int number = 1;
    int i = 0;
    int j = 0;

    while (number <= spiralArray.Length)
    {
        spiralArray[i, j] = number;
        if (i <= j + 1 && i + j < size -1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
        ++number;
    }
    return spiralArray;
}

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
