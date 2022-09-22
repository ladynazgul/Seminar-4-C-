// Вариант сокурсника Вадима

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i],4}");
    Console.WriteLine();
}

int[] CreateArray()
{
    int length = new Random().Next(4, 21);
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-10, 11);
    return array;
}

int[] Array = CreateArray();
Console.WriteLine($"Ваш массив:");
PrintArray(Array);

// определяем длину массива произведений
int MultLength = Array.Length / 2;
if ((Array.Length % 2) != 0)
    MultLength = MultLength + 1;

// заполняем массив произведений
int[] MultArray = new int[MultLength];
for (int i = 0; i < MultLength; i++)
    MultArray[i] = Array[i] * Array[Array.Length - i - 1];

Console.WriteLine("Произведения пар чисел:");
PrintArray(MultArray);

// Это еще один вариант, списала у сокурсников:)))

// Console.Clear();
// System.Console.WriteLine();

// int size = new Random().Next(10, 26);
// int min = 1;
// int max = 100;
// System.Console.WriteLine($"Количество элементов массива: {size}");

// int[] FillArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// // первый вариант - собираем новый массив из произведений пар.
// // В случае, если количество элементов исходного массива нечетное, среднее значение массива "выпадает" из обработки

// int[] GetPairProduct(int[] data)
// {
//     int[] product = new int[data.Length / 2];
//     int last = data.Length - 1;
//     for (int i = 0; i < data.Length / 2; i++)
//     {
//         product[i] = data[i] * data[last];
//         last = last - 1;
//     }
//     return product;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] array = FillArray(size, min, max);
// PrintArray(array);

// System.Console.WriteLine();
// System.Console.WriteLine("Первый вариант:");
// PrintArray(GetPairProduct(array));

// // воторой вариант с выводом среднего числа (если количество элементов массива нечетное)

// void PrintProductPairs(int[] dataArray)
// {
//     int last = dataArray.Length - 1;
//     for (int i = 0; i < dataArray.Length / 2; i++)
//     {
//         System.Console.WriteLine($"{dataArray[i]} x {dataArray[last]} = {dataArray[i] * dataArray[last]} ");
//         last--;
//     }
//     if (dataArray.Length % 2 > 0) System.Console.WriteLine($"Число {dataArray[dataArray.Length / 2]} не имеет пары");
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();
// System.Console.WriteLine("Второй вариант:");
// PrintProductPairs(array);