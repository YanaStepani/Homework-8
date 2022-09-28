/*  Задайте прямоугольный двумерный массив. Напишите программу, 
    которая будет находить строку с наименьшей суммой элементов.
    Программа считает сумму элементов в каждой строке и выдаёт 
    номер строки с наименьшей суммой элементов: 1 строка */

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

// Метод печати двумерного масива на консоль:
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

// Суммирование строк и основного массива и запись результатов во второй массив
void FillResultArray(int[,] array, int[] resultArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumInRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumInRow += array[i,j];
        }
        resultArray[i] = sumInRow;
        Console.WriteLine(resultArray[i]);
    }
    Console.WriteLine();
}

// Поиск индекса минимального числа в массиве:
int MinAdditionOfRow(int[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int min = array[0];
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}


// Запрос параметров размера массива у пользователя:
Console.WriteLine("Введите количество строк в массиве: ");
int height = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int width = int.Parse(Console.ReadLine());
Console.WriteLine();

// Создание основного массива исходя из заданных пользователем параметров 
// и заполнение его случайными числами:
int[,] myArray = FillArrayRandom(height, width);
PrintArray(myArray);
// Создание массива для хранения сумм строк:
int[] tmpArray = new int[height];

// Вызов методов заполнения массива сумм строк:
FillResultArray(myArray, tmpArray);

// Вызов метода поиска индекса минимально элемента и вывод его на консоль:
int indexOfAdditionalMinRow = MinAdditionOfRow(tmpArray);
Console.WriteLine($"Минимальная сумма чисел в строке {indexOfAdditionalMinRow + 1}");
