// Задача №1. Напишите программу, которая на вход
// принимает два числа и проверяет, является ли первое
// число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// V 1.0
// Console.WriteLine("Enter 2 numbers: ");
// string strnum1 = Console.ReadLine();
// string strnum2 = Console.ReadLine();
// int num1 = Convert.ToInt32(strnum1);
// int num2 = Convert.ToInt32(strnum2);
// int sqr = num2 * num2;
// if (num1 == sqr) Console.WriteLine($"Number {num1} is square {num2}");
// else {Console.WriteLine($"Number {num1} is not square {num2}");
// }
// V 2.0
Console.WriteLine("Enter 2 numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int sqr = num2 * num2;
if (num1 == sqr) Console.WriteLine($"Number {num1} is square {num2}");
else {Console.WriteLine($"Number {num1} is not square {num2}");
}


