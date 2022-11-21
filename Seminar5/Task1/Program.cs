// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20

int size = 12;

int[] arr = GetRandomArray(size, -9, 9);

PrintArray(arr);
System.Console.WriteLine();

int negativeSum = GetSum(arr, false);

int positiveSum = GetSum(arr);

System.Console.WriteLine("positive = " +positiveSum);
System.Console.WriteLine("negative = " +negativeSum);

int GetSum(int[] arr, bool isPositive = true)
{
	if (isPositive)
	{
		return GetPositiveSum(arr);
	}
	else
	{
		return GetNegativeSum (arr);
	}
}

int GetPositiveSum(int[] arr)
{
	int sum = 0;
	for (int i = 0; i < arr.Length; i++)
		{
	      	if (arr[i] > 0) {sum += arr[i];}
		}
	return sum;	
}

int GetNegativeSum(int[] arr)
{
	int sum = 0;
	for (int i = 0; i < arr.Length; i++)
		{
	      	if (arr[i] < 0) {sum += arr[i];}
		}
	return sum;	
}

int[] GetRandomArray(int size, int begin, int last)   //заполнили массив случайными числами от -9 до 9, 12 элементов
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
		System.Console.Write(arr[i] + ", ");
		//System.Console.Write($"{arr[i]}, "); то же самое, что строчкой выше
	}
}
