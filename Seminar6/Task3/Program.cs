// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101    3 -> 11                   2 -> 10
int num = SetNumber("num");
int size = 32;          // int занимает 4 байта, т.е. 32 бита
//                      uint num = uint.MaxValue; // если ввести размер максимального объема
bool[] array = new bool[size];

for (int i = 0; num > 0; i++)
{						//  0  :    1
	array[size-i-1] = num % 2 == 0? false : true ;
	num /= 2;
	if (num < 0)
	{
		break;
	}
}
for (int i = 0; i < size; i++)
{
               Console.Write(array[i]? 1:0);
		   
		   // .TrimStart(new Char[] { '0' } - убрать начальные 00
}

int SetNumber(string str)
{
	System.Console.WriteLine($"Enter number {str}");
	int num  = int.Parse(Console.ReadLine());
	return num;
}


//****************************************************************************
// int num = SetNumber("num");

// int SetNumber(string str)
// {
//     System.Console.WriteLine($"Enter number {str}");
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }

// var isEven = require('is-even');
 
// isEven(0);
// //=> true
// isEven('1');
// //=> false
// isEven(2);
// //=> true
// isEven('3');
// //=> false