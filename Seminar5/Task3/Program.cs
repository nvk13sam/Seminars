// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да

// int[] arr = GetRandomArray(5, -100, 100);
// System.Console.WriteLine("Введите искомое число");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintArray(arr);

// int[] GetRandomArray(int size, int begin, int last)
// {
//   	int[] arr = new int[size];
// 	Random random = new Random();

// 		for (int i = 0; i < size; i++)
//      		{
//          		arr[i] = random.Next(begin, last + 1);
//     		}
//     		return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + ", ");
//     }
// }

// bool CheckDigit(int[] arr, int value)
// {
//     for (int i = 0; i < arr.Length; i++)
//     	{
//         	if (arr[i] == Math.Abs(value)) // превращает число в модуль, то есть делает его положительным
//         	{
//             	return true;
//         	}
//     	}
// return false;
// }

// if(CheckDigit)
// 	{
// 	Console.WriteLine("Число есть в массиве");	
// 	}
// else 
// Console.WriteLine("Числа нет в массиве");	


//*******************************************************
int size = 15;

int[] arr = GetRandomArray(size, -100, 100);

PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine("Введите искомое число");
int num = Convert.ToInt32(Console.ReadLine());

PrintArray(arr);

int value = 0;
// bool posResult = CheckNum(arr, value);
// bool negResult = CheckNum(value, false);
// System.Console.WriteLine("positive = "+posResult);

// System.Console.WriteLine("negative = "+negResult);

if(CheckNum)
{
    System.Console.WriteLine("Число есть в массиве");
}
else
    System.Console.WriteLine("Числа нет в массиве");

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

bool CheckNum(int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    	{
        if (arr[i] == Math.Abs(value))
        	{
            	return true;
        	}
        
    	}
return false;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
}