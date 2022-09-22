// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
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
int[] array = new int[20];
FillArray(array);
PrintArray(array);

int UnevensSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в данном массиве равна {UnevensSum(array)}.");
