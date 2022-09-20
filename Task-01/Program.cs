// Задать массив из 8 элементов и вывести их на экран

// int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(2, 50);
//     Console.WriteLine("Элемент массива с индексом " + i + " имеет значение " + array[i]);
// }

// С методами:

int A = 8;

int[] FillArray(int b)
{
    int[] arr = new int[b];
    for (int i = 0; i < b; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
}

PrintArray(FillArray(A));
Console.WriteLine();

bool ContainsZero(int[] array)
{
	bool answer = false;            // Олег сказал, что это академическое решение, но содержит лишние переменные и операторы, поэтому не очень красивое:)))
    for (int i = 0; i < array.Length; i++)
		if (array[i] == 0)
			answer = true;
	return answer;	
}

int[]arr = FillArray(8);

if(ContainsZero(arr) == true)
	Console.WriteLine("Array contains zeroes");
else
	Console.WriteLine("Array doesn't contain zeroes");

// int[] array = new int[8];
// for (int i = 0; i < 8; i++)
// {
// 	Console.Write($"Введите {i+1} элемент массива: ");
// 	array[i] = int.Parse(Console.ReadLine() ?? "0");
// }
// Console.Write("Your array: ");
// for (int i = 0; i < array.Length; i++)
// 	Console.Write($"{array[i]}  ");

