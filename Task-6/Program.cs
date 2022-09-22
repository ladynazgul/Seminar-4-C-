// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.WriteLine("Enter an array separated by a space: ");
int[] array = (Console.ReadLine() ?? "0").Split(' ').Select(int.Parse).ToArray();


int FindMax(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


int FindMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.WriteLine($"Difference is {FindMax(array) - FindMin(array)}");