// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 200);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

int[] array = new int[123];
FillArray(array);
PrintArray(array);

int SegmentNumbers(int[] arr)
{
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        count++;
    }
    return count;
}

Console.WriteLine($"Количество чисел из диапазона [10, 99] равно {SegmentNumbers(array)}.");
