
// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[] GetRandomArray(int size, int begin, int last)
{
    int[] arr = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			System.Console.Write($"{matrix[i, j]} ");
		}
		System.Console.WriteLine();
	}
}

int [] arr = GetRandomArray(9, 0, 9);
PrintArray(arr);
System.Console.WriteLine();
int[,] itog = new int [10,2];
for (int i = 0; i < 10; i++)
{
	itog[i,0] = i+1;
}
PrintMatrix(itog);



// for (int i = 0; i < arr.Length; i++)
// {
// 	if (arr[i] == itog[i,0]) itog	
// }

// for (int i = 0; i < length; i++)
// {
	
// }
