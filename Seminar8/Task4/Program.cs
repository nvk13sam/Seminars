// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

//Cоздание двумерного массива.
int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}
// Заполнение массива
int[,] FillArray(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    return array;
}
//выводим 1мерный массив
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// превращаем в 1-мерный массив
int[] GetRowArray(int[,] inArray)
{
	int[] result = new int [inArray.GetLength(0) * inArray.GetLength(1)];
	int index = 0;
	for (int i = 0; i < inArray.GetLength(0); i++)
	{
		for (int j = 0; j < inArray.GetLength(1); j++)
		{
			result[index] = inArray[i,j];
			index++;
		}
	}
	return result; 
}
//Сортируем 1мерный массив
void SortArray(int[] inArray) 
{
	for (int i = 1; i < inArray.Length; i++)
	{
		for (int j = 0; j < inArray.Length; j++)
		{
			if (inArray[i] > inArray[j])
			{
				int k = inArray[i];
				inArray[i] = inArray[j];
				inArray[j] = k;
			}
		}
	}
}
// выводим счетчик
void PrintData(int[] inArray)
{
	int el = inArray[0];
	int count = 0;
	for (int i = 0; i < inArray.Length; i++)
	{
		if (inArray[i] !=el)
		{
			Console.WriteLine($"{el} встречается {count} раз(а)");
			el = inArray[i];
			count = 1;
		}
		else
		{
			count++;
		}
	}
	Console.WriteLine($"{el} встречается {count} раз(а)");
}

// Решение
//Console.ReadLine();
// Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = CreateArray(rows, columns);  // получили 2-хмерный массив
array = FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] rowAr = GetRowArray(array);  // превращаем в 1-мерный массив
SortArray(rowAr);                   // сортируем одномерный массив
Console.WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);


/// <summary>
/// Получение размера массива
/// </summary>
/// <param name="number"> это число </param>
/// <param name="string"> это строка </param>
/// <returns>Число</returns>