// Задача 35: З Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] arr = GetRandomArray(123, -150, 150);
PrintArray(arr);
int count = 0;
 
 for (int i = 0; i < arr.Length; i++)
 {
               if (arr[i] >= 10 && arr[i] <= 99)
		   {
			count++;
		   }
 }

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
System.Console.WriteLine();
System.Console.WriteLine($"В этом массиве {count} чисел от 10 до 99");

