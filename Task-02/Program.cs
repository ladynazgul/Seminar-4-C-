// Задать массив из 8 элементов, заполненный нулями и единицами, вывести их на экран

int[] EnterArray(int length)
{
	int[] array = new int[length];
	for (int i = 0; i < length; i++)
		{
			array[i] = new Random().Next(0,2);
		}
		return array;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	Console.Write($"{array[i]}  ");
}

int[] array = EnterArray(8);
PrintArray(array);

