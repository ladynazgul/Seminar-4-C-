// Написать программу замены элементов массива на противоположные

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

// int[] ReplaceArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * (-1);
//     }
//     return array;
// }

int[] OppositeNumbers(int[] array)
{
	int[] result = new int[array.Length];
	for(int i = 0; i < array.Length; i++)
	{
		result[i] = -array[i];
	}
	return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
// PrintArray(ReplaceArray(array));
PrintArray(OppositeNumbers(array));