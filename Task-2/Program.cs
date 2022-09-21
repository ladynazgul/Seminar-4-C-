// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int length = 20;

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
}

PrintArray(FillArray(length));
Console.WriteLine();

void FindNumbers(int[] array)
{
    int Evens = 0;
    int Unevens = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        Evens++;
        else Unevens++;
    }
    Console.WriteLine($"В массиве {Evens} четных чисел и {Unevens} нечетных.");
}

FindNumbers(FillArray(length));