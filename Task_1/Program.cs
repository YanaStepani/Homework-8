// Задайте двумерный массив. Напишите программу, которая упорядочить 
// по убыванию элементы каждой строки двумерного массива.

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

// Метод заполнение двумерного массива случайными числами:
int[,] FillArrayRandom(int height, int width)
{
    int[,] array = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк в массиве: ");
int height = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int width = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] myArray = FillArrayRandom(height, width);

Console.WriteLine("Заполненный случайными числами массив: ");
PrintArray(myArray);
Console.WriteLine();

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < myArray.GetLength(1) - 1; k++)
        {
            if (myArray[i, k] < myArray[i, k + 1])
            {
                int temp = 0;
                temp = myArray[i, k];
                myArray[i, k] = myArray[i, k + 1];
                myArray[i, k + 1] = temp;
            }
        }
    }
}

Console.WriteLine("Массив с отсортированными строками: ");
PrintArray(myArray);

