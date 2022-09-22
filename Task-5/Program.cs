// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Заполнить массив произвольной длины произвольными числами из заданного диапазона

int length = new Random().Next(4, 30);

int[] FillArray()
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

Console.WriteLine($"Your massiv contains {length} elements");

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}  ");
    Console.WriteLine();
}

int[] arr = FillArray();
PrintArray(arr);

void PrintPairProducts(int[] Array)
{
    int last = Array.Length - 1;
    for (int i = 0; i < Array.Length / 2; i++)
    {
        Console.WriteLine($"{Array[i]} x {Array[last]} = {Array[i] * Array[last]} ");
        last--;
    }
    if (Array.Length % 2 > 0) Console.WriteLine($"Число {Array[Array.Length / 2]} не имеет пары");
    Console.WriteLine();
}

Console.WriteLine();
PrintPairProducts(arr);
