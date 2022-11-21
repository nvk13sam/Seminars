// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
System.Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int max = num1;
int min = num2;
if (max < min)
{
               max = num2;
               min = num1;
}
if (max == Math.Pow(min, 2))//(max == min*min)
{
               Console.WriteLine($"Число {max} является квадратом числа {min}");     
}
else
{
               System.Console.WriteLine($"Число {max} НЕ является квадратом числа {min}");  
}