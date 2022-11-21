// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int size = 10;

int [] arr = GetRandomArray(size, -100, 100);

PrintArray(arr);

int[] Converce = GetConverce(arr);

System.Console.WriteLine ();

PrintArray(Converce);

int[] GetRandomArray(int size, int begin, int last)
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

int[] GetConverce(int[] arr)
{              int[] Converce = new int [arr.Length];
               for (int i = 0; i < arr.Length; i++)
               {
                           Converce[i]= arr[i]* -1;   
               }
               return Converce;
}