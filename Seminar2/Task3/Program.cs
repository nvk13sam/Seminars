﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// Программа принимает на вход 2 числа и выводит, явлется ли первое число кратно второму 
// и если нет, то выводит остаток от деления

System.Console.WriteLine("Введите два числа");
int num1 = int.Parse(Console.ReadLine());// это тоже самое, что и Convert.ToInt32(strNumber)
// то есть конвертирует строку в число (целое)
int num2 = int.Parse(Console.ReadLine());
int result = num1 % num2;

if (result == 0)
{
	Console.WriteLine($"Число {num1} кратно {num2}");
}
else
{
	Console.WriteLine($"Число {num1} не кратно {num2}, остаток {result}");
}
