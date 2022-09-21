// Определить, присутствует ли в заданном массиве, некоторое число

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
}

bool FindNumber(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == N) return true;
    }
    return false;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

int[] array = new int[15];
FillArray(array);
PrintArray(array);

int N = 5;
if(FindNumber(array, N) == true)
	Console.WriteLine($"Array contains number {N}");
else
	Console.WriteLine($"Array doesn't contain number {N}");

