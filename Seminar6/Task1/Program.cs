// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// В данном решении есть 2 метода - RevertArray(arr) и RevertArray2(arr);
int size = SetNumber("size");

int [] arr = GetRandomArray(size);

PrintArray(arr);
System.Console.WriteLine();

int[]revertArr = RevertArray2(arr);
PrintArray(revertArr);

int SetNumber(string str)				
{                              			
	System.Console.WriteLine($"Enter number {str}");           
	int num  = int.Parse(Console.ReadLine());
	return num;
}

int[] GetRandomArray(int size, int begin = 0, int last = 100)
{
	int[] arr = new int[size];
	Random random = new Random();

	for (int i = 0; i < size; i++)
	{
		arr[i]=random.Next(begin, last + 1);
	}
	return arr;
}

void PrintArray(int[]arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		System.Console.Write(arr[i] + "\t");
		//System.Console.Write($"{arr[i]} "); то же самое, что строчкой выше
	}
}
 
int [] RevertArray(int[] arr) 
{
	int size = arr.Length;
	int[] revertArr = new int[size];
	for (int i = 0; i < size; i++)       // Метод перемещения из конца в начало
	{
		revertArr[i] = arr[size - 1 - i];

	}
	return revertArr;
}
int [] RevertArray2(int[] arr) 
{
	int size = arr.Length;
	int[] revertArr = new int[size];     // Метод "переливания" соседних элементов через tmp
	for (int i = 0; i < size / 2; i++)
	{
		int tmp = arr[i];
		arr[i] = arr[size - 1 - i];
		arr[size - 1 - i] = tmp;

	}
	return arr;
}